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
                    grid_row[2] = w.ratios[0].value.ToString("F4");
                    grid_row[3] = (1 - w.ratios[0].value).ToString("F4");
                    grid_row[4] = w.ratios[1].value.ToString("F4");
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

        private void btn_export_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Rendimiento de trabajadores";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = -1; i < datagrid_WorkersPerformance.Rows.Count; i++)
                {
                    for (int j = 0; j < datagrid_WorkersPerformance.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = datagrid_WorkersPerformance.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = datagrid_WorkersPerformance.Rows[i].Cells[j].Value.ToString();
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

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Rendimiento de trabajadores";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = -1; i < datagrid_WorkersPerformance.Rows.Count; i++)
                {
                    for (int j = 0; j < datagrid_WorkersPerformance.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = datagrid_WorkersPerformance.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = datagrid_WorkersPerformance.Rows[i].Cells[j].Value.ToString();
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
    }
}
