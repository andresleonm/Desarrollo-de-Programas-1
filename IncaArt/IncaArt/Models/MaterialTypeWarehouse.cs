using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class MaterialTypeWarehouse
    {
        int id;
        String name;
        String wclass;
        String state;


        public MaterialTypeWarehouse(int id, string name, string wclass, string state)
        {
            this.id = id;
            this.name = name;
            this.wclass = wclass;
            this.state = state;
        }
        public MaterialTypeWarehouse()
        {
            this.id = 0;
            this.name = "";
            this.wclass = "";
            this.state = "";
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

        public string Wclass
        {
            get
            {
                return wclass;
            }

            set
            {
                wclass = value;
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
