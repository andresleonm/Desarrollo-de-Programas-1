﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Worker : Person
    {
        private List<Ratio> ratios { get; }
        public Worker(string name, string last_name) :base(name,last_name)
        {
            this.ratios = new List<Ratio>();            
        }
    }
}
