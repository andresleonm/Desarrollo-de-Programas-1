using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Genetic
{
    

    class Population
    {
        public List<Chromosome> chromosomes = new List<Chromosome>();
        List<Chromosome> matingPool = new List<Chromosome>();
        List<Chromosome> bestSolutions = new List<Chromosome>();
        //QUITAR
        public List<Worker> workers = new List<Worker>();
        public List<Workstation> workstation = new List<Workstation>();
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

        public Chromosome singlePointCrossover(Chromosome a, Chromosome b) {
            Chromosome c, temp = new Chromosome();

            Random rand = new Random();
            int numAssignments = a.genes.Count();
            int cut = rand.Next() % numAssignments;
            //Agregar primera parte del primer cromosoma
            c = a.cut(0, cut);
            /*
            ////Agregar parte del segundo cromosoma con las asignaciones de los puestos de trabajo faltantes
            //Inicializar arreglo con cantidad 0 de workstation presentes en cromosoma
            List<int> cantWorkstation = new List<int>();
            for(int i=0;i< workstation.Count;i++)
            {
                cantWorkstation.Add(0);
            }
            //Aumentar la cantidad de workstation presentes en el cromosoma con los puestos de trabajo del primer padre
            foreach(Assignment assig in c.genes)
            {
                for(int j=0;j<workstation.Count;j++)
                {
                    if (workstation[j].name == assig.assigned_workstation.name) {
                        cantWorkstation[j]= cantWorkstation[j]+1;
                    }
                }
            }
            //agregar los puestos de trabajo faltantes con asignaciones del segundo padre
            foreach(Assignment assig in b.genes)
            {
                for (int j = 0; j < workstation.Count; j++)
                {
                    if (workstation[j].name == assig.assigned_workstation.name)
                    {
                        if (cantWorkstation[j] < workstation[j].quantity) {
                            cantWorkstation[j] = cantWorkstation[j] + 1;
                            c.genes.Add(assig);
                            j = workstation.Count;
                        }
                    }
                }
            }
            */
            temp = b.cut(cut);
            c.genes = c.genes.Concat(temp.genes).ToList();
            if (c.hasRepetitions())
            {
                List<int> repeated = c.indexRepeated();
                //Console.WriteLine("El padre tiene repeticioes?:" + a.hasRepetitions() + "el otro" + b.hasRepetitions());
                List<Worker> missingW = c.missingWorkers(this.workers);
                for (int i = 0; i < repeated.Count; i++)
                {
                    c.genes[repeated[i]].assigned_worker = missingW[i];
                }
            }
           //Console.WriteLine("Tiene repeticiones despues de correciones?" + c.hasRepetitions());

            return c;
        }
        
        public void crossover()
        {
           
            List<Chromosome> arrAux = new List<Chromosome>();
            Chromosome c1,c2,aux1,aux2;
            int n = matingPool.Count()*porC/100;                    
           
            for (int i = 0; i < n; i+=2)
            {
                c1 = matingPool.ElementAt(i);
                c2 = matingPool.ElementAt(i + 1);

                //Single point crossover
                //aux2 = c2 + c1;
                //aux1 = c1+c2;
                aux2 = singlePointCrossover(c2, c1);
                aux1 = singlePointCrossover(c1, c2);


                arrAux.Add(aux1);
                arrAux.Add(aux2);
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
               // Console.WriteLine("Elitismo:" + c.getFitness() + "repetidos?" + c.hasRepetitions());
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
            ChromosomeComparer comparer=new ChromosomeComparer();
            array.Sort(comparer);
           
            for(int i = 0; i < numElitism; i++)
            {
                Chromosome c= new Chromosome();
                for(int j=0;j<array[i].genes.Count;j++) {
                    Assignment a = new Assignment();             
                    a.assigned_worker = array[i].genes[j].assigned_worker;
                    a.assigned_workstation = array[i].genes[j].assigned_workstation;
                    c.genes.Add(a);

                }
                bestSolutions.Add(c);
                //Console.WriteLine("Dentro de funcion elitismo:" + c.getFitness() +" tiene repeticiones?"+c.hasRepetitions());
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
            if (flg)
            {
                lowFit = lowestfit;
                fitAvg = fitness / size;
                flg = false;
            }else
            {
                if (lowestfit < lowFit)
                {
                    lowFit = lowestfit;
                }
                if ((fitness / size) < fitAvg)
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
