using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1.Views
{
    public partial class Algorithm : Form
    {
        public Random rnd = new Random();

        public int MAX_ITER = 8000;
        public int TABU_SIZE = 10;
        public int NEIGHBORHOOD_SIZE = 50;
        public int COMBINATION_QUANTITY = 100;

        public int needed_piedra = 0;
        public int needed_ceramico = 0;
        public int needed_retablo = 0;

        int[,] quantityW = new int[30, 6] { { 18,18,18,16,15,15},
                                            {10,10,10,8,13,13 },
                                            { 5,5,5,10,10,10},
                                            {4,4,4,6,5,5 },
                                            { 8,8,8,8,2,2},
                                            {6,6,6,2,8,8 },
                                            {9,9,9,16,15,15},
                                            {3,3,3,7,11,11 },
                                            { 7,7,7,5,9,9},
                                            {4,4,4,6,7,7 },
                                            { 9,9,9,13,12,12},
                                            {10,10,10,6,4,4 },
                                            { 1,1,1,1,1,1},
                                            {2,2,2,2,2,2 },
                                            { 2,2,2,4,3,3},
                                            {3,3,3,5,4,4 },
                                            {8,8,8,2,1,1 },
                                            {13,13,13,6,3,3 },
                                            {4,4,4,3,13,13 },
                                            { 6,6,6,3,7,7},
                                            {20,20,20,10,15,15 },
                                            { 10,10,10,25,20,20},
                                            {12,12,12,16,14,14 },
                                            {14,14,14,18,15,15 },
                                            {11,11,11,13,16,16 },
                                            {8,8,8,20,20,20 },
                                            {9,9,9,14,18,18},
                                            {13,13,13,16,15,15 },
                                            {14,14,14,12,10,10 },
                                            {6,6,6,10,25,25 }};

        int[,] quantityP = new int[30, 3] { { 250,150,100},
                                            {200,100,50 },
                                            {150,250,100},
                                            {100,250,150 },
                                            {50,25,30},
                                            {22,10,15 },
                                            {10,13,16},
                                            {20,20,20 },
                                            {25,30,45},
                                            {100,20,25 },
                                            { 80,60,40},
                                            {40,40,30 },
                                            { 5,5,5},
                                            {10,10,10 },
                                            { 1,3,2},
                                            {3,4,4 },
                                            {6,3,2 },
                                            {10,10,10 },
                                            {6,5,14 },
                                            {8,12,16},
                                            {100,100,100 },
                                            {200,100,300},
                                            {80,90,120 },
                                            {60,100,70 },
                                            {30,60,20 },
                                            {90,20,70 },
                                            {10,80,80},
                                            {30,100,20 },
                                            {200,30,150 },
                                            {60,60,20 }};


        private int getQuantityP(string name, int ind)
        {
            int indx = 0;
            if (name == "Retablo")
                indx = 0;
            if (name == "Ceramico")
                indx = 1;
            if (name == "Piedra")
                indx = 2;           
            return quantityP[ind, indx];

        }

        private int getQuantityW(string name, int ind)
        {
            int indx = 0;
            if (name == "MoldeadoC")
                indx = 0;
            if (name == "PintadoC")
                indx = 1;
            if (name == "Horneado")
                indx = 2;
            if (name == "Tallado")
                indx = 3;
            if (name == "MoldeadoR")
                indx = 4;
            if (name == "PintadoR")
                indx = 5;            
            return quantityW[ind, indx];
        }

        public Algorithm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < 30; i++)
            {
                initializeParameters(i);
            }
                      
        }

        public void initializeParameters(int i)
        {
            List<ProductLineAssignment> initial_s = new List<ProductLineAssignment>(); // solución inicial
            List<Worker> workers = new List<Worker>(); // lista de trabajadores
            //List<Workstation> workstations = new List<Workstation>(); // lista de puestos de trabajo
            //-------------------------------------------------- HARDCODED!!
            Product product1 = new Product("Retablo", 0, 2.5);
            Product product2 = new Product("Ceramico", 0, 3.0);
            Product product3 = new Product("Piedra", 0, 5.0);
            OrderDetailLine line1 = new OrderDetailLine(product1, getQuantityP("Retablo", i));
            OrderDetailLine line2 = new OrderDetailLine(product2, getQuantityP("Ceramico", i));
            OrderDetailLine line3 = new OrderDetailLine(product3, getQuantityP("Piedra", i));
            List<OrderDetailLine> lines = new List<OrderDetailLine>();
            lines.Add(line1);
            lines.Add(line2);
            lines.Add(line3);
            OrderDetail order_detail = new OrderDetail(lines);
            Order order = new Order(order_detail, new DateTime(2017, 4, 26));
            List<Workstation> workstations = new List<Workstation>();
            readWorkstations(ref workstations, product1, product2, product3);
            foreach (Workstation ws in workstations)
            {
                ws.quantity = getQuantityW(ws.name, i);
            }
            //-------------------------------------------------- HARDCODED!!

            //readWorkstations(ref workstations,product1,product2,product3);
            readWorkers(ref workers,workstations);
            generateSolution(workers,workstations,order,i);            
        }

        private void generateSolution(List<Worker> workers, List<Workstation> workstations, Order order,int numA)
        {
            List<Workstation> admissible_workstations = new List<Workstation>();
            List<ProductLineAssignment> solution = new List<ProductLineAssignment>();
            List<Tuple<int, Product>> products_quantities;            
            int retablo_sets = 0;
            int piedra_sets = 0;
            int ceramico_sets = 0;
            double priority_retablo_sets = 0;
            double priority_piedra_sets = 0;
            double priority_ceramico_sets = 0;

            products_quantities = new List<Tuple<int, Product>>(order.order_detail.lines.Count());

            for (int i = 0; i < products_quantities.Capacity; i++)
            {
                products_quantities.Add(Tuple.Create(order.order_detail.lines.ElementAt(i).quantity, order.order_detail.lines.ElementAt(i).product));
            }

            foreach (Workstation workstation in workstations)
            {
                foreach (OrderDetailLine line in order.order_detail.lines)
                {
                    if (workstation.product.Equals(line.product))
                    {
                        admissible_workstations.Add(workstation);
                        if (workstation.name == "MoldeadoR")
                        {
                            retablo_sets = workstation.quantity;                                                        
                            foreach(Tuple<int,Product> tuple in products_quantities)
                            {
                                if (tuple.Item2.name == "Retablo")
                                {
                                    needed_retablo = Math.Min(retablo_sets, tuple.Item1);
                                }
                            }
                            for (int i = 0; i < needed_retablo; i++)
                            {
                                ProductLineAssignment pla = new ProductLineAssignment(workstation.product);
                                solution.Add(pla);
                            }
                        }
                        else if (workstation.name == "Tallado")
                        {
                            piedra_sets = workstation.quantity;                            
                            foreach (Tuple<int, Product> tuple in products_quantities)
                            {
                                if (tuple.Item2.name == "Piedra")
                                {
                                    needed_piedra = Math.Min(piedra_sets, tuple.Item1);
                                }
                            }
                            for (int i = 0; i < needed_piedra; i++)
                            {
                                ProductLineAssignment pla = new ProductLineAssignment(workstation.product);
                                solution.Add(pla);
                            }
                        }
                        else if (workstation.name == "MoldeadoC")
                        {
                            ceramico_sets = workstation.quantity;                            
                            foreach (Tuple<int, Product> tuple in products_quantities)
                            {
                                if (tuple.Item2.name == "Ceramico")
                                {
                                    needed_ceramico = Math.Min(ceramico_sets, tuple.Item1);
                                }
                            }
                            for (int i = 0; i < needed_ceramico; i++)
                            {
                                ProductLineAssignment pla = new ProductLineAssignment(workstation.product);
                                solution.Add(pla);
                            }
                        }
                    }
                }
            }            

            foreach (Tuple<int, Product> tuple in products_quantities)
            {
                if (tuple.Item2.name == "Ceramico") priority_ceramico_sets = tuple.Item1 * tuple.Item2.unit_price;
                else if (tuple.Item2.name == "Retablo") priority_retablo_sets = tuple.Item1 * tuple.Item2.unit_price;
                else if (tuple.Item2.name == "Piedra") priority_piedra_sets = tuple.Item1 * tuple.Item2.unit_price;
            }
            

            List<Assignment> assignments = new List<Assignment>(); // REAL

            if (workers.Count() >= (needed_retablo * 2 + needed_piedra + needed_ceramico * 3)) // si hay más trabajadores que puestos de trabajo
            {
                List<int> workers_index = new List<int>(workers.Count());
                for(int j = 0; j< workers_index.Capacity; j++)
                {                   
                    int random = rnd.Next(0, workers.Count());
                    while (workers_index.Contains(random))
                    {
                        random = rnd.Next(0, workers.Count());
                    }
                    workers_index.Add(random);                    
                }
                int worker_index = 0;

                WorkerComparer wc = new WorkerComparer();
                workers.Sort(wc);

                foreach (Workstation w in admissible_workstations)
                {
                    for (int i = 0; i < w.quantity; i++)
                    {
                        Assignment assignment = new Assignment(w);
                        assignment.assigned_worker = workers.ElementAt(workers_index.ElementAt(worker_index));
                        //assignment.assigned_worker = workers.ElementAt(worker_index);
                        worker_index++;
                        assignments.Add(assignment);
                    }
                }
                                              
                for (int x = 0; x < solution.Count(); x++) // MAQUETA (puestos de trabajos vacios)                 
                {
                    for (int y = 0; y < solution.ElementAt(x).assignments.Capacity; y++)
                    {                  
                        try
                        {
                            foreach (Assignment a in assignments) // REAL
                            {
                                if (a.assigned_workstation.name == solution.ElementAt(x).assignments.ElementAt(y).assigned_workstation.name)
                                {
                                    solution.ElementAt(x).assignments.ElementAt(y).assigned_workstation = a.assigned_workstation;
                                    solution.ElementAt(x).assignments.ElementAt(y).assigned_worker = a.assigned_worker;
                                    assignments.Remove(a);
                                }
                            }
                        }
                        catch (System.InvalidOperationException e)
                        {

                        }
                    }
                }
            }
            else // si hay más puestos de trabajo que trabajadores
            {

            }
            //generateReport(solution,products_quantities);
            
            DateTime tiempo1 = DateTime.Now;
            List<ProductLineAssignment> final_solution = tabuSearch(solution, products_quantities, workers);
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            double ahorro = Math.Round((((fitness(final_solution, products_quantities)) - fitness(solution, products_quantities)) / fitness(final_solution, products_quantities)) * 100, 2);
            generateReport(solution,final_solution, products_quantities, total, ahorro,numA);
                     

        }
        

        private List<ProductLineAssignment> tabuSearch(List<ProductLineAssignment> initial_s,List<Tuple<int,Product>> product_quantities,List<Worker> workers)
        {
            
            List<ProductLineAssignment> s = new List<ProductLineAssignment>();            
            List<ProductLineAssignment> s_best = new List<ProductLineAssignment>();
            Queue<List<ProductLineAssignment>> tabu_list = new Queue<List<ProductLineAssignment>>();
            List<ProductLineAssignment> best_candidate = new List<ProductLineAssignment>();
            List<List<ProductLineAssignment>> neighborhood = new List<List<ProductLineAssignment>>();

            int iteration = 0;
            int max_tabu_size = TABU_SIZE; // REFINAR
            s = initial_s;
            s_best = initial_s;
            
            while (iteration <= MAX_ITER)
            {
                best_candidate = null;
                neighborhood = generateNeighborhood(s, workers,iteration);
                foreach (List<ProductLineAssignment> candidate in neighborhood)
                {
                    if ((!tabu_list.Contains(candidate)) && (fitness(candidate,product_quantities) > fitness(best_candidate,product_quantities)))
                    {
                        best_candidate = candidate;
                    }
                }
                s = best_candidate;
                if (fitness(best_candidate,product_quantities) > fitness(s_best,product_quantities))
                {
                    s_best = best_candidate;
                }
                if(tabu_list.Count() > max_tabu_size)
                {
                    tabu_list.Dequeue();
                }
                tabu_list.Enqueue(best_candidate);
                iteration++;
            }
            return s_best;
        }

        private List<List<ProductLineAssignment>> generateNeighborhood(List<ProductLineAssignment> solution,List<Worker> workers,int iteration)
        {
            List<List<ProductLineAssignment>> neighborhood = new List<List<ProductLineAssignment>>();
            for(int i=0; i<NEIGHBORHOOD_SIZE;i++) // REFINAR            
            {
                if (((iteration%COMBINATION_QUANTITY)==0) && ((needed_ceramico*3 + needed_piedra + needed_retablo*2)!= workers.Count()))
                {
                    List<ProductLineAssignment> neighbor = new List<ProductLineAssignment>();
                    copyElements(ref neighbor, solution);
                    int index1 = (rnd.Next(0, neighbor.ElementAt(i % solution.Count()).assignments.Count()));
                    int index2 = rnd.Next(0, workers.Count());
                    bool continue_iter = true;
                    while (continue_iter)
                    {
                        for(int j=0; j < neighbor.Count(); j++)
                        {
                            for(int k=0; k< neighbor.ElementAt(j).assignments.Count(); k++)
                            {
                                if (neighbor.ElementAt(j).assignments.ElementAt(k).assigned_worker.Equals(workers.ElementAt(index2)))
                                {
                                    continue_iter = true; // Si ya está sigo iterando                                    
                                    break;
                                }else
                                {
                                    continue_iter = false;
                                }
                            }
                            if (continue_iter)
                            {
                                index2 = rnd.Next(0, workers.Count());
                                break;
                            }
                        }                        
                    }
                    neighbor.ElementAt(i % solution.Count()).assignments.ElementAt(index1).assigned_worker = workers.ElementAt(index2);
                    neighborhood.Add(neighbor);
                }
                else
                {
                    List<ProductLineAssignment> neighbor = new List<ProductLineAssignment>();
                    copyElements(ref neighbor, solution);
                    int index1 = (rnd.Next(0, neighbor.ElementAt(i % solution.Count()).assignments.Count()));
                    int index2 = (rnd.Next(0, neighbor.ElementAt((i + 1) % solution.Count()).assignments.Count()));
                    List<Assignment> assignments1 = neighbor.ElementAt(i % solution.Count()).assignments;
                    List<Assignment> assignments2 = neighbor.ElementAt((i + 1) % solution.Count()).assignments;
                    Assignment switch_candidate1 = assignments1.ElementAt(index1);
                    Assignment switch_candidate2 = assignments2.ElementAt(index2);

                    Worker aux_worker = switch_candidate1.assigned_worker;

                    switch_candidate1.assigned_worker = switch_candidate2.assigned_worker;

                    switch_candidate2.assigned_worker = aux_worker;
                    neighborhood.Add(neighbor);
                }
               
            }
            return neighborhood;
        }

        private double fitness(List<ProductLineAssignment> solution,List<Tuple<int,Product>> product_quantities) // REFINAR
        {
            if(solution == null) return -1;

            double total_break = 0;
            double total_time = 0;

            foreach(ProductLineAssignment set in solution)
            {
                double partial_break = 0;
                double partial_time = 0;
                double product_quantity = 0;
                foreach(Assignment assignment in set.assignments)
                {
                    foreach(Ratio r in assignment.assigned_worker.ratios)
                    {
                        if (r.workstation.Equals(assignment.assigned_workstation) && (r.type=="Efficiency"))
                        {
                            foreach(Tuple<int,Product> tuple in product_quantities)
                            {
                                if (tuple.Item2.Equals(assignment.assigned_workstation.product))
                                {                                    
                                    partial_break = partial_break + (1 - r.value) * assignment.assigned_workstation.break_cost;
                                    if(tuple.Item2.name == "Retablo") product_quantity = tuple.Item1/needed_retablo;
                                    else if(tuple.Item2.name == "Ceramico") product_quantity = tuple.Item1 / needed_ceramico;
                                    else if(tuple.Item2.name == "Piedra") product_quantity = tuple.Item1 / needed_piedra;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                total_break = total_break + (partial_break/set.assignments.Count())* product_quantity;
                //total_break = total_break + partial_break;
            }            
            return 1/total_break;
        }

        private void generateReport(List<ProductLineAssignment> ini_solution, List<ProductLineAssignment> solution,List<Tuple<int,Product>> product_quantities,TimeSpan time, double ahorro,int numA)
        {

            double fit = Math.Round(1 / fitness(solution, product_quantities), 2);
            StreamWriter file = new System.IO.StreamWriter("TabuSearch_"+numA.ToString()+"_"+fit.ToString()+".txt");

            file.WriteLine("RESULTADOS DE LA SOLUCIÓN INICIAL");
            file.WriteLine("----------------------------");
            file.WriteLine("Fitness: " + Math.Round(1 / fitness(ini_solution, product_quantities), 2));
            file.WriteLine("");

            file.WriteLine("RESULTADOS DE LA SOLUCIÓN FINAL");
            file.WriteLine("----------------------------");
            file.WriteLine("Fitness: " + fit);
            file.WriteLine("Ahorro: " + ahorro);
            file.WriteLine("Tiempo de Ejecución: " + time.ToString());
            file.WriteLine("");

            file.WriteLine("ASIGNACIÓN");
            file.WriteLine("----------------------------");

            for(int i=0; i<solution.Count();i++)
            {
                file.WriteLine("LINEA DE PRODUCCION " + (i+1));
                foreach(Assignment assignment in solution.ElementAt(i).assignments)
                {
                    file.Write("Trabajador: " + assignment.assigned_worker.name + " " + assignment.assigned_worker.lastname);
                    for(int j=0; j < assignment.assigned_worker.ratios.Count(); j++)
                    {
                        if(assignment.assigned_worker.ratios.ElementAt(j).workstation.name == assignment.assigned_workstation.name)
                        {
                            file.Write(" Eficiencia: " + assignment.assigned_worker.ratios.ElementAt(j).value);
                            file.WriteLine(" (" + assignment.assigned_worker.ratios.ElementAt(j).workstation.name + ")");
                            break;
                        }
                    }
                    file.WriteLine("Puesto de trabajo: " + assignment.assigned_workstation.name);
                    file.WriteLine();
                }
            }
            file.Close();
        }

        private void readWorkers(ref List<Worker> workers,List<Workstation> workstations)
        {
            workers = JsonConvert.DeserializeObject<List<Worker>>(File.ReadAllText("worker.json"));
            foreach (Worker w in workers)
            {
                foreach (Ratio r in w.ratios)
                {
                    foreach (Workstation ws in workstations)
                    {
                        if (r.workstationid == ws.id)
                        {
                            r.workstation = ws;
                        }

                    }
                }
            }
            
        }

        private void readWorkstations(ref List<Workstation> workstations,Product retablo, Product ceramico, Product piedra)
        {
            workstations = JsonConvert.DeserializeObject<List<Workstation>>(File.ReadAllText("workstation.json"));
            foreach(Workstation w in workstations)
            {
                if(w.name == "MoldeadoC" || w.name == "PintadoC" || w.name == "Horneado")
                {
                    w.product = ceramico;
                }
                else if(w.name == "Tallado")
                {
                    w.product = piedra;
                }
                else if(w.name == "MoldeadoR" || w.name == "PintadoR")
                {
                    w.product = retablo;
                }
            }
        }

        private void copyElements(ref List<ProductLineAssignment> pla1, List<ProductLineAssignment> pla2)
        {

            for(int i=0; i< pla2.Count(); i++)
            {
                ProductLineAssignment aux = new ProductLineAssignment(pla2.ElementAt(i).assignments.ElementAt(0).assigned_workstation.product);
                for(int j=0; j< pla2.ElementAt(i).assignments.Count(); j++)
                {
                    aux.assignments.ElementAt(j).assigned_worker = new Worker();
                    aux.assignments.ElementAt(j).assigned_worker = pla2.ElementAt(i).assignments.ElementAt(j).assigned_worker;
                    aux.assignments.ElementAt(j).assigned_workstation = pla2.ElementAt(i).assignments.ElementAt(j).assigned_workstation;
                }
                pla1.Add(aux);                
            }                       
        }
    }
}
