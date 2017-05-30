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
        int cur_row;
        List<Models.Product> product_list;
        List<Models.Workstation> workstation_list;
        Controller.ProductsController productController;
        Controller.WorkstationsController workstationController;
        Controller.Result result;
        public UC_Workstation()
        {
            InitializeComponent();
        }

        private void UC_Workstation_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            productController = new Controller.ProductsController(user, password);
            workstationController = new Controller.WorkstationsController(user, password);
            Load_Data();

            //Cargar los combobox
            Dictionary<int, string> combo_data = new Dictionary<int, string>();
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

            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {
            product_list = new List<Models.Product>();
            result = productController.getProducts();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar Producto", MessageBoxButtons.OK);
            else product_list = (List<Models.Product>)result.data;

            workstation_list = new List<Models.Workstation>();
            result = workstationController.getWorkstations();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar Puesto de Trabajo", MessageBoxButtons.OK);
            else workstation_list = (List<Models.Workstation>)result.data;
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
            String name;
            name = textbox_name.Text;

            int previous_id, next_id, product_id, quantity;
            previous_id = ((KeyValuePair<int, string>)combobox_previous.SelectedItem).Key;
            next_id = ((KeyValuePair<int, string>)combobox_next.SelectedItem).Key;
            product_id = ((KeyValuePair<int, string>)combobox_product.SelectedItem).Key;
            quantity = Int32.Parse(textbox_quantity.Text);
            Models.Workstation workstation = new Models.Workstation();
            workstation.Product_id = product_id;
            workstation.Previous_workstation = previous_id;
            workstation.Next_workstation = next_id;
            workstation.Quantity = quantity;
            workstation.Name = name;
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
            result = workstationController.insertWorkstation(workstation);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al registrar Puesto de Trabajo", MessageBoxButtons.OK);
            }
            else
            {
                Load_Data();
            }

            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
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
                            combobox_product.SelectedIndex = i;
                            break;
                        }
                    }if (workstation.Previous_workstation == 0)
                    {
                        combobox_previous.SelectedIndex = 0;
                    }
                    else
                    {
                        for (int i = 0; i < workstation_list.Count(); i++)
                        {
                            if (workstation_list[i].Id == workstation.Previous_workstation)
                            {
                                combobox_previous.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                    if(workstation.Next_workstation == 0)
                    {
                        combobox_next.SelectedIndex = 0;
                    }else{
                        for (int i = 0; i < workstation_list.Count(); i++)
                        {
                            if (workstation_list[i].Id == workstation.Next_workstation)
                            {
                                combobox_next.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                    
                    textbox_name.Text = workstation.Name;
                    textbox_quantity.Text = workstation.Quantity.ToString();
                    metroTabControl1.SelectedIndex = 1;
                }
            }
        }

        //Editar
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Models.Workstation workstation = CreateWorkstation(1);
            result = workstationController.updateWorkstation(workstation);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al editar Puesto de Trabajo", MessageBoxButtons.OK);
            }
            else
            {
                Load_Data();
            }

            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = workstationController.deleteWorkstation(workstation_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar Puesto de Trabajo", MessageBoxButtons.OK);
            }
            else
            {
                Load_Data();
            }

            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }
    }
}