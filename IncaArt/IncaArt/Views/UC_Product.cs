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
    public partial class UC_Product : MetroFramework.Controls.MetroUserControl
    {
        bool name_flag;
        bool unit_flag;
        bool max_flag;
        bool min_flag;
        bool price_flag;
        bool currency_flag;
        int cur_row;
        int operation_value;// 0 para Create, 1 para Update
        List<Models.Product> product_list;
        List<Models.UnitOfMeasure> unit_list;
        List<Models.Currency> currency_list;
        Controller.ProductsController productController;
        Controller.UnitController unitController;
        Controller.CurrencyController currencyController;
        Controller.Result result;
        public UC_Product()
        {
            InitializeComponent();
        }

        private void UC_Product_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            operation_value = 0;
            productController = new Controller.ProductsController(user, password);
            unitController = new Controller.UnitController(user, password);
            currencyController = new Controller.CurrencyController(user, password);
            Load_Data();

            //Cargar los combobox
            Dictionary<int, string> combo_data = new Dictionary<int, string>();
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


            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {
            result = currencyController.getCurrencies();
            currency_list = (List<Models.Currency>)result.data;
            result = unitController.getUnits();
            unit_list = (List<Models.UnitOfMeasure>)result.data;
            product_list = new List<Models.Product>();
            result = productController.getProducts();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar producto", MessageBoxButtons.OK);
            else product_list = (List<Models.Product>)result.data;
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < product_list.Count(); i++)
            {
                Models.UnitOfMeasure unit = new Models.UnitOfMeasure();
                result = unitController.getUnit(product_list[i].Unit_id);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al buscar unit", MessageBoxButtons.OK);
                }
                else
                {
                    unit = (Models.UnitOfMeasure)result.data;
                    String[] row = new String[7];
                    row[0] = product_list[i].Id.ToString();
                    row[1] = i.ToString();
                    row[2] = product_list[i].Name;
                    row[3] = unit.Name;
                    row[4] = product_list[i].Unit_price.ToString();
                    row[5] = product_list[i].Stock_min.ToString();
                    row[6] = product_list[i].Stock_max.ToString();
                    this.metroGrid1.Rows.Add(row);
                }

            }
        }

        private void Clean()
        {
            ClearTextBoxes(this);
            combobox_unit.SelectedIndex = 0;
            combobox_unit_s.SelectedIndex = 0;
            combobox_currency.SelectedIndex = 0;
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }


                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
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

            Models.Product product = new Models.Product();
            product.Name = name;
            product.Unit_id = unit_id;
            product.Stock_min = stock_min;
            product.Stock_max = stock_max;
            product.Currency_id = currency_id;
            product.Unit_price = price;
            int id = 0;
            if (operation == 1)
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            product.Id=id;
            return product;
        }

        private void button_New_Click(object sender, EventArgs e)
        {

            Models.Product product = CreateProduct(0);
            if (product != null)
            {
                result = productController.insertProduct(product);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al registrar producto", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Producto registrado correctamente", "Registrar producto", MessageBoxButtons.OK);
                    Load_Data();
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
                if (result.data != null)
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
                    Set_Flag_All(true);
                    textbox_stock_max.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    textbox_stock_min.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    textbox_price.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
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
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al modificar producto", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Producto editado correctamente", "Editar producto", MessageBoxButtons.OK);
                    Load_Data();
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
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar material", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Producto eliminado correctamente", "Eliminar producto", MessageBoxButtons.OK);
                Load_Data();
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
            result = productController.getProducts(product);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al buscar producto con filtro", MessageBoxButtons.OK);
            }
            else
            {
                product_list = (List<Models.Product>)result.data;
                Load_DataGridView();
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
                if (textbox.Name == "textbox_price")
                {
                    double number;
                    if (!Double.TryParse(text, out number))
                    {
                        Set_Flag(textbox.Name, false);
                        errorProvider.SetError(textbox, "Precio debe ser número");
                    }else
                    {
                        Set_Flag(textbox.Name, true);
                    }
                }
                else
                {
                    int number;
                    if (!Int32.TryParse(text, out number))
                    {
                        Set_Flag(textbox.Name, false);
                        errorProvider.SetError(textbox, "Stock debe ser número");
                    }
                    else
                    {
                        errorProvider.SetError(textbox, null);
                    }
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
                            Set_Flag(textbox.Name, true);
                            errorProvider.SetError(textbox, null);
                        }

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
                    if (result.data == null)
                    {
                        MessageBox.Show(result.message, "Error al registrar producto", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Producto registrado correctamente", "Registrar producto", MessageBoxButtons.OK);
                        Load_Data();
                    }
                   
                }else
                {
                    result = productController.updateProduct(product);
                    if (result.data == null)
                    {
                        MessageBox.Show(result.message, "Error al modificar producto", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Producto editado correctamente", "Editar producto", MessageBoxButtons.OK);
                        Load_Data();
                    }
                }
                operation_value = 0;
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }
        }
    }
}
