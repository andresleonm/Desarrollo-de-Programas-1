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
    public partial class Supplier : MetroFramework.Controls.MetroUserControl
    {
        int cur_row;
        List<Models.Supplier> supplier_list;
        Controller.SupplierController supplierController;
        Controller.Result result;
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            supplierController = new Controller.SupplierController(user, password);
            supplier_list = new List<Models.Supplier>();
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void register_Click(object sender, EventArgs e)
        {
            Models.Supplier sup = new Models.Supplier();
            sup.Name = textbox_name.Text;
            sup.Phone = textbox_phone.Text;
            sup.Email = textbox_email.Text;
            sup.Doi = textbox_doi.Text;
            sup.Address = textbox_address.Text;
            sup.State = "ACTIVE";
            sup.Priority = Int32.Parse(textbox_priority.Text);
            sup.Type = textbox_type.Text;

            result = supplierController.insertSupplier(sup);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al registrar proveedor", MessageBoxButtons.OK);
            }
            else
            {
                Load_Data();
            }

            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {

            supplier_list = new List<Models.Supplier>();
            result = supplierController.getSuppliers();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar proveedores", MessageBoxButtons.OK);
            else supplier_list = (List<Models.Supplier>)result.data;
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

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < supplier_list.Count(); i++)
            {
               
                    String[] row = new String[6];
                    row[0] = supplier_list[i].Id.ToString();
                    row[1] = supplier_list[i].Name.ToString();
                    row[2] = supplier_list[i].Address.ToString();
                    row[3] = supplier_list[i].Phone.ToString();
                    row[4] = supplier_list[i].Email.ToString();
                    row[5] = supplier_list[i].Priority.ToString();
                    this.metroGrid1.Rows.Add(row);

            }
        }



        //Mostrar Datos

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.Supplier sup = new Models.Supplier();
            for (int i = 0; i < supplier_list.Count(); i++)
            {
                if (supplier_list[i].Id.ToString() == metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    sup = (Models.Supplier)supplier_list[i];
                    break;
                }
            }

            cur_row = e.RowIndex;
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textbox_address.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textbox_phone.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textbox_email.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textbox_priority.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textbox_doi.Text = sup.Doi;
                textbox_type.Text = sup.Type.ToString();
                metroTabControl1.SelectedIndex = 1;
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                cur_row = e.RowIndex;
                delete.Enabled = true;
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Models.Supplier sup = new Models.Supplier();
            int id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            sup.Id = id;
            sup.Name = textbox_name.Text;
            sup.Phone = textbox_phone.Text;
            sup.Email = textbox_email.Text;
            sup.Doi = textbox_doi.Text;
            sup.Address = textbox_address.Text;
            sup.State = "ACTIVE";
            sup.Priority = Int32.Parse(textbox_priority.Text);
            sup.Type = textbox_type.Text;

            result = supplierController.updateSupplier(sup);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al registrar proveedor", MessageBoxButtons.OK);
            }
            else
            {
                Load_Data();
            }


            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private void search_Click(object sender, EventArgs e)
        {/*
            metroGrid1.Rows.Clear();
            for (int i = 0; i < supplier_list.Count(); i++)
            {
                if (textbox_priority_s.Text == supplier_list[i].Priority.ToString())
                {
                    String[] row = new String[6];
                    row[0] = supplier_list[i].Id.ToString();
                    row[1] = supplier_list[i].Name.ToString();
                    row[2] = supplier_list[i].Address.ToString();
                    row[3] = supplier_list[i].Phone.ToString();
                    row[4] = supplier_list[i].Email.ToString();
                    row[5] = supplier_list[i].Priority.ToString();
                    this.metroGrid1.Rows.Add(row);
                }
            }*/
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            Clean();
           
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int i;
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());

            for (i = 0; i < supplier_list.Count(); i++)
            {
                if (int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString()) == supplier_list[i].Id)
                    break;
            }

            result = supplierController.deleteSupplier(supplier_list[i]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar proveedor", MessageBoxButtons.OK);
            }
            else
            {
                supplier_list.Remove(supplier_list[i]);
            }
            delete.Enabled = false;
            Load_DataGridView();
        }
    }
}
