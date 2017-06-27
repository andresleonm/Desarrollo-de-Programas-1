using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace WindowsFormsApp1.Views
{
    public partial class UC_Ratio : MetroFramework.Controls.MetroUserControl
    {
        List<Models.Ratio> ratio_list;
        List<Models.Ratio> ratio_list_full;
        List<Models.Product> product_list;
        List<Models.Workstation> workstation_list;
        List<Models.Worker> worker_list;
        Controller.RatioController ratioController;
        Controller.ProductsController productController;
        Controller.WorkstationsController workstationController;
        Controller.WorkerController workerController;
        Controller.Result result;
        ProgressBarForm progressform;
        bool first;
        public UC_Ratio()
        {
            InitializeComponent();
        }

        private void UC_Ratio_Load(object sender, EventArgs e)
        {
            string user = "";
            string password = "";
            ratioController = new Controller.RatioController(user, password);
            productController = new Controller.ProductsController(user, password);
            workstationController = new Controller.WorkstationsController(user, password);
            workerController = new Controller.WorkerController(user, password);
            first = true;
            progressform = new ProgressBarForm();

        }

        private void UC_Ratio_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                Load_Data();
                Load_DataGridView();
            }
        }

        private void UC_Ratio_ParentChanged(object sender, EventArgs e)
        {

        }

        private void combobox_product_s_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<int, string> combo_data = new Dictionary<int, string>();
            combobox_workstation_s.DataSource = new BindingSource(combo_data, null);
            Models.Workstation workstation = new Models.Workstation();
            workstation.Product_id = ((KeyValuePair<int, string>)combobox_product_s.SelectedItem).Key;
            result = workstationController.getWorkstations(workstation);
            if (result.success)
            {
                workstation_list = (List<Models.Workstation>)result.data;
                combo_data = new Dictionary<int, string>();
                combo_data.Add(0, "Seleccionar");
                foreach (var item in workstation_list)
                {
                    combo_data.Add(item.Id, item.Name);
                }
                combobox_workstation_s.DataSource = new BindingSource(combo_data, null);
                combobox_workstation_s.DisplayMember = "Value";
                combobox_workstation_s.ValueMember = "Key";
            }
            progressform.IncrementProgress(10);
            
        }

        private void Load_DataGridView()
        {
            progressform.SetupValues(40, 40 + worker_list.Count(), 40);
            metroGrid1.Rows.Clear();
            foreach (Models.Ratio ratio in ratio_list)
            {
                Models.Worker worker = null;
                foreach (var item in worker_list)
                {
                    if (item.Id == ratio.worker_id)
                    {
                        worker = item;
                        break;
                    }
                }
                Models.Product product = null;
                foreach (var item in product_list)
                {
                    if (item.Id == ratio.product_id)
                    {
                        product = item;
                        break;
                    }
                }
                Models.Workstation workstation = null;
                foreach (var item in workstation_list)
                {
                    if (item.Id == ratio.workstation_id)
                    {
                        workstation = item;
                        break;
                    }
                }
                string type = "";
                switch (ratio.ratio_type)
                {
                    case 1:
                        type = "Cantidad rota";
                        break;
                    case 2:
                        type = "Cantidad producida por hora";
                        break;
                    default:
                        type = "";
                        break;
                }
                if (worker != null && product != null && workstation != null)
                {
                    string[] row = new string[5];
                    row[0] = worker.Name + " " + worker.Paternal_name + " " + worker.Maternal_name;
                    row[1] = product.Name;
                    row[2] = workstation.Name;
                    row[3] = type;
                    if (ratio.ratio_type == 1)
                    {
                        row[4] = ratio.broken_quantity.ToString();
                    }
                    else
                    {
                        row[4] = ratio.value.ToString();
                    }
                        
                    metroGrid1.Rows.Add(row);
                }
                progressform.IncrementProgress(1);
            }
            progressform.Hide();
        }

        private void Load_Data()
        {
            progressform.SetupValues(0, 40, 0);
            progressform.Show();
            result = workerController.getWokers();
            if (result.success)
            {
                worker_list = (List<Models.Worker>)result.data;
            }
            else
            {
                MessageBox.Show(result.message);
            }
            progressform.IncrementProgress(10);
            result = productController.getProducts();
            if (result.success)
            {
                product_list = (List<Models.Product>)result.data;
            }
            else
            {
                MessageBox.Show(result.message);
            }
            progressform.IncrementProgress(10);
            result = workstationController.getWorkstations();
            if (result.success)
            {
                workstation_list = (List<Models.Workstation>)result.data;
            }
            else
            {
                MessageBox.Show(result.message);
            }
            progressform.IncrementProgress(10);
            result = ratioController.getRatios("", "", "", 0, 0, 0);
            if (result.success)
            {
                ratio_list = (List<Models.Ratio>)result.data;
            }
            else
            {
                MessageBox.Show(result.message);
            }
            progressform.IncrementProgress(10);
            Load_Combobox();
            if (first)
            {
                ratio_list_full = ratio_list;
            }
        }

        private void Load_Combobox()
        {
            Dictionary<int, string> combo_data;
            combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "Seleccionar");
            foreach (var item in product_list)
            {
                combo_data.Add(item.Id, item.Name);
            }
            combobox_product_s.DataSource = new BindingSource(combo_data, null);
            combobox_product_s.DisplayMember = "Value";
            combobox_product_s.ValueMember = "Key";

            combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "Seleccionar");
            combo_data.Add(1, "Cantidad rota");
            combo_data.Add(2, "Cantidad producida por hora");
            combobox_ratio_type_s.DataSource = new BindingSource(combo_data, null);
            combobox_ratio_type_s.DisplayMember = "Value";
            combobox_ratio_type_s.ValueMember = "Key";

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string worker_name = textbox_wname_s.Text;
            string paternal_name = textbox_wpaternal_s.Text;
            string maternal_name = textbox_wmaternal_s.Text;
            int product_id = ((KeyValuePair<int, string>)combobox_product_s.SelectedItem).Key;
            int workstation_id = ((KeyValuePair<int, string>)combobox_workstation_s.SelectedItem).Key;
            int ratio_type_id = ((KeyValuePair<int, string>)combobox_ratio_type_s.SelectedItem).Key;

            result = ratioController.getRatios(worker_name, paternal_name, maternal_name, workstation_id, product_id, ratio_type_id);
            if (result.success)
            {
                ratio_list = (List<Models.Ratio>)result.data;
            }
            else
            {
                MessageBox.Show(result.message);
            }
            Load_DataGridView();
        }

        private void btn_clean_s_Click(object sender, EventArgs e)
        {
            textbox_wname_s.Text = "";
            textbox_wmaternal_s.Text = "";
            textbox_wpaternal_s.Text = "";
            combobox_product_s.SelectedIndex = 0;
            combobox_ratio_type_s.SelectedIndex = 0;
            combobox_workstation_s.SelectedIndex = 0;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {

        }

        //private void btn_export_Click(object sender, EventArgs e)
        //{
        //    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        //    if (excel == null)
        //    {
        //        Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
        //        return;
        //    }
        //    excel.Visible = true;

        //    excel.Interactive = false;
        //    Workbook wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        //    Worksheet ws = (Worksheet)wb.Worksheets[1];
        //    ws.Name = "Materiales";
        //    if (ws == null)
        //    {
        //        Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
        //    }

        //    ws.Range["A1"].Value2 = "Lista de Ratios";
        //    ws.Range["A1"].Font.Size = 15;
        //    ws.Range["A1"].Font.Bold = true;
        //    ws.Range["A2"].Value2 = "Trabajador";
        //    ws.Range["B2"].Value2 = "Producto";
        //    ws.Range["C2"].Value2 = "Puesto de Trabajo";
        //    ws.Range["D2"].Value2 = "Tipo de ratio";
        //    ws.Range["E2"].Value2 = "Valor de ratio";

        //    Models.Ratio ratio;
        //    Models.Worker worker;
        //    Models.Product product;
        //    Models.Workstation workstation;
        //    string ratio_type;
        //    for (int i = 0; i < ratio_list.Count(); i++)
        //    {
        //        ratio = ratio_list[i];
        //        result = workerController.getWorker(ratio.worker_id);
        //        if (result.success)
        //        {
        //            worker = (Models.Worker)result.data;
        //            ((Range)ws.Cells[i + 3, 1]).Value2 = worker.Name + " " + worker.Paternal_name + " " + worker.Maternal_name;
        //        }
        //        result = productController.getProduct(ratio.product_id);
        //        if (result.success)
        //        {
        //            product = (Models.Product)result.data;
        //            ((Range)ws.Cells[i + 3, 2]).Value2 = product.Name;
        //        }

        //        result = workstationController.getWorkstation(ratio.workstation_id);
        //        if (result.success)
        //        {
        //            workstation = (Models.Workstation)result.data;
        //            ((Range)ws.Cells[i + 3, 3]).Value2 = workstation.Name;
        //        }
        //        switch (ratio.ratio_type)
        //        {
        //            case 1:
        //                ratio_type = "%";
        //                break;
        //            case 2:
        //                ratio_type = "mins";
        //                break;
        //            default:
        //                ratio_type = "";
        //                break;
        //        }
        //        ((Range)ws.Cells[i + 3, 4]).Value2 = ratio_type;
        //        ((Range)ws.Cells[i + 3, 5]).Value2 = ratio.value.ToString("F4");
        //    }
        //    ws.Columns.AutoFit();
        //    excel.Interactive = true;
        //}

        private void btn_export2(object sender, EventArgs e)
        {
            //Path
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = string.Format("{0}Resources\\Excel\\new_ratios.xlsx", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(fileName);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            Models.Worker worker;
            Models.Ratio ratio;
            try
            {

                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Ratios";
                int k = 0;
                progressform.SetupValues(0, ratio_list.Count(), 0);
                progressform.Show();
                for (int i = 0; i < worker_list.Count(); i++)
                {
                    worker = worker_list[i];
                    worksheet.Cells[i + 7, 1] = worker.Name + " " + worker.Paternal_name + " " + worker.Maternal_name;
                    worksheet.Cells[i + 7, 1].BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin,
                        XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
                    for (int j = 0; j < 12; j++)
                    {
                        if (ratio_list_full[k].ratio_type==1)
                            worksheet.Cells[i + 7, j + 2] = ratio_list_full[k].broken_quantity.ToString("F4");
                        else
                            worksheet.Cells[i + 7, j + 2] = ratio_list_full[k].value.ToString("F4");
                        worksheet.Cells[i + 7, j + 2].BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin,
                        XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
                        k++;
                        progressform.IncrementProgress(1);
                    }
                
                }
                progressform.Hide();
                worksheet.Columns.AutoFit();
                //Loop through each row and read value from each column. 

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

        private void btn_import2(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Excel |*.xlsx;*.xls";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openDialog.FileName, "Ventana", MessageBoxButtons.OK);
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                if (excel == null)
                {
                    Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                    return;
                }
                Workbook wb = excel.Workbooks.Open(openDialog.FileName);
                Worksheet ws = (Worksheet)wb.Worksheets[1];
                Range range = ws.UsedRange;
                int row_count = range.Rows.Count;
                int column_count = range.Columns.Count;
                Range datarange;
                string worker = "", workstation = "", ratio_type = "";
                double ratio_value = -1, number;
                bool error; //error individual
                int ratio_type_id = 0,workstation_id=0;
                progressform.Show();
                progressform.SetupValues(0, worker_list.Count(), 0);
                //En Interop Excel el indice comienza en 1
                for (int i = 0; i <= worker_list.Count(); i++) //Fila 3 comienza las filas de materiales
                {
                    progressform.IncrementProgress(1);
                    //progress.Value = 
                    error = false;
                    datarange = (Range)ws.Cells[i+7, 1];//Trabajador
                    if (string.IsNullOrWhiteSpace((string)datarange.Text))
                    {
                        error = true;
                    }
                    else
                    {
                        worker = (string)datarange.Value2;
                    }
                    for (int j = 0; j < 12; j++)
                    {
                        error = false;
                        datarange = (Range)ws.Cells[i+7, j+2];//Valor
                        if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                        {
                            error = true;
                        }
                        else
                        {
                            ratio_value = (double)datarange.Value2;
                            switch (j)
                            {
                                case 0: case 1:
                                    workstation_id = 1;
                                    break;
                                case 2: case 3:
                                    workstation_id = 2;
                                    break;
                                case 4: case 5:
                                    workstation_id = 3;
                                    break;
                                case 6: case 7:
                                    workstation_id = 4;
                                    break;
                                case 8: case 9:
                                    workstation_id = 5;
                                    break;
                                case 10: case 11:
                                    workstation_id = 6;
                                    break;
                            }
                            ratio_type_id = (j % 2)+1;
                        }
                        if (!error)
                        {
                            result = ratioController.updateRatio2(worker, workstation_id, ratio_type_id, ratio_value);
                        }
                    }
                    

                }
                excel.Quit();
                wb = null;
                excel = null;
            }
            progressform.Hide();
            MessageBox.Show("Se terminó de importar los ratios","Importación completada");
            openDialog.Dispose();
            Load_Data();
            Load_DataGridView();
            ratio_list_full = ratio_list;
            
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Excel |*.xlsx;*.xls";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openDialog.FileName, "Ventana", MessageBoxButtons.OK);
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                if (excel == null)
                {
                    Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                    return;
                }
                Workbook wb = excel.Workbooks.Open(openDialog.FileName);
                Worksheet ws = (Worksheet)wb.Worksheets[1];
                Range range = ws.UsedRange;
                int row_count = range.Rows.Count;
                int column_count = range.Columns.Count;
                Range datarange;
                string worker = "", workstation = "",product = "",ratio_type="";
                double ratio_value=-1, number;
                bool error; //error individual
                int success_line = 0, error_line = 0;
                
                //En Interop Excel el indice comienza en 1
                for (int i = 3; i <= row_count; i++) //Fila 3 comienza las filas de materiales
                {
                    error = false;
                    datarange = (Range)ws.Cells[i, 1];//Trabajador
                    if (string.IsNullOrWhiteSpace((string)datarange.Text))
                    {
                        error = true;
                    }
                    else
                    {
                        worker = (string)datarange.Value2;
                    }
                    datarange = (Range)ws.Cells[i, 2];//Producto
                    if (string.IsNullOrWhiteSpace((string)datarange.Text))
                    {
                        error = true;
                    }
                    else
                    {
                        product = (string)datarange.Value2;
                    }
                    datarange = (Range)ws.Cells[i, 3];//Puesto Trabajo
                    if (string.IsNullOrWhiteSpace((string)datarange.Text))
                    {
                        error = true;
                    }
                    else
                    {
                        workstation = (string)datarange.Value2;
                    }
                    datarange = (Range)ws.Cells[i, 4];//Tipo
                    if (string.IsNullOrWhiteSpace((string)datarange.Text))
                    {
                        error = true;
                    }
                    else
                    {
                        ratio_type = (string)datarange.Value2;
                    }
                    datarange = (Range)ws.Cells[i, 5];//Stock minimo
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        
                    }
                    else
                    {
                        ratio_value = (double)datarange.Value2;
                    }

                    if (error)//Si hay error entonces, se agrega a la lista de material error
                    {
                        error_line++;
                    }
                    else
                    {
                        result = ratioController.updateRatio(worker, product, workstation, ratio_type, ratio_value);
                        if (result.success)
                        {
                            success_line++;
                        }
                        else
                        {
                            error_line++;
                        }
                    }
                }
                MessageBox.Show("Lineas correctas: "+success_line+"\n"+"Lineas incorrectas: "+error_line, "Importar Ratios", MessageBoxButtons.OK);
            }
            openDialog.Dispose();
        }

        private void consulta_Click(object sender, EventArgs e)
        {

        }
    }
}
