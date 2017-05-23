using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Warehouse
    {
        int id;
        string name;
        int max_capacity;
        int actual_capacity;
        int id_material;
        int id_product;

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

        public int Max_capacity
        {
            get
            {
                return max_capacity;
            }

            set
            {
                max_capacity = value;
            }
        }

        public int Actual_capacity
        {
            get
            {
                return actual_capacity;
            }

            set
            {
                actual_capacity = value;
            }
        }

        public int Id_material
        {
            get
            {
                return id_material;
            }

            set
            {
                id_material = value;
            }
        }

        public int Id_product
        {
            get
            {
                return id_product;
            }

            set
            {
                id_product = value;
            }
        }
    }
}
