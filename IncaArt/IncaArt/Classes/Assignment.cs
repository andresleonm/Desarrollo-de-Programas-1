using System;
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
            assigned_workstation.print();
            assigned_worker.print(assigned_workstation, "Efficiency");               
        }

        public void print(System.IO.StreamWriter file)
        {
            assigned_workstation.print(file);
            assigned_worker.print(assigned_workstation, "Efficiency",file);
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

        public class AssignmentComparer : IComparer<Assignment>
        {
            public int Compare(Assignment a, Assignment b)
            {
                if (a.assigned_workstation.id == b.assigned_workstation.id)
                {
                    double ra = a.assigned_worker.getRatio(a.assigned_workstation, "Efficiency");
                    double rb = b.assigned_worker.getRatio(b.assigned_workstation, "Efficiency");
                    if (ra == rb)
                        return 0;
                    if (ra < rb)
                        return -1;
                    return 1;
                }
                if (a.assigned_workstation.id < b.assigned_workstation.id)
                    return -1;
                return 1;


            }
        }
    }
}
