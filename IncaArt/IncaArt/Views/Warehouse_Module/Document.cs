﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Views.Warehouse_Module
{
    public class Document
    {
        public string name { get; set; }
        public string id { get; set; }
        public string tipo { get; set; }

        public Document(string name,string id,string tipo)
        {
            this.name=name;
            this.id = id;
            this.tipo = tipo;

        }
    }
}