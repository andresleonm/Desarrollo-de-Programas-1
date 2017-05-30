﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Product
    {
        private int id;
        private UnitOfMeasure unit;
        private int unit_id;
        private string name;
        private int stock_max;
        private int stock_min;
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

        public int Unit_id
        {
            get
            {
                return unit_id;
            }

            set
            {
                unit_id = value;
            }
        }

        public int Stock_max
        {
            get
            {
                return stock_max;
            }

            set
            {
                stock_max = value;
            }
        }

        public int Stock_min
        {
            get
            {
                return stock_min;
            }

            set
            {
                stock_min = value;
            }
        }

        public Product(int id, UnitOfMeasure unit, string name, int stock, int min_stock, int max_stock, double avg_cost, double price)
        {
            this.id = id;
            this.unit = unit;
            this.name = name;
            this.stock = stock;
            this.stock_max = max_stock;
            this.stock_min = min_stock;
            this.average_cost = avg_cost;
            this.unit_price = price;
        }

        public Product(int id, int unit_id, string name, int stock_min, int stock_max,double price)
        {
            this.id = id;
            this.Unit_id = unit_id;
            this.name = name;
            this.stock_max = stock_max;
            this.stock_min = stock_min;
            this.unit_price = price;
        }

        public Product(int id, int unit_id, string name, int stock_min, int stock_max)
        {
            this.id = id;
            this.Unit_id = unit_id;
            this.name = name;
            this.stock_max = stock_max;
            this.stock_min = stock_min;
        }

        public Product()
        {
        }

        public override string ToString()
        {
            return name;
        }

    }
}
