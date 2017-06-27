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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class UC_LogReport : UserControl
    {
        LogController log_controller;
        UsersController user_constroller;
        List<Log> logs_list;

        public UC_LogReport()
        {
            InitializeComponent();
            log_controller = new LogController("", "");
        }

        private void Load_DataGrid()
        {
            datagrid1.Rows.Clear();

            for (int i = 0; i < logs_list.Count; i++)
            {
                Log l = logs_list[i];
                string[] row = new string[6];

                row[0] = l.Username;
                row[1] = l.Action;
                row[2] = l.Date.ToString("dd/MM/yyyy");
                row[3] = l.Target;
                row[4] = l.TargetId;
                row[5] = l.ParseData();

                datagrid1.Rows.Add(row);
            }
        }


        private bool ValidateData()
        {
            int i;
            return metroTextBoxNumber.Text == "" || Int32.TryParse(metroTextBoxNumber.Text, out i);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                string startDate = metroDateTime_Begin.Text;
                string endDate = metroDateTime_End.Text;
                string type = metroComboBoxType.Text;
                string action = metroComboBoxAction.Text;
                string username = metroComboBoxUser.Text;
                string number = metroTextBoxNumber.Text;
                
                //Cursor = Cursors.WaitCursor;
                Result logResult = log_controller.getLogs(startDate, endDate, type, action, username, number);
                
                if (logResult.success)
                {
                    logs_list = (List<Log>)logResult.data;
                    Load_DataGrid();
                    MessageBox.Show(logs_list.Count + " filas retornadas");
                    //Cursor = Cursors.Arrow;
                }
                else
                {
                    //Cursor = Cursors.Arrow;
                    MessageBox.Show(logResult.message);
                }
            }
            else
            {
                MessageBox.Show("El numero de documento solo puede tener digitos");
            }


        }

        private void ClearInputs()
        {
            metroDateTime_Begin.Text = "";
            metroDateTime_End.Text = "";
            metroComboBoxType.SelectedIndex = -1;
            metroComboBoxAction.SelectedIndex = -1;
            metroComboBoxUser.SelectedIndex = -1;
            metroTextBoxNumber.Text = "";
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
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
                worksheet.Name = "Log";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = -1; i < datagrid1.Rows.Count; i++)
                {
                    for (int j = 0; j < datagrid1.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = datagrid1.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = datagrid1.Rows[i].Cells[j].Value.ToString();
                        }


                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.get_Range("A1", "F"+(datagrid1.Rows.Count+1)).Columns.ClearFormats();

                //Microsoft.Office.Interop.Excel.Range.

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;

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

        private void UC_LogReport_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                user_constroller = new UsersController("", "");

                Result usersResult = user_constroller.getUsers();

                if (usersResult.success)
                {
                    metroComboBoxUser.Items.Clear();
                    List<User> users = (List<User>)usersResult.data;

                    foreach (User u in users)
                    {
                        metroComboBoxUser.Items.Add(u.Nickname);
                    }
                }
                else
                {
                    MessageBox.Show(usersResult.message);
                }
            }
        }

        private void btn_expand_Click(object sender, EventArgs e)
        {


            if (datagrid1.CurrentRow != null)
            {
                MessageBox.Show((string)datagrid1.CurrentRow.Cells[5].Value);
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }

        }
    }
}
