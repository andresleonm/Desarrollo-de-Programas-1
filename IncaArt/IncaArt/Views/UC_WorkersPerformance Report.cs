using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using System.IO;
using Microsoft.Office.Interop.Excel;

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

        private void datagrid_Fill()
        {
            Result result = work_controller.getWorkerPerformanceLines();
            if (result.success)
            {
                List<Models.Worker> workers = (List<Models.Worker>)(result.data);
                Load_datagrid_WorkersPerformance(workers);
            }
        }

        void Load_datagrid_WorkersPerformance(List<Models.Worker> workers)
        {
            datagrid_WorkersPerformance.Rows.Clear();
            if ((workers!=null) && (workers.Count > 0))
            {
                string[] grid_row = new string[7];
                foreach (Models.Worker w in workers)
                {

                    grid_row[0] = w.Name;
                    grid_row[1] = w.Paternal_name;
                    grid_row[2] = w.Maternal_name;
                    Models.Workstation workstation=(Models.Workstation)( workstation_controller.getWorkstation(w.ratios[0].workstation_id).data);
                    grid_row[3] =workstation.Name;
                    grid_row[4] = w.ratios[0].value.ToString("F4");
                    grid_row[5] = (1 - w.ratios[0].value).ToString("F4");
                    grid_row[6] = w.ratios[1].value.ToString("F4");
                    this.datagrid_WorkersPerformance.Rows.Add(grid_row);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime begin = metroDateTime_Begin.Value;
            DateTime end = metroDateTime_End.Value;
            Result result=work_controller.getWorkerPerformanceLines(begin, end);
            if (result.success)
            {
                List<Models.Worker> workers = (List<Models.Worker>)(result.data);
                Load_datagrid_WorkersPerformance(workers);
            }
           
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
            //Path
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = string.Format("{0}Resources\\Excel\\workerPerformance.xlsx", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(fileName);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                int cellRowIndex = 7;
                int cellColumnIndex = 2;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < datagrid_WorkersPerformance.Rows.Count; i++)
                {
                    for (int j = 0; j < datagrid_WorkersPerformance.Columns.Count; j++)
                    {                    
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = datagrid_WorkersPerformance.Rows[i].Cells[j].Value.ToString();
                        worksheet.Cells[cellRowIndex, cellColumnIndex].BorderAround(XlLineStyle.xlContinuous,XlBorderWeight.xlThin, 
                        XlColorIndex.xlColorIndexAutomatic,XlColorIndex.xlColorIndexAutomatic);

                        cellColumnIndex++;
                    }
                    cellColumnIndex = 2;
                    cellRowIndex++;
                }

                worksheet.Cells[3, 3] = "Desde el " + metroDateTime_Begin.Value.Date.ToString("dd/MM/yyyy") + " hasta el " + metroDateTime_End.Value.Date.ToString("dd/MM/yyyy");

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

        private void datagrid_WorkersPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WorkersPerformance_Report_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
