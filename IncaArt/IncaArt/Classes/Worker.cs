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

        public void print()
        {          
            Console.Write("Nombre  " + name + "-----");
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
