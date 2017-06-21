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

        private void btn_export_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Simulación";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = -1; i < metroGrid1.Rows.Count; i++)
                {
                    for (int j = 0; j < metroGrid1.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = metroGrid1.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = metroGrid1.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Exportado correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void UC_SimulationExecution_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                Cursor = Cursors.Arrow;
                this.metroGrid1.Rows.Clear();
                List<Algorithm.ProductLineAssignment> solution =
                    ((UC_SimulationConfig)(Parent.Controls.Find("UC_SimulationConfig2", true))[0]).solution;
                if (solution != null && solution.Count >= 1)
                {
                    string[] row = new string[6];
                    int count = 1;
                    foreach (Algorithm.ProductLineAssignment pla in solution)
                    {
                        foreach (Algorithm.Assignment assig in pla.assignments)
                        {
                            row[0] = assig.assigned_worker.name + " " + assig.assigned_worker.lastname;
                            row[1] = assig.assigned_workstation.name;
                            row[2] = assig.assigned_workstation.product.name;
                            row[3] = (assig.assigned_worker.ratios.Where(r => r.workstation.name == assig.assigned_workstation.name && r.type == "Efficiency").ElementAt(0).value*100).ToString("0.00");
                            row[4] = Math.Truncate((assig.assigned_worker.ratios.Where(r => r.workstation.name == assig.assigned_workstation.name && r.type == "Time").ElementAt(0).value)).ToString();
                            row[5] = count.ToString();
                            this.metroGrid1.Rows.Add(row);
                        }
                        count++;
                    }
                }
            }
        }
    }
}
