using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Worker : Person
    {
        private List<Ratio> ratios_t { get; set; }
        private List<Ratio> ratios_e { get; set; }
        public Worker(string name, string last_name) :base(name,last_name)
        {
            this.ratios_t = new List<Ratio>();
            this.ratios_e = new List<Ratio>();      
        }
    }
}
