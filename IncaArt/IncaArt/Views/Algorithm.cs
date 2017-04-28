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

namespace WindowsFormsApp1.Views
{
    public partial class Algorithm : Form
    {
        public Random rnd = new Random();
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
            OrderDetailLine line1 = new OrderDetailLine(product1, 10);
            OrderDetailLine line2 = new OrderDetailLine(product2, 20);
            OrderDetailLine line3 = new OrderDetailLine(product3, 15);
            List<OrderDetailLine> lines = new List<OrderDetailLine>();
            lines.Add(line1);
            lines.Add(line2);
            lines.Add(line3);
            OrderDetail order_detail = new OrderDetail(lines);
            Order order = new Order(order_detail,new DateTime(2017,4,26));
            //-------------------------------------------------- HARDCODED!!

            generateSolution(workers,workstations,order);            
        }

        private void generateSolution(List<Worker> workers, List<Workstation> workstations, Order order)
        {
            List<Workstation> admissible_workstations = new List<Workstation>();
            List<ProductLineAssignment> solution = new List<ProductLineAssignment>();
            List<Tuple<int, Product>> products_quantities;
            int max_iterations = 500;
            int retablo_sets = 0;
            int piedra_sets = 0;
            int ceramico_sets = 0;
            double priority_retablo_sets = 0;
            double priority_piedra_sets = 0;
            double priority_ceramico_sets = 0;

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
                            for (int i = 0; i < workstation.quantity; i++)
                            {
                                ProductLineAssignment pla = new ProductLineAssignment(workstation.product);
                                solution.Add(pla);
                            }
                        }
                        else if (workstation.name == "Tallado")
                        {
                            piedra_sets = workstation.quantity;
                            for (int i = 0; i < workstation.quantity; i++)
                            {
                                ProductLineAssignment pla = new ProductLineAssignment(workstation.product);
                                solution.Add(pla);
                            }
                        }
                        else if (workstation.name == "MoldeadoC")
                        {
                            ceramico_sets = workstation.quantity;
                            for (int i = 0; i < workstation.quantity; i++)
                            {
                                ProductLineAssignment pla = new ProductLineAssignment(workstation.product);
                                solution.Add(pla);
                            }
                        }
                    }
                }
            }

            products_quantities = new List<Tuple<int, Product>>(order.order_detail.lines.Count());
            foreach (Tuple<int, Product> tuple in products_quantities)
            {
                if (tuple.Item2.name == "Ceramico") priority_ceramico_sets = tuple.Item1 * tuple.Item2.unit_price;
                else if (tuple.Item2.name == "Retablo") priority_retablo_sets = tuple.Item1 * tuple.Item2.unit_price;
                else if (tuple.Item2.name == "Piedra") priority_piedra_sets = tuple.Item1 * tuple.Item2.unit_price;
            }
            for (int i = 0; i < products_quantities.Count(); i++)
            {
                products_quantities.Add(Tuple.Create(order.order_detail.lines.ElementAt(i).quantity, order.order_detail.lines.ElementAt(i).product));
            }

            List<Assignment> assignments = new List<Assignment>(); // REAL

            if (workers.Count() >= (retablo_sets * 2 + piedra_sets + ceramico_sets * 3)) // si hay más trabajadores que puestos de trabajo
            {
                int worker_index = 0;

                foreach (Workstation w in admissible_workstations)
                {
                    for (int i = 0; i < w.quantity; i++)
                    {
                        Assignment assignment = new Assignment(w);
                        assignment.assigned_worker = workers.ElementAt(worker_index);
                        worker_index++;
                        assignments.Add(assignment);
                    }
                }

                for (int x = 0; x < solution.Count(); x++) // MAQUETA (puestos de trabajos vacios)                 
                {
                    for (int y = 0; y < solution.ElementAt(x).assignments.Count(); y++)
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
                }
            }
            else // si hay más puestos de trabajo que trabajadores
            {

            }
                
                List<ProductLineAssignment> final_solution = tabuSearch(solution, max_iterations, products_quantities, workers);
                generateReport(final_solution);
            
            }
        

        private List<ProductLineAssignment> tabuSearch(List<ProductLineAssignment> initial_s, int max_iterations,List<Tuple<int,Product>> product_quantities,List<Worker> workers)
        {
            int iteration = 0;
            int max_tabu_size = 5;
            List<ProductLineAssignment> s = new List<ProductLineAssignment>();
            s = initial_s;
            List<ProductLineAssignment> s_best = new List<ProductLineAssignment>();
            Queue<List<ProductLineAssignment>> tabu_list = new Queue<List<ProductLineAssignment>>();
            List<ProductLineAssignment> best_candidate = new List<ProductLineAssignment>();
            List<List<ProductLineAssignment>> neighborhood = new List<List<ProductLineAssignment>>();

            neighborhood = generateNeighborhood(initial_s, workers);
            while (iteration <= max_iterations)
            {
                best_candidate = null;   
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
            }
            return s_best;
        }

        private List<List<ProductLineAssignment>> generateNeighborhood(List<ProductLineAssignment> solution,List<Worker> workers)
        {
            List<List<ProductLineAssignment>> neighborhood = new List<List<ProductLineAssignment>>();
            List<ProductLineAssignment> neighbor = new List<ProductLineAssignment>();
            for(int i=0; i<solution.Count()-1;i++) // REFINAR
            {
                neighbor = solution;
                List<Assignment> assignments1 = neighbor.ElementAt(i).assignments;
                List<Assignment> assignments2 = neighbor.ElementAt(i + 1).assignments;
                Assignment switch_candidate1 = assignments1.ElementAt(rnd.Next(0, assignments1.Count()));
                Assignment switch_candidate2 = assignments2.ElementAt(rnd.Next(0, assignments2.Count()));

                Worker aux_worker = neighbor.ElementAt(i).assignments.ElementAt(rnd.Next(0, assignments1.Count())).assigned_worker;

                neighbor.ElementAt(i).assignments.ElementAt(rnd.Next(0, assignments1.Count())).assigned_worker =
                    neighbor.ElementAt(i + 1).assignments.ElementAt(rnd.Next(0, assignments2.Count())).assigned_worker;

                neighbor.ElementAt(i + 1).assignments.ElementAt(rnd.Next(0, assignments2.Count())).assigned_worker = aux_worker;
                neighborhood.Add(neighbor);
            }
            return neighborhood;
        }

        private double fitness(List<ProductLineAssignment> solution,List<Tuple<int,Product>> product_quantities) // REFINAR
        {
            double total_break = 0;
            double total_time = 0;

            foreach(ProductLineAssignment set in solution)
            {
                double partial_break = 0;
                double partial_time = 0;
                foreach(Assignment assignment in set.assignments)
                {
                    foreach(Ratio r in assignment.assigned_worker.ratios_e)
                    {
                        if (r.workstation.Equals(assignment.assigned_workstation))
                        {
                            foreach(Tuple<int,Product> tuple in product_quantities)
                            {
                                if (tuple.Item2.Equals(assignment.assigned_workstation.product))
                                {
                                    partial_break = partial_break + (r.value * assignment.assigned_workstation.break_cost*tuple.Item1);
                                    break;
                                }
                            }
                        }
                    }
                }
                total_break = total_break + partial_break;
            }
            return total_break;
        }

        private void generateReport(List<ProductLineAssignment> solution)
        {
            Console.WriteLine("RESULTADOS DE LA ASIGNACIÓN");
            Console.WriteLine("----------------------------");

            for(int i=0; i<solution.Count();i++)
            {
                Console.WriteLine("LINEA DE PRODUCCION " + i);
                foreach(Assignment assignment in solution.ElementAt(i).assignments)
                {
                    Console.WriteLine("Trabajador: " + assignment.assigned_worker.name + " " + assignment.assigned_worker.name);
                    Console.WriteLine("Puesto de trabajo: " + assignment.assigned_workstation.name);
                    Console.WriteLine();
                }
            }
        }
    
    }
}
