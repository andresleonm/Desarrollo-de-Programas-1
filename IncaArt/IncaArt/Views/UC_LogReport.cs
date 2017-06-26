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

        public UC_LogReport()
        {
            InitializeComponent();
            log_controller = new LogController("", "");
        }

        private void Load_DataGrid(List<Log> logs)
        {
            datagrid1.Rows.Clear();

            foreach (Log l in logs)
            {
                string[] row = new string[5];

                row[0] = l.Username;
                row[1] = l.Action;
                row[2] = l.Date.ToString("dd/MM/yyyy");
                row[3] = l.Target;
                row[4] = l.TargetId;

                datagrid1.Rows.Add(row);
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;

            Result logResult = log_controller.getLogs();

            if (logResult.success)
            {
                List<Log> logs = (List<Log>)logResult.data;
                Load_DataGrid(logs);
                //this.Cursor = Cursors.Arrow;
            }
            else
            {
                //this.Cursor = Cursors.Arrow;
                MessageBox.Show(logResult.message);
            }


        }
    }
}
