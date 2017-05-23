using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Material
    {
        int id;
        UnitOfMeasure unit;
        String name;
        int max_stock;
        int min_stock;
        int status;

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

        public UnitOfMeasure Unit
        {
            get
            {
                return unit;
            }

            set
            {
                unit = value;
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

        public int Max_stock
        {
            get
            {
                return max_stock;
            }

            set
            {
                max_stock = value;
            }
        }

        public int Min_stock
        {
            get
            {
                return min_stock;
            }

            set
            {
                min_stock = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
