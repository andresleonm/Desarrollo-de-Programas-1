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
        public int numInitialPopulation = 1000;
        public int porcCrossover=60;
        public int porcMutation = 1;

        public Population generateInitialPopulation(List<Workstation> workStations,List<Worker> workers)
        {
            Population pI= new Population(porcCrossover,porcMutation);
            for (int i = 0; i < numInitialPopulation; i++)
            {
                pI.chromosomes.Add(new Chromosome(workStations, workers));
            }
            return pI;
        }
        public Chromosome getBestSolution(Population p)
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

        public Chromosome mutateChromosome(Chromosome c)
        {
            return c;
        }

        public List<Workstation> getWorkStations(List<Workstation> ws)
        {
            List<Workstation> output = new List<Workstation>();
            foreach(Workstation w in ws)
            {
                //desdoblo los puestos de trabajo, es decir, si tengo en mi lista un puesto de trabajo con capacidad 10
                //en mi lista que ira para el algoritmo creo 10 puestos de trabajo
                output.Concat(w.Getworkstations());
            }
            return output;
        }
        public List<Assignment> GeneticSolve (List<Workstation> workstations, List<Worker> workers, Order order)
        {
            List<Workstation> workstationsA = getWorkStations(workstations);
            
            Population population = generateInitialPopulation(workstationsA, workers);
            
            for (int i= 0; i < numIterations; i++)
            {
                population.roulette();
                population.crossover();
                population.mutate();
                //Elitismo
            }
            return getBestSolution(population).genes;
        }
    }
}
