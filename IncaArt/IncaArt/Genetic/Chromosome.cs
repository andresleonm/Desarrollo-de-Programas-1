using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;
using static WindowsFormsApp1.Classes.Assignment;

namespace WindowsFormsApp1.Genetic
{

    class Chromosome
    {
        public List<Assignment> genes = new List<Assignment>();
        public OrderDetail order; 
        public Chromosome()
        {

        }

        public bool hasRepetitions()
        {
            int rep = 0;
            List<string> names = new List<string>();
            foreach (Assignment a in genes)
            {
                if (!(names.Contains(a.assigned_worker.name + a.assigned_worker.lastname)))
                {
                    names.Add(a.assigned_worker.name + a.assigned_worker.lastname);
                }
                else
                {
                    rep++;
                }
            }
            if (rep == 0)
                return false;
            return true;
        }

        public bool hasRepetitionsW()
        {
            int rep = 0;
            List<string> names = new List<string>();
            foreach (Assignment a in genes)
            {
                if (!(names.Contains(a.assigned_workstation.name )))
                {
                    names.Add(a.assigned_workstation.name );
                }
                else
                {
                    rep++;
                }
            }
            if (rep == 0)
                return false;
            return true;
        }

        public void hasSameWorkstations()
        {
            
            List<string> names = new List<string>();
            List<int> rep = new List<int>();
            foreach (Assignment a in genes)
            {
                if (!(names.Contains(a.assigned_workstation.name)))
                {
                    names.Add(a.assigned_workstation.name );
                    rep.Add(1);
                }
                else
                {
                    int index = names.IndexOf(a.assigned_workstation.name);
                    rep[index]++;
                }
            }
            int n = rep.Count();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(names[i] + " " + rep[i].ToString());
            }          

        }
        public void print()
        {
            AssignmentComparer comparer = new AssignmentComparer();
            genes.Sort(comparer);
            foreach (Assignment a in genes)
            {
                a.print();
                Console.WriteLine();
            }
            
        }

        public void print(System.IO.StreamWriter file)
        {
            AssignmentComparer comparer = new AssignmentComparer();
            genes.Sort(comparer);
            foreach (Assignment a in genes)
            {
                a.print(file);
                file.WriteLine();
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
                        if (r.workstation.id == assignment.assigned_workstation.id && (r.type=="Efficiency"))
                        {
                            total_break = total_break + (1 - r.value) * assignment.assigned_workstation.break_cost;
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

        public List<int> indexRepeated() {
            List<string> names = new List<string>();
            List<int> repetidos = new List<int>();
          
            for (int i = 0; i < genes.Count; i++)
            {
                  String name = genes[i].assigned_worker.name + genes[i].assigned_worker.lastname;
                  if ((names.Contains(name))){
                   repetidos.Add(i);
                  }else{
                    names.Add(name);
                  }
            }
            return repetidos;
         }

        public List<int> indexRepeatedW()
        {
            List<string> names = new List<string>();
            List<int> repetidos = new List<int>();

            for (int i = 0; i < genes.Count; i++)
            {
                String name = genes[i].assigned_workstation.name ;
                if ((names.Contains(name)))
                {
                    repetidos.Add(i);
                }
                else
                {
                    names.Add(name);
                }
            }
            return repetidos;
        }

        public List<Worker> missingWorkers(List<Worker> w) {
            List<Worker> workers = new List<Worker>();
            List<string> names = new List<string>();
            //Los nombres de todos los trabajadores en el cromosoma actual

            foreach (Assignment a in genes)
            {
                String name = a.assigned_worker.name + a.assigned_worker.lastname;
                if (!(names.Contains(name)))
                {
                    names.Add(name);
                }
            }
            //Busco si falta algun nombre con otro cromosoma como referencia
            for (int i = 0; i < w.Count; i++)
            {
                String name = w[i].name + w[i].lastname;
                if (!(names.Contains(name)))
                {
                    workers.Add(w[i]);
                }              
            }
            return workers;
        }

        public List<Workstation> missingWorkstations(List<Workstation> w)
        {
            List<Workstation> workstations = new List<Workstation>();
            List<string> names = new List<string>();

            foreach (Assignment a in genes)
            {
                String name = a.assigned_workstation.name;
                if (!(names.Contains(name)))
                {
                    names.Add(name);
                }
            }
            //Busco si falta algun nombre con otro cromosoma como referencia
            for (int i = 0; i < w.Count; i++)
            {
                String name = w[i].name ;
                if (!(names.Contains(name)))
                {
                    workstations.Add(w[i]);
                }
            }
            return workstations;
        }

        /*
        public static Chromosome operator +(Chromosome a, Chromosome b)
        {
            Chromosome c,temp= new Chromosome();
   
            Random rand = new Random();
            int numAssignments = a.genes.Count();
            int cut = rand.Next() % numAssignments;
            //Agregar primera parte del primer cromosoma
            c = a.cut(0, cut);

            ////Agregar parte del segundo cromosoma
            temp = b.cut(cut);
            c.genes = c.genes.Concat(temp.genes).ToList();
            if (c.hasRepetitions())
            {
                List<int> repeated = c.indexRepeated();
               // Console.WriteLine("El padre tiene repeticioes?:" + a.hasRepetitions()+"el otro"+b.hasRepetitions());
                //List<Worker> missingW = c.missingWorkers(a);
                for(int i=0;i<repeated.Count;i++) {
                    //c.genes[repeated[i]].assigned_worker = missingW[i];
                }
            }
            //Console.WriteLine("Tiene repeticiones despues de correciones?"+c.hasRepetitions());             

                return c;
        }*/
    }


    class ChromosomeComparer : IComparer<Chromosome>
    {
        public int Compare(Chromosome a, Chromosome b)
        {
            double fita=a.getFitness(),fitb=b.getFitness();
            if (fita ==fitb)
                return 0;
            if (fita < fitb)
                return -1;

            return 1;
        }
    }
}

