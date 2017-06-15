using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Parameters
    {
        int id;
        String name;
        String value;
        String state;

        public Parameters()
        {
        }

        public Parameters(int id, String name, String value, String state)
        {
            this.Id = id;
            this.Name = name;
            this.Value = value;
            this.State = state;
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

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
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
