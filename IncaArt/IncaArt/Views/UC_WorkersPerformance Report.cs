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
    public partial class WorkersPerformance_Report : UserControl
    {
        string user = "dp1admin";
        string password = "dp1admin";

        Controller.ProductionOrderWorkLineController work_controller;
        Controller.WorkstationsController workstation_controller;
        public WorkersPerformance_Report()
        {
            InitializeComponent();
            work_controller = new Controller.ProductionOrderWorkLineController(user, password);
            workstation_controller = new Controller.WorkstationsController(user, password);
        }

        private void WorkersPerformance_Report_Load(object sender, EventArgs e)
        {

        }

        void Load_datagrid_WorkersPerformance(List<Models.Worker> workers)
        {
            if((workers!=null) && (workers.Count > 0))
            {
                datagrid_WorkersPerformance.Rows.Clear();

                string[] grid_row = new string[5];
                foreach (Models.Worker w in workers)
                {

                    grid_row[0] = w.Name + " " + w.Paternal_name + " " + w.Maternal_name;
                    Models.Workstation workstation=(Models.Workstation)( workstation_controller.getWorkstation(w.ratios[0].workstation_id).data);
                    grid_row[1] =workstation.Name;
                    grid_row[2] = w.ratios[0].value.ToString();
                    grid_row[3] = (1 - w.ratios[0].value).ToString();
                    grid_row[4] = w.ratios[1].value.ToString();
                    this.datagrid_WorkersPerformance.Rows.Add(grid_row);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime begin = metroDateTime_Begin.Value;
            DateTime end = metroDateTime_End.Value;
            
            List<Models.Worker> workers = (List<Models.Worker>)(work_controller.getWorkerPerformanceLines(begin, end).data);
            Load_datagrid_WorkersPerformance(workers);
        }
    }
}
