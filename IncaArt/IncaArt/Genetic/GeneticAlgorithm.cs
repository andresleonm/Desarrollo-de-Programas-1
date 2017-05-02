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
        private int numIterations;
        private int numInitialPopulation;
        private int porcCrossover;
        private int porcMutation;
        private int porcElitism;

        public GeneticAlgorithm(int numIterations, int numInitialPopulation, int porcCrossover,int porcMutation,int porcElitism)
        {
            this.numIterations = numIterations;
            this.numInitialPopulation = numInitialPopulation;
            this.porcCrossover = porcCrossover;
            this.porcMutation = porcMutation;
            this.porcElitism = porcElitism;
            
        }
        private Population generateInitialPopulation(List<Workstation> workstations,List<Worker> workers, List<Tuple<int, Product>> products_quantities, int needed_retablo, int needed_ceramico, int needed_piedra, List<ProductLineAssignment> solution)
        {
            Population pI = new Population(porcCrossover, porcMutation, porcElitism,products_quantities, needed_retablo, needed_ceramico, needed_piedra,solution);
            List<double> fitness= new List<double>();
            long n=0;
            for (int i = 0; i < numInitialPopulation; )
            {
                Chromosome c = new Chromosome(workstations, workers,products_quantities,needed_retablo,needed_ceramico,needed_piedra,solution);
                double tempfit = c.getFitness();
                if (!fitness.Contains(tempfit))
                {
                    pI.chromosomes.Add(c);
                    fitness.Add(c.getFitness());                
                    i +=1;
                    //Console.WriteLine(c.hasRepetitions());   
                    //Console.WriteLine("i" + i.ToString());
                }
                //Console.WriteLine("n" + n.ToString());
                n++;                
            }
            Console.WriteLine(n);
            return pI;
        }
        private Chromosome getBestSolution(Population p)
        {
            Chromosome best= null;
            bool flg = true;
            foreach (Chromosome c in p.chromosomes){
                if (flg)
                {
                    best = c;
                    flg = false;
                }else
                {
                    if (c < best)
                        best = c;
                }
            }
            return best;
        }

       

        private List<Workstation> getWorkStations(List<Workstation> ws)
        {
            List<Workstation> output = new List<Workstation>();
            foreach(Workstation w in ws)
            {
                //desdoblo los puestos de trabajo, es decir, si tengo en mi lista un puesto de trabajo con capacidad 10
                //en mi lista que ira para el algoritmo creo 10 puestos de trabajo
                output=output.Concat(w.Getworkstations()).ToList();
            }
            return output;
        }

        public Chromosome GeneticSolve (List<Workstation> workstations,List<Worker> workers, Order order ,System.IO.StreamWriter file,  System.IO.StreamWriter file2)
        {
            List<Tuple<int, Product>> products_quantities = new List<Tuple<int, Product>>(order.order_detail.lines.Count());
            for (int i = 0; i < products_quantities.Capacity; i++)
            {
                products_quantities.Add(Tuple.Create(order.order_detail.lines.ElementAt(i).quantity, order.order_detail.lines.ElementAt(i).product));
            }

            List<Workstation> admissible_workstations = new List<Workstation>();

            
            int needed_retablo = 0, needed_ceramico = 0, needed_piedra = 0;
            int retablo_sets = 0;
            int piedra_sets = 0;
            int ceramico_sets = 0;
            List<ProductLineAssignment> solution = new List<ProductLineAssignment>();

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
                            foreach (Tuple<int, Product> tuple in products_quantities)
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

            List<Workstation> workstationsA = getWorkStations(admissible_workstations);
            
            Population population = generateInitialPopulation(workstationsA, workers,products_quantities,needed_retablo,needed_ceramico,needed_piedra,solution);
            population.workstation = workstations;
            population.workers = workers;
            
                   

            file.WriteLine("Fitness de poblacion inicial: "+(1/getBestSolution(population).getFitnessR()).ToString());
            file2.WriteLine("Fitness de poblacion inicial: " + (getBestSolution(population).getFitness()).ToString());

            Console.WriteLine("Tiene repeticiones la poblacion inicial: " + getBestSolution(population).hasRepetitions());

            for (int i= 0; i < numIterations; i++)
            {
                getBestSolution(population).hasSameWorkstations();
                population.elitism();
                getBestSolution(population).hasSameWorkstations();
                population.roulette();
                getBestSolution(population).hasSameWorkstations();
                population.crossover();
                getBestSolution(population).hasSameWorkstations();
                population.mutate();
                getBestSolution(population).hasSameWorkstations();
                population.createNewGeneration();
                getBestSolution(population).hasSameWorkstations();
            }


            Chromosome bestSolution = getBestSolution(population);
            file.WriteLine("Fitness de mejor solucion: " + (1 / bestSolution.getFitnessR()).ToString());
            file2.WriteLine("Fitness de mejor solucion: " + ( bestSolution.getFitness()).ToString());


            Console.WriteLine("Posee repeticiones:" + bestSolution.hasRepetitions());
            Console.WriteLine("Numero de Cromosomas :" + population.chromosomes.Count());
            return bestSolution;
        }
    }
}
 