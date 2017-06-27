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
    public partial class UC_SimulationReport : UserControl
    {
        public UC_SimulationReport()
        {
            InitializeComponent();
        }

        private void metroTabControl1_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                Controller.SimulationReportHeaderController src = new Controller.SimulationReportHeaderController("dp1admin", "dp1admin");

                List<Models.SimulationReportHeader> headers = new List<Models.SimulationReportHeader>();
                headers = (List<Models.SimulationReportHeader>)src.getSimulationReportHeaders().data;

                this.metroGrid2.DataSource = headers;
            }
        }

        private void metroGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.SimulationReportHeader obj = ((Models.SimulationReportHeader)this.metroGrid2.Rows[e.RowIndex].DataBoundItem);
            this.metroTabControl1.SelectTab(this.metroTabControl1.SelectedIndex + 1);
            this.metroGrid1.Rows.Clear();
            Controller.SimulationReportController src = new Controller.SimulationReportController("dp1admin", "dp1admin");

            List<Models.SimulationReport> lines = (List<Models.SimulationReport>)src.getSimulationReports().data;
            lines = lines.FindAll(l => l.simulation_report_id == obj.simulation_report_header_id);
            string[] row = new string[6];
            foreach (Models.SimulationReport line in lines)
            {
                row[0] = line.worker;
                row[1] = line.workstation;
                row[2] = line.product;
                row[3] = line.accuracy;
                row[4] = line.products_per_hour;
                row[5] = line.product_line;
                this.metroGrid1.Rows.Add(row);                
            }
            this.txt_total_accuracy.Text = obj.accuracy.ToString();
            this.txt_total_products_per_hour.Text = obj.products.ToString();
        }
    }
}
