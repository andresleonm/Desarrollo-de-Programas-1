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

        private double getFitness()
        {
            double total_break = 0;                

            foreach (Assignment assignment in genes)
            {
                foreach (Ratio r in assignment.assigned_worker.ratios_e)
                {
                    if (r.workstation == assignment.assigned_workstation)
                    {
                        total_break = total_break + r.value * assignment.assigned_workstation.break_cost;
                    }
                }
            }          
            return total_break;
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
            int n=0;
            foreach (int indexWorkstation in indexa)
            {
                int indexWorker = indexb.ElementAt(n);
                genes.Add(new Assignment(workstations.ElementAt(indexWorkstation), workers.ElementAt(indexWorker)));
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
    }
}

