using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class UC_SimulationExecution : UserControl
    {
        public UC_SimulationExecution()
        {
            InitializeComponent();
        }

        private void metroGrid1_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                this.metroGrid1.Rows.Clear();
                List<Algorithm.ProductLineAssignment> solution =
                    ((UC_SimulationConfig)(Parent.Controls.Find("UC_SimulationConfig2", true))[0]).solution;
                if (solution.Count >= 1)
                {
                    string[] row = new string[3];
                    int count = 1;
                    foreach (Algorithm.ProductLineAssignment pla in solution)
                    {
                        foreach (Algorithm.Assignment assig in pla.assignments)
                        {
                            row[0] = assig.assigned_worker.name + " " + assig.assigned_worker.lastname;
                            row[1] = assig.assigned_workstation.name;
                            row[2] = count.ToString();
                            this.metroGrid1.Rows.Add(row);
                        }
                        count++;
                    }
                }
            }
        }
    }
}
