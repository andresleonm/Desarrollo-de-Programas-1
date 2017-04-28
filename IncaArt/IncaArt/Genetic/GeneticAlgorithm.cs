using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Genetic
{
    class GeneticAlgorithm
    {
        public int numIterations=3000;
        private double fitness(Chromosome c, List<Tuple<int, Product>> product_quantities) // REFINAR
        {
            double total_break = 0;
            //double total_time = 0;

            foreach (ProductLineAssignment set in c.genes)
            {
                double partial_break = 0;
                //double partial_time = 0;
                foreach (Assignment assignment in set.assignments)
                {
                    foreach (Ratio r in assignment.assigned_worker.ratios_e)
                    {
                        if (r.workstation.Equals(assignment.assigned_workstation))
                        {
                            foreach (Tuple<int, Product> tuple in product_quantities)
                            {
                                if (tuple.Item2.Equals(assignment.assigned_workstation.product))
                                {
                                    partial_break = partial_break + (r.value * assignment.assigned_workstation.break_cost * tuple.Item1);
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

        public Population generateInitialPopulation(List<Workstation> workStations,List<Worker> workers)
        {
            Population pI= new Population();
            return pI;

        }
        public Chromosome getBestSolution(Population p)
        {
            Chromosome c = new Chromosome();
            return c;
        }

        public Chromosome mutateChromosome(Chromosome c)
        {
            return c;
        }

        public List<ProductLineAssignment> GeneticSolve (List<Workstation> workStations, List<Worker> workers, Order order)
        {
            //generar poblacion inicial
            Population population = generateInitialPopulation(workStations,workers);
            
            for (int i= 0; i < numIterations; i++)
            {
                //eliminar cromosomas
                //generar nuevos cromosomas
                // mutar cromosomas
            }
            return getBestSolution(population).genes;
        }
    }
}
