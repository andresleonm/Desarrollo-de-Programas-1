using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1.Models
{
    public class UnitOfMeasure
    {
        string symbol;
        string name;
        double factor;

        public string Symbol
        {
            get
            {
                return symbol;
            }

            set
            {
                symbol = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Factor
        {
            get
            {
                return factor;
            }

            set
            {
                factor = value;
            }
        }

        public UnitOfMeasure()
        {
            
        }
    }
}
