﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Assignment
    {
        public Worker assigned_worker { get; set; }
        public Workstation assigned_workstation { get; set; }
       
        public void print()
        {
            assigned_worker.print();
            assigned_workstation.print();
        }
        public Assignment()
        {

        }

        public Assignment(Workstation assigned_workstation)
        {
            this.assigned_workstation = assigned_workstation;
        }

        public Assignment(Workstation assigned_workstation,Worker worker)
        {            
            this.assigned_workstation = assigned_workstation;
            this.assigned_worker = worker;
        }
    }
}
