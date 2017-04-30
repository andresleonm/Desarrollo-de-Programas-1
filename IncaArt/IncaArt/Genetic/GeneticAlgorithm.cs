﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Genetic
{
    class GeneticAlgorithm
    {
        private int numIterations=3000;
        private int numInitialPopulation = 1000;
        private int porcCrossover=0;
        private int porcMutation = 1;
        private int porcElitism = 1;

        public GeneticAlgorithm(int numIterations, int numInitialPopulation, int porcCrossover,int porcMutation,int porcElitism)
        {
            this.numIterations = numIterations;
            this.numInitialPopulation = numInitialPopulation;
            this.porcCrossover = porcCrossover;
            this.porcMutation = porcMutation;
            this.porcElitism = porcElitism;
            
        }
        private Population generateInitialPopulation(List<Workstation> workStations,List<Worker> workers)
        {
            Population pI = new Population(porcCrossover, porcMutation, porcElitism);
            for (int i = 0; i < numInitialPopulation; i++)
            {
                pI.chromosomes.Add(new Chromosome(workStations, workers));
            }
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

        public List<Assignment> GeneticSolve (List<Workstation> workstations, List<Worker> workers)
        {
            List<Workstation> workstationsA = getWorkStations(workstations);
            
            Population population = generateInitialPopulation(workstationsA, workers);
            
            for (int i= 0; i < numIterations; i++)
            {
                population.elitism();
                population.roulette();
                population.crossover();
                population.mutate();
                population.createNewGeneration();
            }
            return getBestSolution(population).genes;
        }
    }
}
