﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PurchaseOrder
    {
        List<PurchaseOrderLine> lines;
        int id;
        int currency_id;
        int supplier_id;                
        double amount;
        string state;
        string observation;
        string external_number;
        double igv_amount;
        double igv_percentage;        
        DateTime creation_date;

        public PurchaseOrder(int id,int currency_id,int supplier_id,double amount,string state, DateTime creation_date, string observation,string external_number,double igv_amount,double igv_percentage)
        {
            this.id = id;
            this.currency_id = currency_id;
            this.supplier_id = supplier_id;
            this.amount = amount;
            this.state = state;
            this.observation = observation;
            this.external_number = external_number;
            this.igv_amount = igv_amount;
            this.igv_percentage = igv_percentage;            
            this.creation_date = creation_date;
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

        public int Supplier_id
        {
            get
            {
                return supplier_id;
            }

            set
            {
                supplier_id = value;
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
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

        public string Observation
        {
            get
            {
                return observation;
            }

            set
            {
                observation = value;
            }
        }

        public string External_number
        {
            get
            {
                return external_number;
            }

            set
            {
                external_number = value;
            }
        }

        public double Igv_amount
        {
            get
            {
                return igv_amount;
            }

            set
            {
                igv_amount = value;
            }
        }

        public double Igv_percentage
        {
            get
            {
                return igv_percentage;
            }

            set
            {
                igv_percentage = value;
            }
        }

        public DateTime Creation_date
        {
            get
            {
                return creation_date;
            }

            set
            {
                creation_date = value;
            }
        }

        public List<PurchaseOrderLine> Lines
        {
            get
            {
                return lines;
            }

            set
            {
                lines = value;
            }
        }

        public PurchaseOrder()
        {

        }


    }
}
