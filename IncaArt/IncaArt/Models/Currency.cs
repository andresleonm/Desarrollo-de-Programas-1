using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Currency
    {
        private int id;
        String symbol;
        String name;
        String state;

        public Currency()
        {
        }

        public Currency(int id, string symbol, string name, string state)
        {
            this.id = id;
            this.symbol = symbol;
            this.name = name;
            this.state = state;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

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

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }
    }
}
