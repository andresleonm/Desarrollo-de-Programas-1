﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Workstation
    {
        int id;
        int product_id;
        string name;
        int assigned_worker;
        int next_workstation;
        int previous_workstation;
        int quantity;
        double break_cost;
        int currency_id;
        int min_average_time;
        int max_average_time;
        public string complete_name { get; set; }

        public Workstation(int product_id, string name)
        {
            this.product_id = product_id;
            this.name = name;
        }

        public Workstation()
        {

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

        public int Next_workstation
        {
            get
            {
                return next_workstation;
            }

            set
            {
                next_workstation = value;
            }
        }

        public int Previous_workstation
        {
            get
            {
                return previous_workstation;
            }

            set
            {
                previous_workstation = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        
        public double Break_cost
        {
            get
            {
                return break_cost;
            }

            set
            {
                break_cost = value;
            }
        }

        public int Currency_id
        {
            get
            {
                return currency_id;
            }

            set
            {
                currency_id = value;
            }
        }

        public int Min_average_time
        {
            get
            {
                return min_average_time;
            }

            set
            {
                min_average_time = value;
            }
        }

        public int Max_average_time
        {
            get
            {
                return max_average_time;
            }

            set
            {
                max_average_time = value;
            }
        }

        public int Assigned_worker
        {
            get
            {
                return assigned_worker;
            }

            set
            {
                assigned_worker = value;
            }
        }
    }
}
