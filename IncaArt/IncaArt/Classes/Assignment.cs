using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Assignment
    {
        internal Worker assigned_worker { get; set; }
        internal Workstation assigned_workstation { get; set; }        

        public Assignment(Workstation assigned_workstation,Worker worker)
        {            
            this.assigned_workstation = assigned_workstation;
            this.assigned_worker = worker;
        }
    }
}
