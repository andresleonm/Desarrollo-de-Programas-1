using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
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
        public Worker()
        {

        }
             
        public Worker(string name, string last_name) :base(name,last_name)
        {
            this.ratios = new List<Ratio>();            
        }
    }
}
