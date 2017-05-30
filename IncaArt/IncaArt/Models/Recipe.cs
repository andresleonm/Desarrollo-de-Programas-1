using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Recipe
    {
        int id;
        int product_id;
        string name;
        string description;

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

        public int Product_id
        {
            get
            {
                return product_id;
            }

            set
            {
                product_id = value;
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

        public Recipe(int id, int product_id, string name, string description)
        {
            this.Id = id;
            this.Product_id = product_id;
            this.Name = name;
            this.description = description;
        }

        public Recipe(int id, int product_id, string name)
        {
            this.Id = id;
            this.Product_id = product_id;
            this.Name = name;
        }

        public Recipe()
        {
        }
    }
}