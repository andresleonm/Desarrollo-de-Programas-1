﻿using System;
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
        int cur_row;
        List<Models.Product> product_list;
        List<Models.UnitOfMeasure> unit_list;
        Controller.ProductsController productController;
        Controller.UnitController unitController;
        Controller.Result result;
        public UC_Product()
        {
            InitializeComponent();
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
            combobox_unit.DataSource = new BindingSource(combo_data, null);
            combobox_unit.DisplayMember = "Value";
            combobox_unit.ValueMember = "Key";
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
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
            metroGrid1.Rows.Clear();
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
                    this.metroGrid1.Rows.Add(row);
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
            String name = textbox_name.Text;
            int unit_id = ((KeyValuePair<int, string>)combobox_unit.SelectedItem).Key;
            int stock_min, stock_max;
            stock_min = int.Parse(textbox_stock_min.Text);
            stock_max = int.Parse(textbox_stock_max.Text);
            double price = double.Parse(textbox_price.Text);
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
            metroTabControl1.SelectedIndex = 0;

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
                textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                for (int i = 0; i < unit_list.Count(); i++)
                {
                    if (unit_list[i].Name == metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString())
                    {
                        combobox_unit.SelectedIndex = i;
                    }
                }
                textbox_stock_max.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textbox_stock_min.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textbox_price.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                metroTabControl1.SelectedIndex = 1;
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            String name = textbox_name.Text;
            int id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            int unit_id = ((KeyValuePair<int, string>)combobox_unit.SelectedItem).Key;
            int stock_min, stock_max;
            stock_min = int.Parse(textbox_stock_min.Text);
            stock_max = int.Parse(textbox_stock_max.Text);
            double price = double.Parse(textbox_price.Text);
            Models.Product product = new Models.Product(id, unit_id, name, stock_min, stock_max, price);
            Controller.Result result = productController.updateProduct(product);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al modificar producto", MessageBoxButtons.OK);
            }
            else
            {
                product_list[int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString())] = product;
            }

            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
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

        private void btn_clean_s_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
