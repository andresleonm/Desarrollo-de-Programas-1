using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Product
    {
        private int id;
        private UnitOfMeasure unit;
        private string name;
        private int max_stock;
        private int min_stock;
        private int stock;
        private double average_cost;
        private double unit_price;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public UnitOfMeasure Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Max_stock
        {
            get { return max_stock; }
            set { max_stock = value; }
        }

        public int Min_stock
        {
            get { return min_stock; }
            set { min_stock = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public double Average_cost
        {
            get { return average_cost; }
            set { average_cost = value; }
        }

        public double Unit_price
        {
            get { return unit_price; }
            set { unit_price = value; }
        }

        public Product(int id, UnitOfMeasure unit, string name, int stock, int min_stock, int max_stock, double avg_cost, double price)
        {
            this.id = id;
            this.unit = unit;
            this.name = name;
            this.stock = stock;
            this.min_stock = min_stock;
            this.max_stock = max_stock;
            this.average_cost = avg_cost;
            this.unit_price = price;
        }

        public Product()
        {
        }

    }
}
