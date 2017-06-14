using System;
using System.Collections.Generic;
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

        private int make_move(int sal_ini,string sign,int quantity)
        {
            if (sign == "+")
                return sal_ini + quantity;
            return  sal_ini - quantity;
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

                    int cellRowIndex = 3;
                    int cellColumnIndex = 3;
                    int productAnt=0;

                    List<string> headers = new List<string>();

                    
                   
                    headers.Add("Almacen");
                    headers.Add("Movimiento");                
                    headers.Add("Cantidad");
                    headers.Add("Fecha");


                int saldo_fin=0;
                //Loop through each row and read value from each column. 
                for (int i = 0; i < lines.Count; i++)
                    {
                        if (Int32.Parse(lines[i].codeProduct) != productAnt)
                        {
                            if (productAnt != 0){
                                worksheet.Cells[cellRowIndex, cellColumnIndex+4] = "Saldo Final";
                                worksheet.Cells[cellRowIndex, cellColumnIndex + 5] = saldo_fin;
                                cellRowIndex += 2;
                            }
                            saldo_fin = lines[i].sal_ini;
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = "Producto";
                            worksheet.Cells[cellRowIndex, cellColumnIndex+1] = lines[i].product;
                            worksheet.Cells[cellRowIndex, cellColumnIndex+3] = "Saldo Inicial";
                            worksheet.Cells[cellRowIndex, cellColumnIndex+4] = lines[i].sal_ini;
                            cellRowIndex += 1;
                        }

                        for (int j = 0; j < headers.Count; j++)
                        {   worksheet.Cells[cellRowIndex, cellColumnIndex] = lines[i].Cells(j);                            
                            cellColumnIndex++;
                        }
                        productAnt = Int32.Parse(lines[i].codeProduct);
                        saldo_fin = make_move(saldo_fin, lines[i].sign, lines[i].quantity);
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
                        workbook.Close();
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
