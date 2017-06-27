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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class UC_Product : ICheckPermissions
    {
        bool name_flag;
        bool unit_flag;
        bool max_flag;
        bool min_flag;
        bool price_flag;
        bool currency_flag;
        bool type_flag;
        int cur_row;
        int operation_value;// 0 para Create, 1 para Update
        List<Models.Product> product_list;
        List<Models.UnitOfMeasure> unit_list;
        List<Models.Currency> currency_list;
        Controller.ProductsController productController;
        Controller.UnitController unitController;
        Controller.CurrencyController currencyController;
        Controller.Result result;
        Models.User sessionUser;
        public UC_Product()
        {
            InitializeComponent();
        }

        private void UC_Product_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                operation_value = 0;
                Set_Flag_All(false);
                Load_Data();
                Load_DataGridView();
                metroTabControl1.SelectedIndex = 0;
            }
        }

        private void UC_Product_Load(object sender, EventArgs e)
        {
            string user = "";
            string password = "";
            productController = new Controller.ProductsController(user, password);
            unitController = new Controller.UnitController(user, password);
            currencyController = new Controller.CurrencyController(user, password);
        }

        private void Load_Data()
        {
            result = currencyController.getCurrencies();
            currency_list = (List<Models.Currency>)result.data;
            result = unitController.getUnits();
            unit_list = (List<Models.UnitOfMeasure>)result.data;
            product_list = new List<Models.Product>();
            result = productController.getProducts();
            if (result.success)
            {
                product_list = (List<Models.Product>)result.data;
            }
            else
            {
                MessageBox.Show(result.message, "Error al listar producto", MessageBoxButtons.OK);
            }
            Load_Combobox();
        }

        private void Load_Combobox()
        {
            Dictionary<int, string> combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "Seleccionar");
            combo_data.Add(1, "Ceramico");
            combo_data.Add(2, "Retablo");
            combo_data.Add(3, "Piedra");

            combobox_product_type.DataSource = new BindingSource(combo_data, null);
            combobox_product_type.DisplayMember = "Value";
            combobox_product_type.ValueMember = "Key";

            combobox_product_type_s.DataSource = new BindingSource(combo_data, null);
            combobox_product_type_s.DisplayMember = "Value";
            combobox_product_type_s.ValueMember = "Key";


            //Cargar los combobox
            combo_data = new Dictionary<int, string>();
            //Unidad
            combo_data.Add(0, "Seleccionar");
            foreach (var item in unit_list)
            {
                combo_data.Add(item.Id, item.Symbol);

            }
            combobox_unit.DataSource = new BindingSource(combo_data, null);
            combobox_unit.DisplayMember = "Value";
            combobox_unit.ValueMember = "Key";

            combobox_unit_s.DataSource = new BindingSource(combo_data, null);
            combobox_unit_s.DisplayMember = "Value";
            combobox_unit_s.ValueMember = "Key";

            //Moneda
            combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "-");
            foreach (var item in currency_list)
            {
                combo_data.Add(item.Id, item.Symbol);

            }
            combobox_currency.DataSource = new BindingSource(combo_data, null);
            combobox_currency.DisplayMember = "Value";
            combobox_currency.ValueMember = "Key";
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < product_list.Count(); i++)
            {
                Models.UnitOfMeasure unit = new Models.UnitOfMeasure();
                result = unitController.getUnit(product_list[i].Unit_id);
                if (result.success)
                {
                    unit = (Models.UnitOfMeasure)result.data;
                    String[] row = new String[8];
                    row[0] = product_list[i].Id.ToString();
                    row[1] = i.ToString();
                    row[2] = product_list[i].Name;
                    row[3] = unit.Name;
                    row[4] = product_list[i].Unit_price.ToString("F2");
                    row[5] = product_list[i].Stock_min.ToString();
                    row[6] = product_list[i].Stock_max.ToString();
                    row[7] = product_list[i].Product_type;
                    this.metroGrid1.Rows.Add(row);
                }else
                {
                    MessageBox.Show(result.message, "Error al buscar unit", MessageBoxButtons.OK);
                }
            }
        }

        private void Clean()
        {
            ClearTextBoxes(this);
            combobox_unit.SelectedIndex = 0;
            combobox_unit_s.SelectedIndex = 0;
            combobox_currency.SelectedIndex = 0;
            combobox_product_type.SelectedIndex = 0;
            combobox_product_type_s.SelectedIndex = 0;
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }

            }
        }

        private Models.Product CreateProduct(int operation)
        {
            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
            string name = textbox_name.Text;
            int unit_id = ((KeyValuePair<int, string>)combobox_unit.SelectedItem).Key;
            int stock_min = int.Parse(textbox_stock_min.Text);
            int stock_max = int.Parse(textbox_stock_max.Text);
            int currency_id = ((KeyValuePair<int, string>)combobox_currency.SelectedItem).Key;
            double price = double.Parse(textbox_price.Text);
            string product_type = ((KeyValuePair<int, string>)combobox_product_type.SelectedItem).Value;
            switch (product_type)
            {
                case "Ceramico":
                    product_type = "CERAMICO";
                    break;
                case "Retablo":
                    product_type = "RETABLO";
                    break;
                case "Piedra":
                    product_type = "PIEDRA";
                    break;
            }

            Models.Product product = new Models.Product();
            product.Name = name;
            product.Unit_id = unit_id;
            product.Stock_min = stock_min;
            product.Stock_max = stock_max;
            product.Currency_id = currency_id;
            product.Unit_price = price;
            product.Product_type = product_type;
            int id = 0;
            if (operation == 1)
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            product.Id = id;
            return product;
        }

        private void button_New_Click(object sender, EventArgs e)
        {

            Models.Product product = CreateProduct(0);
            if (product != null)
            {
                result = productController.insertProduct(product);
                if (result.success)
                {
                    MessageBox.Show("Producto registrado correctamente", "Registrar producto", MessageBoxButtons.OK);
                    Load_Data();
                }
                else
                {
                    MessageBox.Show(result.message, "Error al registrar producto", MessageBoxButtons.OK);
                }
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Clean();
            metroTabControl1.SelectedIndex = 0;
            operation_value = 0;
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                cur_row = e.RowIndex;
            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cur_row = e.RowIndex;
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                int id = Int32.Parse(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
                result = productController.getProduct(id);
                Models.Product product;
                if (result.success)
                {
                    product = (Models.Product)result.data;
                    textbox_name.Text = product.Name;
                    for (int i = 0; i < unit_list.Count(); i++)
                    {
                        if (unit_list[i].Id == product.Unit_id)
                        {
                            combobox_unit.SelectedIndex = i + 1;
                        }
                    }
                    for (int i = 0; i < currency_list.Count(); i++)
                    {
                        if (currency_list[i].Id == product.Currency_id)
                        {
                            combobox_currency.SelectedIndex = i + 1;
                        }
                    }
                    switch (product.Product_type)
                    {
                        case "CERAMICO":
                            combobox_product_type.SelectedIndex = 1;
                            break;
                        case "RETABLO":
                            combobox_product_type.SelectedIndex = 2;
                            break;
                        case "PIEDRA":
                            combobox_product_type.SelectedIndex = 3;
                            break;
                    }
                    Set_Flag_All(true);
                    textbox_stock_max.Text = product.Stock_max.ToString();
                    textbox_stock_min.Text = product.Stock_min.ToString();
                    textbox_price.Text = product.Unit_price.ToString();
                    metroTabControl1.SelectedIndex = 1;
                    operation_value = 1;
                }

            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Models.Product product = CreateProduct(1);
            if (product != null)
            {
                result = productController.updateProduct(product);
                if (result.success)
                {
                    MessageBox.Show("Producto editado correctamente", "Editar producto", MessageBoxButtons.OK);
                    Load_Data();
                }else
                {
                    MessageBox.Show(result.message, "Error al modificar producto", MessageBoxButtons.OK);
                }
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = productController.deleteProduct(product_list[index]);
            if (result.success)
            {
                MessageBox.Show("Producto eliminado correctamente", "Eliminar producto", MessageBoxButtons.OK);
                Load_Data();
            }else
            {
                MessageBox.Show(result.message, "Error al eliminar material", MessageBoxButtons.OK);
            }
            Load_DataGridView();
        }

        private void btn_clean_s_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Models.Product product = new Models.Product();
            product.Name = textbox_name_s.Text;
            product.Unit_id = ((KeyValuePair<int, string>)combobox_unit_s.SelectedItem).Key;
            product.Product_type = ((KeyValuePair<int, string>)combobox_product_type_s.SelectedItem).Value;
            result = productController.getProducts(product);
            if (result.success)
            {
                product_list = (List<Models.Product>)result.data;
                Load_DataGridView();
            }else
            {
                MessageBox.Show(result.message, "Error al buscar producto con filtro", MessageBoxButtons.OK);
            }
        }

        private void textbox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != 8)//Manejo de Backspace
                {
                    e.Handled = true;
                }
            }
            if (textbox.Name == "textbox_price")
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                if ((e.KeyChar == '.') && (textbox.Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }

            }
        }

        private void textbox_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            string text = textbox.Text;

            if (String.IsNullOrWhiteSpace(text))
            {
                //e.Cancel = true;
                Set_Flag(textbox.Name, false);
                errorProvider.SetError(textbox, "Campo requerido");

            }
            else
            {
                //e.Cancel = false;
                Set_Flag(textbox.Name, true);
                errorProvider.SetError(textbox, null);
            }
        }

        private void textbox_number_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            string text = textbox.Text;

            if (String.IsNullOrWhiteSpace(text))
            {
                Set_Flag(textbox.Name, false);
                errorProvider.SetError(textbox, "Campo requerido");

            }
            else
            {
                errorProvider.SetError(textbox, null);
                int max, min;
                if (Int32.TryParse(textbox_stock_max.Text, out max) && Int32.TryParse(textbox_stock_min.Text, out min))
                {
                    if (max < min)
                    {
                        Set_Flag(textbox.Name, false);
                        errorProvider.SetError(textbox, "El Stock Máximo debe ser Mayor que el stock mínimo");
                    }
                    else
                    {
                        Set_Flag("textbox_stock_min", true);
                        Set_Flag("textbox_stock_max", true);
                        errorProvider.SetError(textbox, null);
                    }

                }

            }
        }

        private void combobox_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroComboBox combobox = (MetroFramework.Controls.MetroComboBox)sender;
            int id = ((KeyValuePair<int, string>)combobox.SelectedItem).Key;
            if (id == 0)
            {
                Set_Flag(combobox.Name, false);
                errorProvider.SetError(combobox, "Se debe seleccionar");

            }
            else
            {
                Set_Flag(combobox.Name, true);
                errorProvider.SetError(combobox, null);
            }
        }

        private bool Validate_Data()
        {
            if (name_flag && unit_flag && max_flag && min_flag && price_flag && currency_flag)
            {
                return true;
            }
            return false;
        }

        private void Set_Flag_All(bool value)
        {
            name_flag = value;
            min_flag = value;
            max_flag = value;
            unit_flag = value;
            price_flag = value;
            currency_flag = value;
            type_flag = value;
        }

        private void Set_Flag(string name, bool value)
        {
            switch (name)
            {
                case "textbox_name":
                    name_flag = value;
                    break;
                case "textbox_stock_min":
                    min_flag = value;
                    break;
                case "textbox_stock_max":
                    max_flag = value;
                    break;
                case "combobox_unit":
                    unit_flag = value;
                    break;
                case "textbox_price":
                    price_flag = value;
                    break;
                case "combobox_currency":
                    currency_flag = value;
                    break;
                case "combobox_product_type":
                    type_flag = value;
                    break;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Models.Product product = CreateProduct(operation_value);
            if (product != null)
            {
                if (product.Id == 0)
                {
                    result = productController.insertProduct(product);
                    if (result.success)
                    {
                        MessageBox.Show("Producto registrado correctamente", "Registrar producto", MessageBoxButtons.OK);
                        Load_Data();
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Error al registrar producto", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    result = productController.updateProduct(product);
                    if (result.success)
                    {
                        MessageBox.Show("Producto editado correctamente", "Editar producto", MessageBoxButtons.OK);
                        Load_Data();
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Error al modificar producto", MessageBoxButtons.OK);
                    }
                }
                operation_value = 0;
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }
        }

        private partial class ProductError //Clase temporal para manejo de Excel con filas con errores
        {
            public List<string> error_list;
            public List<string> string_list;
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
                string name = "", unit = "", type = "", currency = "";
                double max = -1, min = -1, price = -1, number;
                bool error; //error individual
                bool found;
                List<string> error_list, string_list; //para hacer control de cada error de fila
                Models.Product product;
                int unit_id = 0, currency_id = 0, success_lines = 0, error_lines = 0;
                List<ProductError> product_error_list = new List<ProductError>(); //Lista de materiales para el Excel con error
                //En Interop Excel el indice comienza en 1
                for (int i = 3; i <= row_count; i++) //Fila 3 comienza las filas de materiales
                {
                    error = false;
                    ProductError product_error = new ProductError();
                    error_list = new List<string>();
                    string_list = new List<string>();
                    //Nombre
                    datarange = (Range)ws.Cells[i, 1];
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("name");
                    }
                    else
                    {
                        name = (string)datarange.Value2;
                    }
                    //Unidad
                    datarange = (Range)ws.Cells[i, 2];
                    found = false;
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || !Int32.TryParse((string)datarange.Text, out unit_id))
                    {
                        error = true;
                        error_list.Add("unit");
                    }
                    else
                    {
                        unit_id = (Int32)datarange.Value2;
                        foreach (var item in unit_list)
                        {
                            if (item.Id==unit_id)
                            {
                                unit_id = item.Id;
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            error = true;
                            error_list.Add("unit_find");
                        }
                    }
                    //Precio
                    datarange = (Range)ws.Cells[i, 3];
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("price");
                    }
                    else
                    {
                        price = (double)datarange.Value2;
                    }
                    //Moneda
                    datarange = (Range)ws.Cells[i, 4];
                    found = false;
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || !Int32.TryParse((string)datarange.Text, out currency_id))
                    {
                        error = true;
                        error_list.Add("currency");
                    }
                    else
                    {
                        currency_id = (Int32)datarange.Value2;
                        foreach (var item in currency_list)
                        {
                            if (item.Id==currency_id)
                            {
                                currency_id = item.Id;
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            error = true;
                            error_list.Add("currency_find");
                        }
                    }
                    //Stock minimo
                    datarange = (Range)ws.Cells[i, 5];
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("min");
                    }
                    else
                    {
                        min = (double)datarange.Value2;
                    }
                    //Stock maximo
                    datarange = (Range)ws.Cells[i, 6];
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("max");
                    }
                    else
                    {
                        max = (double)datarange.Value2;
                    }
                    //Tipo Producto
                    datarange = (Range)ws.Cells[i, 7];
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("type");
                    }
                    else
                    {
                        type = ((string)datarange.Value2).ToUpper();
                        if (type.Equals("CERAMICO") || type.Equals("RETABLO") || type.Equals("PIEDRA"))
                        {
                            type = ((string)datarange.Value2).ToUpper();
                        }
                        else
                        {
                            error = true;
                            error_list.Add("type_find");
                        }
                    }

                    if (error)//Si hay error entonces, se agrega a la lista de material error
                    {
                        product_error.error_list = error_list;
                        product_error.string_list = string_list;
                        product_error_list.Add(product_error);
                        error_lines++;
                    }
                    else
                    {
                        product = new Models.Product();
                        product.Name = name;
                        product.Unit_id = unit_id;
                        product.Currency_id = currency_id;
                        product.Stock_max = Convert.ToInt32(max);
                        product.Stock_min = Convert.ToInt32(min);
                        product.Product_type = type;
                        product.Unit_price = price;
                        product.Average_cost = price*0.25;
                        productController.insertProduct(product);
                        if (result.success)
                        {
                            success_lines++;
                        }
                        else
                        {
                            MessageBox.Show("Error en registro material");
                            error = true;
                            error_list.Add("register");
                            error_lines++;
                        }
                    }
                }
                MessageBox.Show("Lineas correctas: " + success_lines + "\n" + "Lineas inccorrectas: " + error_lines, "Resultado de importación desde Excel", MessageBoxButtons.OK);
                if (product_error_list.Count > 0) //Hubo por lo menos una fila con error
                {
                    CreateExcelError(product_error_list);
                }
                excel.Quit();
                excel = null;
                wb = null;
            }
            openDialog.Dispose();
            Load_Data();
            Load_DataGridView();
        }

        private void CreateExcelError(List<ProductError> list)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            if (excel == null)
            {
                Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                return;
            }
            excel.Visible = true;

            Workbook wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            ws.Name = "Productos";
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }

            ws.Range["A1"].Value2 = "Lista de Productos con Error";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "Unidad";
            ws.Range["C2"].Value2 = "Precio";
            ws.Range["D2"].Value2 = "Moneda";
            ws.Range["E2"].Value2 = "Stock Mínimo";
            ws.Range["F2"].Value2 = "Stock Máximo";
            ws.Range["G2"].Value2 = "Tipo de Producto";
            ws.Range["H2"].Value2 = "Observaciones";
            string observation;
            ProductError material_error;
            for (int i = 0; i < list.Count(); i++)
            {
                observation = "";
                material_error = list[i];
                for (int j = 0; j < list[i].string_list.Count(); j++)//Se pone los datos del producto escrito
                {
                    ((Range)ws.Cells[i + 3, j + 1]).Value2 = material_error.string_list[j];
                }
                foreach (var item in material_error.error_list)
                {
                    switch (item)
                    {
                        case "name":
                            observation += "Nombre inválido. ";
                            break;
                        case "unit":
                            observation += "Unidad inválida. ";
                            break;
                        case "unit_find":
                            observation += "Unidad no encontrada. ";
                            break;
                        case "price":
                            observation += "Precio inválido. ";
                            break;
                        case "currency":
                            observation += "Moneda inválida. ";
                            break;
                        case "currency_find":
                            observation += "Moneda no encontrada. ";
                            break;
                        case "min":
                            observation += "Stock mínimo inválido. ";
                            break;
                        case "max":
                            observation += "Stock máximo inválido. ";
                            break;
                        case "type":
                            observation += "Tipo inválido. ";
                            break;
                        case "type_find":
                            observation += "Tipo no encontrado. ";
                            break;
                        case "register":
                            observation += "Error en registro";
                            break;
                        default:
                            break;
                    }
                }
                ((Range)ws.Cells[i + 3, 8]).Value2 = observation;
            }
            ws.Columns.AutoFit();
        }

        private void btn_template_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            if (excel == null)
            {
                Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                return;
            }
            excel.Visible = true;

            Workbook wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            ws.Name = "Productos";
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }
            ws.Range["A1"].Value2 = "Lista de Productos";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "Unidad";
            ws.Range["C2"].Value2 = "Precio";
            ws.Range["D2"].Value2 = "Moneda";
            ws.Range["E2"].Value2 = "Stock Mínimo";
            ws.Range["F2"].Value2 = "Stock Máximo";
            ws.Range["G2"].Value2 = "Tipo de Producto";
            ws.Columns.AutoFit();
        }

        public override void CheckPermissions(User u)
        {
            sessionUser = u;
            Permissions();
        }

        private void Permissions()
        {
            if (!sessionUser.Profile.HasFunctionality("CREATE PRODUCT") && !sessionUser.Profile.HasFunctionality("EDIT PRODUCT"))
            {
                this.metroTabControl1.TabPages.Remove(tabRegister);
            }
            if (!sessionUser.Profile.HasFunctionality("DELETE PRODUCT"))
            {
                btn_delete.Visible = false;
            }

        }
    }
}
