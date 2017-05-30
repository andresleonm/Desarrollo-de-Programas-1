using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Profile
    {
        int id;
        string description;
        List<Functionality> functionalities;

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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public List<Functionality> Functionalities
        {
            get
            {
                return functionalities;
            }

            set
            {
                functionalities = value;
            }
        }

        public Profile(int id, string description, List<Functionality> functionalities)
        {
            this.id = id;
            this.description = description;
            this.functionalities = functionalities;
        }

        public Profile(int id, string description)
        {
            this.id = id;
            this.description = description;
            this.functionalities = new List<Functionality>();
        }

        public Profile()
        {

        }
    }
}
