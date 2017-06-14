using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views.Warehouse_Module
{
    public partial class Kardex : Form
    {
        public Kardex()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KardexController kc = new KardexController("dp1admin", "dp1admin");
            var lines = (List<KardexLine>)kc.getMovements(this.dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                                this.dateTimePicker2.Value.ToString("yyyy-MM-dd")).data;

         
            
                // Creating a Excel object. 
                Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                try
                {

                    worksheet = workbook.ActiveSheet;

                    worksheet.Name = "Kardex del "+ this.dateTimePicker1.Value.ToString("yyyy-MM-dd")+this.dateTimePicker2.Value.ToString("yyyy-MM-dd");

                    int cellRowIndex = 1;
                    int cellColumnIndex = 1;

                List<string> headers = new List<string>();

                headers.Add("Codigo");
                headers.Add("Producto");
                headers.Add("Almacen");
                headers.Add("Movimiento");
                headers.Add("Signo");
                headers.Add("Cantidad");
                headers.Add("Fecha");
                headers.Add("Saldo Inicial");         


                //Loop through each row and read value from each column. 
                for (int i = -1; i < lines.Count; i++)
                    {
                        for (int j = 0; j < headers.Count; j++)
                        {
                            // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                            if (cellRowIndex == 1)
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = headers[j];
                            }
                            else
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = lines[i].Cells(j);
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
