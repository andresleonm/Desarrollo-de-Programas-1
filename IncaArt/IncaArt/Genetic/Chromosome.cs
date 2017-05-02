using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;
using static WindowsFormsApp1.Classes.Assignment;

namespace WindowsFormsApp1.Genetic
{

    class Chromosome
    {
        public List<Assignment> genes = new List<Assignment>();
        public List<Tuple<int, Product>> products_quantities;
        public int needed_retablo;
        public int needed_ceramico;
        public int needed_piedra;
        List<ProductLineAssignment> solution;
        public Chromosome( List<Tuple<int, Product>> products_quantities,int needed_retablo,int needed_ceramico,int needed_piedra, List<ProductLineAssignment>  solution)
        {
            this.products_quantities = products_quantities;
            this.needed_ceramico = needed_ceramico;
            this.needed_piedra = needed_piedra;
            this.needed_retablo = needed_retablo;
            this.solution = solution;
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
            return;
            Console.WriteLine("-------------");
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
            Console.WriteLine("-------------");

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
            //return getFitnessR();
            double total_break = 0;

            foreach (Assignment assignment in genes)
            {
                try
                {
                    foreach (Ratio r in assignment.assigned_worker.ratios)
                    {
                        if (r.workstation.id == assignment.assigned_workstation.id && (r.type == "Efficiency"))
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
        public double getFitnessR()
        {            
            return fitness(Convert(), products_quantities);
        }

        private double fitness(List<ProductLineAssignment> solution, List<Tuple<int, Product>> product_quantities) // REFINAR
        {
            if (solution == null) return -1;

            double total_break = 0;
            double total_time = 0;

            foreach (ProductLineAssignment set in solution)
            {
                double partial_break = 0;
                double partial_time = 0;
                double product_quantity = 0;
                foreach (Assignment assignment in set.assignments)
                {
                    foreach (Ratio r in assignment.assigned_worker.ratios)
                    {
                        if (r.workstation.id==assignment.assigned_workstation.id  && (r.type == "Efficiency"))
                        {
                            foreach (Tuple<int, Product> tuple in product_quantities)
                            {
                                if (tuple.Item2.name==assignment.assigned_workstation.product.name)
                                {
                                    //partial_break = partial_break + ((1-r.value) * assignment.assigned_workstation.break_cost*tuple.Item1);
                                    partial_break = partial_break + (1 - r.value) * assignment.assigned_workstation.break_cost;
                                    if (tuple.Item2.name == "Retablo") product_quantity = tuple.Item1 / needed_retablo;
                                    else if (tuple.Item2.name == "Ceramico") product_quantity = tuple.Item1 / needed_ceramico;
                                    else if (tuple.Item2.name == "Piedra") product_quantity = tuple.Item1 / needed_piedra;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                total_break = total_break + (partial_break / set.assignments.Count()) * product_quantity;
                //total_break = total_break + partial_break;
            }
            return 1 / total_break;
        }

        public Chromosome cut(int ini,int fin)
        {
            Chromosome c= new Chromosome(this.products_quantities,this.needed_retablo,this.needed_ceramico,this.needed_piedra,this.solution);
            for (int i = ini; i < fin; i++)
            {
                Assignment a = new Assignment();
                a.assigned_worker = genes.ElementAt(i).assigned_worker;
                a.assigned_workstation = genes.ElementAt(i).assigned_workstation;
                c.genes.Add(a);
            }
            return c;

        }
        public Chromosome cut(int ini)
        {
            Chromosome c = new Chromosome(this.products_quantities,this.needed_retablo,this.needed_ceramico,this.needed_piedra,this.solution);
            int n = genes.Count();
            for (int i = ini; i < n; i++)
            {
                Assignment a = new Assignment();
                a.assigned_worker = genes.ElementAt(i).assigned_worker;
                a.assigned_workstation = genes.ElementAt(i).assigned_workstation;
                c.genes.Add(a);
               
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
        public Chromosome(List<Workstation> workstations, List<Worker> workers, List<Tuple<int, Product>> products_quantities, int needed_retablo, int needed_ceramico, int needed_piedra, List<ProductLineAssignment> solution) {
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
            GenesComparer comparer = new GenesComparer();
            genes.Sort(comparer);
            this.products_quantities = products_quantities;
            this.needed_ceramico = needed_ceramico;
            this.needed_piedra = needed_piedra;
            this.needed_retablo = needed_retablo;
            this.solution = solution;
        }

        public static bool operator ==(Chromosome a, Chromosome b)
        {
            if (a.getFitness()==b.getFitness())
                return true;
            return false;
        }

        public  List<Assignment> DeepCopy()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, genes);
                ms.Position = 0;
                return (List<Assignment>)formatter.Deserialize(ms);
            }
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

        public List<ProductLineAssignment> Convert()
        {
            List<Assignment> assignments = DeepCopy();
            List<int> states = new List<int>();
            //int numgenes=
            //for (int i=0;i<)
            for (int x = 0; x<solution.Count(); x++) // MAQUETA (puestos de trabajos vacios)                 
            {
                for (int y = 0; y<solution.ElementAt(x).assignments.Capacity; y++)
                {
                    try
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
                    }catch(System.InvalidOperationException e)
                    {

                    }
                }
            }
            return solution;
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
    class GenesComparer : IComparer<Assignment>
    {
        public int Compare(Assignment a, Assignment b)
        {
            String name1 = a.assigned_workstation.name, name2 = b.assigned_workstation.name;
            return String.Compare(name1,name2);
        }
    }
}

