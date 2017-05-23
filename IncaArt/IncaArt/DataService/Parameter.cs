using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataService
{
    public class Parameter
    {
        public string name { get; set; }
        public string value { get; set; }

        public Parameter(string parameter_name,string parameter_value)
        {
            name = parameter_name;
            value = parameter_value;
        }
    }
}
