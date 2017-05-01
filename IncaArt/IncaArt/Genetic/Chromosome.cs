using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Genetic
{
    class Chromosome
    {
        public List<Assignment> genes = new List<Assignment>();

        public Chromosome()
        {

        }

        public void print()
        {
            foreach(Assignment a in genes)
            {
                a.print();
                Console.WriteLine();
            }
            
        }
        public double getFitness()
        {
            double total_break = 0;                

            foreach (Assignment assignment in genes)
            {
                try
                {
                    foreach (Ratio r in assignment.assigned_worker.ratios)
                    {
                        if (r.workstation.id == assignment.assigned_workstation.id)
                        {
                            total_break = total_break + r.value * assignment.assigned_workstation.break_cost;
                            break;
                        }
                    }

                }
                catch
                {

                }
                
            }          
            return total_break;
        }

        public Chromosome cut(int ini,int fin)
        {
            Chromosome c= new Chromosome();
            for (int i = ini; i < fin; i++)
            {
                c.genes.Add(genes.ElementAt(i));
            }
            return c;

        }
        public Chromosome cut(int ini)
        {
            Chromosome c = new Chromosome();
            int n = genes.Count();
            for (int i = ini; i < n; i++)
            {
                c.genes.Add(genes.ElementAt(i));
            }
            return c;
        }

        private  List<int> DesordenarLista(List<int> input)
        {
            List<int> arr = input;
            List<int> arrDes = new List<int>();

            Random randNum = new Random();
            while (arr.Count > 0)
            {
                int val = randNum.Next(0, arr.Count - 1);
                arrDes.Add(arr[val]);
                arr.RemoveAt(val);
            }
            return arrDes;
        }

        public void mutate() {
            Random rand = new Random();
            int i = rand.Next(0,genes.Count);
            int j = rand.Next(0,genes.Count);          

            Worker w1 = genes[i].assigned_worker;
            Worker w2 = genes[j].assigned_worker;
            genes[i].assigned_worker = w2;
            genes[j].assigned_worker = w1;
        }

        private List<int> getArray(int n)
        {
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(i);
            return DesordenarLista(a);
        }
        public Chromosome(List<Workstation> workstations, List<Worker> workers) {
            List<int> indexa= getArray(workstations.Count());
            List<int> indexb = getArray(workers.Count());
            int n=0,numWorkers=workers.Count();
            
            foreach (int indexWorkstation in indexa)
            {
                if (n>= numWorkers)
                {
                    genes.Add(new Assignment(workstations.ElementAt(indexWorkstation),null));
                }else
                {
                    int indexWorker = indexb.ElementAt(n);
                    genes.Add(new Assignment(workstations.ElementAt(indexWorkstation), workers.ElementAt(indexWorker)));
                }               
                n++;
            }
        }

        public static bool operator ==(Chromosome a, Chromosome b)
        {
            if (a.getFitness()==b.getFitness())
                return true;
            return false;
        }

        public static bool operator !=(Chromosome a, Chromosome b)
        {
            if (a.getFitness() != b.getFitness())
                return true;
            return false;
        }

        public static bool operator >(Chromosome a, Chromosome b)
        {
            if (a.getFitness() > b.getFitness())
                return true;
            return false;
        }

        public static bool operator <(Chromosome a, Chromosome b)
        {
            if (a.getFitness() < b.getFitness())
                return true;
            return false;
        }

        public static Chromosome operator +(Chromosome a, Chromosome b)
        {
            Chromosome c= new Chromosome();
            c.genes=c.genes.Concat(a.genes).ToList();
            c.genes=c.genes.Concat(b.genes).ToList();
            return c;
        }
    }
}

