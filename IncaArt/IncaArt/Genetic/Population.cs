﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Genetic
{
    class Population
    {
        public List<Chromosome> chromosomes = new List<Chromosome>();
        List<Chromosome> matingPool = new List<Chromosome>();
        List<Chromosome> bestSolutions = new List<Chromosome>();
        public int porC;
        public int porM;
        public int porE;
        public double fitAvg;
        public double lowFit;
        public bool flg=true;
        public Population(int porC,int porM,int porE)
        {
            this.porC = porC;
            this.porM = porM;
            this.porE = porE;
        }

        public void crossover()
        {
            List<Chromosome> arrAux = new List<Chromosome>();
            Chromosome c1,c2,temp;
            int n = matingPool.Count()*porC/100;
            Random rand = new Random();            
            int numAssignments = chromosomes.ElementAt(0).genes.Count();
            for (int i = 0; i < n; i+=2)
            {
                c1 = matingPool.ElementAt(i);
                c2 = matingPool.ElementAt(i + 1);                
                int cut = rand.Next() % numAssignments;
                temp = c1.cut(0, cut);
                c1 = c2.cut(0, cut) + c1.cut(cut);
                c2 = temp + c2.cut(cut);
                arrAux.Add(c1);
                arrAux.Add(c2);
            }
            matingPool.Clear();
            foreach (Chromosome c in arrAux)
            {
                matingPool.Add(c);
            }
        }

        public void createNewGeneration() {
            chromosomes.Clear();
            //elitism
            foreach(Chromosome c in bestSolutions)
            {
                chromosomes.Add(c);
            }
            //croosover y mutacion
            foreach(Chromosome c in matingPool)
            {
                chromosomes.Add(c);
            }
        }

        public void mutate()
        {
            int numMutation = porM * matingPool.Count/100;
            Random rand = new Random();
            int index;
            for(int i = 0; i < numMutation; i++)
            {
                index = rand.Next(0, matingPool.Count);
                matingPool[index].mutate();
            }
        }

        public void printFitness()
        {
            foreach(Chromosome c in chromosomes)
            {
                //c.print();
                Console.WriteLine(c.getFitness());
            }

        }

        public void elitism()
        {
            bestSolutions.Clear();
            List<Chromosome> array = chromosomes;
            int numElitism = chromosomes.Count * porE/100;
            for(int i = 0; i < numElitism; i++)
            {
                bestSolutions.Add(array[i]);
            }

        }

        public void roulette()
        {            
            List<double> roulette = new List<double>(), fitArray = new List<double>();
            double tempfit = 0,fitness=0;
            int size =chromosomes.Count();
            double lowestfit =9999999;
            Random spin = new Random();
            double value;
            matingPool.Clear();

            for (int i = 0; i < size; i++)
            {
                tempfit = chromosomes.ElementAt(i).getFitness();
                if (i==0)
                {
                    lowestfit = tempfit;                    
                }else
                {
                    if (tempfit < lowestfit)
                        lowestfit = tempfit;
                }
                fitArray.Add(tempfit);
                fitness = fitness + tempfit;
            }

            for (int i = 0; i < size; i++)
            {
                if (i == 0)
                    roulette.Add( fitArray[i] / fitness);
                else
                    roulette.Add(roulette[i - 1] + fitArray[i] / fitness);
            }
            roulette[size - 1] = 1;
            if (flg)
            {
                lowFit = lowestfit;
                fitAvg = fitness / size;
                flg = false;
            }else
            {
                if (lowestfit > lowFit)
                {
                    lowFit = lowestfit;
                }
                if ((fitness / size) > fitAvg)
                {
                    fitAvg = fitness / size;
                }
            }
            

            for (int j = 0; j < size; j++)
            {
                int i = 0;
                value = spin.NextDouble();
                while (value > roulette[i]) i++;
                matingPool.Add(chromosomes.ElementAt(i));
            }

        }
    }
}
