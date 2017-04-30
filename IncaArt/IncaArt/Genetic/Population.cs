using System;
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
        public int porC;
        public int porM;
        public double fitAvg;
        public double lowFit;
        public bool flg=true;
        public Population(int porC,int porM)
        {
            this.porC = porC;
            this.porM = porM;
        }

        public void crossover()
        {
            Chromosome c1,c2,temp;
            int n = matingPool.Count();
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
                chromosomes[i]=c1;
                chromosomes[i + 1] = c2;
            }
        }

        public void mutate()
        {

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
