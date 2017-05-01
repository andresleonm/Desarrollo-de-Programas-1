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
using WindowsFormsApp1.Genetic;

namespace WindowsFormsApp1.Views
{
    public partial class Algorithm : Form
    {
        public Random rnd = new Random();
        public int MAX_ITER = 5000;
        public int TABU_SIZE = 10;
        public int NEIGHBORHOOD_SIZE = 30;
        public Algorithm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            initializeParameters();            
        }

        public void initializeParameters()
        {
            List<ProductLineAssignment> initial_s = new List<ProductLineAssignment>(); // solución inicial
            List<Worker> workers = new List<Worker>(); // lista de trabajadores
            List<Workstation> workstations = new List<Workstation>(); // lista de puestos de trabajo
            //-------------------------------------------------- HARDCODED!!
            Product product1 = new Product("Retablo", 0, 2.5);
            Product product2 = new Product("Ceramico", 0, 3.0);
            Product product3 = new Product("Piedra", 0, 5.0);
            OrderDetailLine line1 = new OrderDetailLine(product1, 200);
            OrderDetailLine line2 = new OrderDetailLine(product2, 150);
            OrderDetailLine line3 = new OrderDetailLine(product3, 100);
            List<OrderDetailLine> lines = new List<OrderDetailLine>();
            lines.Add(line1);
            lines.Add(line2);
            lines.Add(line3);
            OrderDetail order_detail = new OrderDetail(lines);
            Order order = new Order(order_detail,new DateTime(2017,4,26));
            //-------------------------------------------------- HARDCODED!!
            
            readWorkstations(ref workstations,product1,product2,product3);
            readWorkers(ref workers,workstations);
            generateSolution(workers,workstations,order);            
        }

        private void generateSolution(List<Worker> workers, List<Workstation> workstations, Order order)
        {
            List<Workstation> admissible_workstations = new List<Workstation>();
            List<ProductLineAssignment> solution = new List<ProductLineAssignment>();
            List<Tuple<int, Product>> products_quantities;
            int max_iterations = 5000;
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
                            int needed_workstation = 0;                            
                            foreach(Tuple<int,Product> tuple in products_quantities)
                            {
                                if (tuple.Item2.name == "Retablo")
                                {
                                    needed_workstation = Math.Min(retablo_sets, tuple.Item1);
                                }
                            }
                            for (int i = 0; i < needed_workstation; i++)
                            {
                                ProductLineAssignment pla = new ProductLineAssignment(workstation.product);
                                solution.Add(pla);
                            }
                        }
                        else if (workstation.name == "Tallado")
                        {
                            piedra_sets = workstation.quantity;
                            int needed_workstation = 0;
                            foreach (Tuple<int, Product> tuple in products_quantities)
                            {
                                if (tuple.Item2.name == "Piedra")
                                {
                                    needed_workstation = Math.Min(piedra_sets, tuple.Item1);
                                }
                            }
                            for (int i = 0; i < needed_workstation; i++)
                            {
                                ProductLineAssignment pla = new ProductLineAssignment(workstation.product);
                                solution.Add(pla);
                            }
                        }
                        else if (workstation.name == "MoldeadoC")
                        {
                            ceramico_sets = workstation.quantity;
                            int needed_workstation = 0;
                            foreach (Tuple<int, Product> tuple in products_quantities)
                            {
                                if (tuple.Item2.name == "Ceramico")
                                {
                                    needed_workstation = Math.Min(ceramico_sets, tuple.Item1);
                                }
                            }
                            for (int i = 0; i < needed_workstation; i++)
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

            if (workers.Count() >= (retablo_sets * 2 + piedra_sets + ceramico_sets * 3)) // si hay más trabajadores que puestos de trabajo
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

                foreach (Workstation w in admissible_workstations)
                {
                    for (int i = 0; i < w.quantity; i++)
                    {
                        Assignment assignment = new Assignment(w);
                        //assignment.assigned_worker = workers.ElementAt(workers_index.ElementAt(worker_index));
                        assignment.assigned_worker = workers.ElementAt(worker_index);
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
                        }catch(System.InvalidOperationException e)
                        {

                        }
                    }
                }
            }
            else // si hay más puestos de trabajo que trabajadores
            {

            }
            generateReport(solution,products_quantities);
                
                List<ProductLineAssignment> final_solution = tabuSearch(solution,products_quantities, workers);
                generateReport(final_solution,products_quantities);
            Console.WriteLine("Ahorro: " + Math.Floor((((fitness(final_solution, products_quantities)) - fitness(solution, products_quantities))/ fitness(final_solution, products_quantities))*100),2);
            
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
                neighborhood = generateNeighborhood(s, workers);
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

        private List<List<ProductLineAssignment>> generateNeighborhood(List<ProductLineAssignment> solution,List<Worker> workers)
        {
            List<List<ProductLineAssignment>> neighborhood = new List<List<ProductLineAssignment>>();
            for(int i=0; i<NEIGHBORHOOD_SIZE;i++) // REFINAR            
            {
                List<ProductLineAssignment> neighbor = new List<ProductLineAssignment>();
                //if (i < NEIGHBORHOOD_SIZE - 1)
                //{
                    copyElements(ref neighbor, solution);
                    int index1 = (rnd.Next(0, neighbor.ElementAt(i%solution.Count()).assignments.Count()));
                    int index2 = (rnd.Next(0, neighbor.ElementAt((i+1)%solution.Count()).assignments.Count()));
                    List <Assignment> assignments1 = neighbor.ElementAt(i%solution.Count()).assignments;
                    List<Assignment> assignments2 = neighbor.ElementAt((i + 1)%solution.Count()).assignments;
                    Assignment switch_candidate1 = assignments1.ElementAt(index1);
                    Assignment switch_candidate2 = assignments2.ElementAt(index2);

                    Worker aux_worker = switch_candidate1.assigned_worker;

                    switch_candidate1.assigned_worker = switch_candidate2.assigned_worker;

                    switch_candidate2.assigned_worker = aux_worker;
                    neighborhood.Add(neighbor);                    
                //}
                /*else if (i == NEIGHBORHOOD_SIZE - 1)
                {
                    neighbor = solution;
                    int index1 = (rnd.Next(0, neighbor.ElementAt(i).assignments.Count()));
                    int index2 = (rnd.Next(0, neighbor.ElementAt(0).assignments.Count()));
                    List<Assignment> assignments1 = neighbor.ElementAt(i).assignments;
                    List<Assignment> assignments2 = neighbor.ElementAt(0).assignments;
                    Assignment switch_candidate1 = assignments1.ElementAt(index1);
                    Assignment switch_candidate2 = assignments2.ElementAt(index2);

                    Worker aux_worker = switch_candidate1.assigned_worker;

                    switch_candidate1.assigned_worker = switch_candidate2.assigned_worker;

                    switch_candidate2.assigned_worker = aux_worker;
                    neighborhood.Add(neighbor);
                }*/
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
                                    //partial_break = partial_break + ((1-r.value) * assignment.assigned_workstation.break_cost*tuple.Item1);
                                    partial_break = partial_break + (1 - r.value) * assignment.assigned_workstation.break_cost;
                                    product_quantity = tuple.Item1;
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

        private void generateReport(List<ProductLineAssignment> solution,List<Tuple<int,Product>> product_quantities)
        {
            Console.WriteLine("RESULTADOS DE LA ASIGNACIÓN");
            Console.WriteLine("----------------------------");

            for(int i=0; i<solution.Count();i++)
            {
                Console.WriteLine("LINEA DE PRODUCCION " + i);
                foreach(Assignment assignment in solution.ElementAt(i).assignments)
                {
                    Console.WriteLine("Trabajador: " + assignment.assigned_worker.name + " " + assignment.assigned_worker.lastname);
                    Console.WriteLine("Puesto de trabajo: " + assignment.assigned_workstation.name);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Fitness: " + Math.Floor(1/fitness(solution,product_quantities)));
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            List<Worker> workers = new List<Worker>();
            List<Workstation> workstations = new List<Workstation>(); 
            Product product1 = new Product("Retablo", 0, 2.5);
            Product product2 = new Product("Ceramico", 0, 3.0);
            Product product3 = new Product("Piedra", 0, 5.0);       
            
            readWorkstations(ref workstations, product1, product2, product3);
            readWorkers(ref workers, workstations);
            GeneticAlgorithm g = new GeneticAlgorithm(3000,100,40,2,10);
            Chromosome solucion = g.GeneticSolve(   workstations, workers);            
        }
    }
}
