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
    public partial class UC_Product2 : UserControl
    {
        int cur_row;
        List<Models.Product> product_list;
        List<Models.UnitOfMeasure> unit_list;
        Controller.ProductsController productController;
        Controller.UnitController unitController;
        public UC_Product2()
        {
            InitializeComponent();
        }
        private bool validate_data(string name)
        {
            bool isCorrect = true;
            string message = "";
            double numberDouble;
            Int32 numberInt;

            if (name == "")
            {
                isCorrect = false;
                message = "-Debe ingresar el nombre del producto.\n";
            }
            if (comboBox_UnitMeasure.SelectedItem == null)
            {
                isCorrect = false;
                message += "-Debe seleccionar la unidad de medida del producto.\n";
            }
            if (textBox_Price.Text == "")
            {
                isCorrect = false;
                message += "-Debe ingresar el precio del producto.\n";
            }
            else if (!Double.TryParse(textBox_Price.Text, out numberDouble))
            {
                isCorrect = false;
                message += "-Debe ingresar un número válido en el precio del producto.\n";
            }
            //if (comboBox_Currency.SelectedItem == null)
            //{
            //    isCorrect = false;
            //    message += "-Debe seleccionar la moneda correspondiente al precio del producto.\n";
            //}
            if (textBox_StockMin.Text == "")
            {
                isCorrect = false;
                message += "-Debe ingresar el stock mínimo del producto.\n";
            }
            else if (!Int32.TryParse(textBox_StockMin.Text, out numberInt))
            {
                isCorrect = false;
                message += "-Debe ingresar un número válido para el stock mínimo del producto.\n";
            }
            if (textBox_StockMax.Text == "")
            {
                isCorrect = false;
                message += "-Debe ingresar el stock máximo del producto.\n";
            }
            else if (!Int32.TryParse(textBox_StockMax.Text, out numberInt))
            {
                isCorrect = false;
                message += "-Debe ingresar un número válido para el stock máximo del producto.\n";
            }

            if (!isCorrect)
                MessageBox.Show(message, "Error al registrar un nuevo perfil", MessageBoxButtons.OK);
            return isCorrect;
        }


        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_StockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_StockMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UC_Product_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            productController = new Controller.ProductsController(user, password);
            unitController = new Controller.UnitController(user, password);
            Load_Data();

            //Cargar los combobox
            Dictionary<int, string> combo_data = new Dictionary<int, string>();
            foreach (var item in unit_list)
            {
                combo_data.Add(item.Id, item.Symbol);

            }
            comboBox_UnitMeasure.DataSource = new BindingSource(combo_data, null);
            comboBox_UnitMeasure.DisplayMember = "Value";
            comboBox_UnitMeasure.ValueMember = "Key";
            Load_DataGridView();
        }

        private void Load_Data()
        {
            Controller.Result result;
            result = unitController.getUnits();
            unit_list = (List<Models.UnitOfMeasure>)result.data;
            product_list = new List<Models.Product>();
            result = productController.getProducts();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar producto", MessageBoxButtons.OK);
            else product_list = (List<Models.Product>)result.data;
        }

        private void Load_DataGridView()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < product_list.Count(); i++)
            {
                Models.UnitOfMeasure unit = new Models.UnitOfMeasure();
                Controller.Result result = unitController.getUnit(product_list[i].Unit_id);
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
                    this.dataGridView1.Rows.Add(row);
                }

            }
        }

        private void Clean()
        {
            ClearTextBoxes(this);
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

        private void button_New_Click(object sender, EventArgs e)
        {
            String name = textBox_Name.Text;
            if (validate_data(name))
            {
                int unit_id = ((KeyValuePair<int, string>)comboBox_UnitMeasure.SelectedItem).Key;
                int stock_min, stock_max;
                stock_min = int.Parse(textBox_StockMin.Text);
                stock_max = int.Parse(textBox_StockMax.Text);
                double price = double.Parse(textBox_Price.Text);
                Models.Product product = new Models.Product(0, unit_id, name, stock_min, stock_max, price);
                Controller.Result result = productController.insertProduct(product);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al registrar producto", MessageBoxButtons.OK);
                }
                else
                {
                    product_list.Add(product);
                }

                Load_DataGridView();
                Clean();
            }

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                cur_row = e.RowIndex;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cur_row = e.RowIndex;
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                textBox_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                for (int i = 0; i < unit_list.Count(); i++)
                {
                    if (unit_list[i].Name == dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString())
                    {
                        comboBox_UnitMeasure.SelectedIndex = i;
                    }
                }
                textBox_StockMax.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox_StockMin.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox_Price.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            String name = textBox_Name.Text;
            if (validate_data(name))
            {
                int id = int.Parse(dataGridView1.Rows[cur_row].Cells[0].Value.ToString());
                int unit_id = ((KeyValuePair<int, string>)comboBox_UnitMeasure.SelectedItem).Key;
                int stock_min, stock_max;
                stock_min = int.Parse(textBox_StockMin.Text);
                stock_max = int.Parse(textBox_StockMax.Text);
                double price = double.Parse(textBox_Price.Text);
                Models.Product product = new Models.Product(id, unit_id, name, stock_min, stock_max, price);
                Controller.Result result = productController.updateProduct(product);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al modificar producto", MessageBoxButtons.OK);
                }
                else
                {
                    product_list[int.Parse(dataGridView1.Rows[cur_row].Cells[1].Value.ToString())] = product;
                }

                Load_DataGridView();
                Clean();
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dataGridView1.Rows[cur_row].Cells[1].Value.ToString());
            Controller.Result result = productController.deleteProduct(product_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar material", MessageBoxButtons.OK);
            }
            else
            {
                product_list.Remove(product_list[index]);
            }
            Load_DataGridView();
        }
    }
}
