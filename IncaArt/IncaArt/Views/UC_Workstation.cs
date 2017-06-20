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
    public partial class UC_Workstation : MetroFramework.Controls.MetroUserControl
    {
        bool name_flag;
        bool product_flag;
        bool quantity_flag;
        bool break_flag;
        bool currency_flag;
        int cur_row;
        int operation_value;// 0 para Create, 1 para Update
        List<Models.Product> product_list;
        List<Models.Workstation> workstation_list;
        List<Models.Currency> currency_list;
        Controller.ProductsController productController;
        Controller.WorkstationsController workstationController;
        Controller.CurrencyController currencyController;
        Controller.Result result;
        public UC_Workstation()
        {
            InitializeComponent();
        }

        private void UC_Workstation_VisibleChanged(object sender, EventArgs e)
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

        private void Load_Combobox()
        {
            //Cargar los combobox
            Dictionary<int, string> combo_data = new Dictionary<int, string>();

            //Producto
            combo_data.Add(0, "Seleccionar");
            foreach (var item in product_list)
            {
                combo_data.Add(item.Id, item.Name);

            }
            combobox_product.DataSource = new BindingSource(combo_data, null);
            combobox_product.DisplayMember = "Value";
            combobox_product.ValueMember = "Key";

            combobox_product_s.DataSource = new BindingSource(combo_data, null);
            combobox_product_s.DisplayMember = "Value";
            combobox_product_s.ValueMember = "Key";

            //Anterior y Siguiente Workstation
            combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "Ninguno");
            foreach (var item in workstation_list)
            {
                combo_data.Add(item.Id, item.Name);

            }
            combobox_next.DataSource = new BindingSource(combo_data, null);
            combobox_next.DisplayMember = "Value";
            combobox_next.ValueMember = "Key";

            combobox_previous.DataSource = new BindingSource(combo_data, null);
            combobox_previous.DisplayMember = "Value";
            combobox_previous.ValueMember = "Key";

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

        private void UC_Workstation_Load(object sender, EventArgs e)
        {
            string user = "";
            string password = "";
            productController = new Controller.ProductsController(user, password);
            workstationController = new Controller.WorkstationsController(user, password);
            currencyController = new Controller.CurrencyController(user, password);
        }

        private void Load_Data()
        {
            result = currencyController.getCurrencies();
            currency_list = (List<Models.Currency>)result.data;
            product_list = new List<Models.Product>();
            result = productController.getProducts();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar Producto", MessageBoxButtons.OK);
            else product_list = (List<Models.Product>)result.data;

            workstation_list = new List<Models.Workstation>();
            result = workstationController.getWorkstations();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar Puesto de Trabajo", MessageBoxButtons.OK);
            else workstation_list = (List<Models.Workstation>)result.data;
            Load_Combobox();
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            Models.Product product;
            Models.Workstation previous, next;
            string previous_name, next_name;
            for (int i = 0; i < workstation_list.Count(); i++)
            {
                result = productController.getProduct(workstation_list[i].Product_id);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al buscar producto", MessageBoxButtons.OK);
                }
                else
                {
                    product = (Models.Product)result.data;

                    if (workstation_list[i].Previous_workstation == 0)
                    {
                        previous_name = "-";
                    }
                    else
                    {
                        result = workstationController.getWorkstation(workstation_list[i].Previous_workstation);
                        previous = (Models.Workstation)result.data;
                        previous_name = previous.Name;
                    }
                    if (workstation_list[i].Next_workstation == 0)
                    {
                        next_name = "-";
                    }
                    else
                    {
                        result = workstationController.getWorkstation(workstation_list[i].Next_workstation);
                        next = (Models.Workstation)result.data;
                        next_name = next.Name;
                    }

                    String[] row = new String[6];
                    row[0] = workstation_list[i].Id.ToString();
                    row[1] = i.ToString();
                    row[2] = workstation_list[i].Name;
                    row[3] = product.Name;
                    row[4] = previous_name;
                    row[5] = next_name;
                    this.metroGrid1.Rows.Add(row);
                }

            }
        }
        private void Clean()
        {
            ClearTextBoxes(this);
            combobox_next.SelectedIndex = 0;
            combobox_previous.SelectedIndex = 0;
            combobox_product.SelectedIndex = 0;
            combobox_product_s.SelectedIndex = 0;
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
        private Models.Workstation CreateWorkstation(int operacion)
        {
            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
            String name;
            name = textbox_name.Text;

            int previous_id, next_id, product_id, quantity,currency_id;
            double break_cost;
            previous_id = ((KeyValuePair<int, string>)combobox_previous.SelectedItem).Key;
            next_id = ((KeyValuePair<int, string>)combobox_next.SelectedItem).Key;
            product_id = ((KeyValuePair<int, string>)combobox_product.SelectedItem).Key;
            quantity = Int32.Parse(textbox_quantity.Text);
            currency_id = ((KeyValuePair<int, string>)combobox_currency.SelectedItem).Key;
            break_cost = double.Parse(textbox_break.Text);
            Models.Workstation workstation = new Models.Workstation();
            workstation.Product_id = product_id;
            workstation.Previous_workstation = previous_id;
            workstation.Next_workstation = next_id;
            workstation.Quantity = quantity;
            workstation.Name = name;
            workstation.Break_cost = break_cost;
            workstation.Currency_id = currency_id;
            int id = 0;
            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            workstation.Id = id;
            return workstation;
        }

        //Registrar
        private void btn_new_Click(object sender, EventArgs e)
        {
            Models.Workstation workstation = CreateWorkstation(0);
            if (workstation != null)
            {
                result = workstationController.insertWorkstation(workstation);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al registrar Puesto de Trabajo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Puesto de Trabajo registrado correctamente", "Registrar Puesto de Trabajo", MessageBoxButtons.OK);
                    Load_Data();
                }
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }
            
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                cur_row = e.RowIndex;
                //btn_delete.Enabled = true;
            }
        }
        //Mostrar
        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cur_row = e.RowIndex;
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                int id = Int32.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
                result = workstationController.getWorkstation(id);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al buscar Puesto de Trabajo", MessageBoxButtons.OK);
                }
                else
                {
                    Models.Workstation workstation = (Models.Workstation)result.data;
                    for (int i = 0; i < product_list.Count(); i++)
                    {
                        if (product_list[i].Id == workstation.Product_id)
                        {
                            combobox_product.SelectedIndex = i+1;
                            break;
                        }
                    }
                    for (int i = 0; i < currency_list.Count(); i++)
                    {
                        if (currency_list[i].Id == workstation.Currency_id)
                        {
                            combobox_currency.SelectedIndex = i + 1;
                            break;
                        }
                    }
                    if (workstation.Previous_workstation == 0)
                    {
                        combobox_previous.SelectedIndex = 0;
                    }
                    else
                    {
                        for (int i = 0; i < workstation_list.Count(); i++)
                        {
                            if (workstation_list[i].Id == workstation.Previous_workstation)
                            {
                                combobox_previous.SelectedIndex = i+1;
                                break;
                            }
                        }
                    }
                    if (workstation.Next_workstation == 0)
                    {
                        combobox_next.SelectedIndex = 0;
                    }
                    else
                    {
                        for (int i = 0; i < workstation_list.Count(); i++)
                        {
                            if (workstation_list[i].Id == workstation.Next_workstation)
                            {
                                combobox_next.SelectedIndex = i+1;
                                break;
                            }
                        }
                    }
                    Set_Flag_All(true);
                    textbox_break.Text = workstation.Break_cost.ToString();
                    textbox_name.Text = workstation.Name;
                    textbox_quantity.Text = workstation.Quantity.ToString();
                    metroTabControl1.SelectedIndex = 1;
                    operation_value = 1;
                }
            }
        }

        //Editar
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Models.Workstation workstation = CreateWorkstation(1);
            if (workstation != null)
            {
                result = workstationController.updateWorkstation(workstation);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al editar Puesto de Trabajo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Puesto de Trabajo editado correctamente", "Editar Puesto de Trabajo", MessageBoxButtons.OK);
                    Load_Data();
                }
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = workstationController.deleteWorkstation(workstation_list[index]);
            if (result.data == null)
            {
                MessageBox.Show("Puesto de Trabajo eliminado correctamente", "Eliminar Puesto de Trabajo", MessageBoxButtons.OK);
            }
            else
            {
                Load_Data();
            }

            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clean();
            metroTabControl1.SelectedIndex = 0;
            operation_value = 0;
        }

        private void btn_clean_s_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Models.Workstation workstation = new Models.Workstation();
            workstation.Name = textbox_name_s.Text;
            workstation.Product_id = ((KeyValuePair<int, string>)combobox_product_s.SelectedItem).Key;
            result = workstationController.getWorkstations(workstation);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al buscar puesto trabajo con filtro", MessageBoxButtons.OK);
            }
            else
            {
                workstation_list = (List<Models.Workstation>)result.data;
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
                if (textbox.Name== "textbox_break")
                {
                    double number;
                    if (!double.TryParse(text, out number))
                    {
                        Set_Flag(textbox.Name, false);
                        errorProvider.SetError(textbox, "Costo debe ser número");
                    }
                    else
                    {
                        Set_Flag(textbox.Name, true);
                    }
                }
                else
                {
                    int number;
                    if (!int.TryParse(text, out number))
                    {
                        Set_Flag(textbox.Name, false);
                        errorProvider.SetError(textbox, "Cantidad debe ser número");
                    }
                    else
                    {
                        Set_Flag(textbox.Name, true);
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
            if (name_flag && product_flag && quantity_flag)
            {
                return true;
            }
            return false;
        }

        private void Set_Flag_All(bool value)
        {
            name_flag = value;
            product_flag = value;
            quantity_flag = value;
            break_flag = value;
            currency_flag = value;
        }

        private void Set_Flag(string name, bool value)
        {
            switch (name)
            {
                case "textbox_name":
                    name_flag = value;
                    break;
                case "combobox_product":
                    product_flag = value;
                    break;
                case "textbox_quantity":
                    quantity_flag = value;
                    break;
                case "textbox_break":
                    break_flag = value;
                    break;
                case "combobox_currency":
                    currency_flag = value;
                    break;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Models.Workstation workstation = CreateWorkstation(operation_value);
            if (workstation != null)
            {
                if (workstation.Id == 0)
                {
                    result = workstationController.insertWorkstation(workstation);
                    if (result.data == null)
                    {
                        MessageBox.Show(result.message, "Error al registrar Puesto de Trabajo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Puesto de Trabajo registrado correctamente", "Registrar Puesto de Trabajo", MessageBoxButtons.OK);
                    }
                }else
                {
                    result = workstationController.updateWorkstation(workstation);
                    if (result.data == null)
                    {
                        MessageBox.Show(result.message, "Error al editar Puesto de Trabajo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Puesto de Trabajo editado correctamente", "Editar Puesto de Trabajo", MessageBoxButtons.OK);
                    }
                }
                Load_Data();
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }
            operation_value = 0;
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

            if (textbox.Name == "textbox_break")
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

    }
}
