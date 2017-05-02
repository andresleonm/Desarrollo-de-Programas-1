using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    [Serializable]
    class Worker : Person
    {
        public int shift_id { get; set; }
        public List<Ratio> ratios { get; set; }        

        public double getRatio(Workstation ws,string ratio_type)
        {
            foreach(Ratio r in ratios)
            {
                if (r.workstation.id == ws.id && r.type == "Efficiency")
                    return r.value;
            }
            Console.WriteLine("No existe ratio " + ratio_type+ " para el trabajador "+name);
            return 1;
        }
        public void print()
        {          
            Console.WriteLine("Nombre: " + name );
        }
        public void print(Workstation ws, string ratio_type)
        {
            Console.WriteLine("Nombre: " + name +' '+lastname);
            Console.WriteLine("Ratio:  "+ getRatio(ws,ratio_type).ToString());
        }

        public void print(Workstation ws, string ratio_type, System.IO.StreamWriter file)
        {
            file.WriteLine("Nombre: " + name + ' ' + lastname);
            file.WriteLine("Ratio:  " + getRatio(ws, ratio_type).ToString());
        }
        public Worker()
        {

        }
             
        public Worker(string name, string last_name) :base(name,last_name)
        {
            this.ratios = new List<Ratio>();            
        }

        
        }
    class WorkerComparer : IComparer<Worker>
    {
        public int Compare(Worker w1, Worker w2)
        {
            double average1 = 0;
            double average2 = 0;

            for (int i = 0; i < w1.ratios.Count(); i++)
            {
                if(w1.ratios.ElementAt(i).type == "Efficiency")
                average1 = average1 + w1.ratios.ElementAt(i).value;
            }
            average1 = average1 / w1.ratios.Count();

            for (int j = 0; j < w2.ratios.Count(); j++)
            {
                if (w2.ratios.ElementAt(j).type == "Efficiency")
                    average2 = average2 + w2.ratios.ElementAt(j).value;
            }
            average2 = average2 / w2.ratios.Count();

            if (average1 == average2)
                return 0;
            if (average1 < average2)
                return -1;
            return 1;
        }
    }

}
