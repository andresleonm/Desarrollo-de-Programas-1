using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Person
    {
        private string name { get; set; }
        private string last_name { get; set; }

        public Person(string name, string last_name)
        {
            this.name = name;
            this.last_name = last_name;            
        }                
        
    }
}
