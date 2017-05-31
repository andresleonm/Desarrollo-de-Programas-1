using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class Client : MetroFramework.Controls.MetroUserControl
    {
        int cur_row;
        List<Models.Customer> supplier_list;
        Controller.CustomerController supplierController;
        Controller.Result result;


        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            supplierController = new Controller.CustomerController(user, password);
            supplier_list = new List<Models.Customer>();
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private bool validate_data(String name, String paternal_last_name, String maternal_last_name, String dni, DateTime birthday, char gender, String address, String phone, String email, string companyName)
        {
            bool isCorrect = true;
            String message = "";
            if (name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el nombre del trabajador.\n";
            }
            if (paternal_last_name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el apellido paterno del trabajador.\n";
            }
            if (maternal_last_name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el apellido materno del trabajador.\n";
            }
            if (dni == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el dni del trabajador.\n";
            }
            if (gender == ' ')
            {
                isCorrect = false;
                message += "- Debe ingresar el género del trabajador.\n";
            }
            if (address == "")
            {
                isCorrect = false;
                message += "- Debe ingresar la dirección del trabajador.\n";
            }
            if (phone == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el teléfono del trabajador.\n";
            }
            if (email == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el email del trabajador.\n";
            }
            if (companyName == "")
            {
                isCorrect = false;
                message += "- Debe ingresar una compania.\n";
            }

            if (!isCorrect)
            {
                MessageBox.Show(message, "Error al registrar cliente", MessageBoxButtons.OK);
            }

            return isCorrect;
        }

       

        private void register_Click(object sender, EventArgs e)
        {
            Models.Customer sup = new Models.Customer();
            sup.Name = textbox_name.Text;
            sup.Phone = textbox_phone.Text;
            sup.Email = textbox_email.Text;
            sup.Doi = textbox_doi.Text;
            sup.Address = textbox_address.Text;
            sup.State = "ACTIVE";
            sup.Priority = Int32.Parse(textbox_priority.Text);
            sup.Type = textbox_type.Text;

            result = supplierController.insertCustomer(sup);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al registrar cliente", MessageBoxButtons.OK);
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

            supplier_list = new List<Models.Customer>();
            result = supplierController.getCustomers();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar clientes", MessageBoxButtons.OK);
            else supplier_list = (List<Models.Customer>)result.data;
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
            Models.Customer sup = new Models.Customer();
            for (int i = 0; i < supplier_list.Count(); i++)
            {
                if (supplier_list[i].Id.ToString() == metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    sup = (Models.Customer)supplier_list[i];
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

        private void search_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Models.Customer sup = new Models.Customer();
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

            result = supplierController.updateCustomer(sup);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al registrar cliente", MessageBoxButtons.OK);
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

        private void delete_Click(object sender, EventArgs e)
        {
            int i;
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());

            for (i = 0; i < supplier_list.Count(); i++)
            {
                if (int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString()) == supplier_list[i].Id)
                    break;
            }

            result = supplierController.deleteCustomer(supplier_list[i]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar cliente", MessageBoxButtons.OK);
            }
            else
            {
                supplier_list.Remove(supplier_list[i]);
            }
            delete.Enabled = false;
            Load_DataGridView();
        }

        private void Client_Load_1(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            supplierController = new Controller.CustomerController(user, password);
            supplier_list = new List<Models.Customer>();
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void metroGrid1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Models.Customer sup = new Models.Customer();
            for (int i = 0; i < supplier_list.Count(); i++)
            {
                if (supplier_list[i].Id.ToString() == metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    sup = (Models.Customer)supplier_list[i];
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

        private void metroGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                cur_row = e.RowIndex;
                delete.Enabled = true;
            }
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            Models.Customer sup = new Models.Customer();
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

            result = supplierController.updateCustomer(sup);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al registrar cliente", MessageBoxButtons.OK);
            }
            else
            {
                Load_Data();
            }


            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            int i;
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());

            for (i = 0; i < supplier_list.Count(); i++)
            {
                if (int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString()) == supplier_list[i].Id)
                    break;
            }

            result = supplierController.deleteCustomer(supplier_list[i]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar cliente", MessageBoxButtons.OK);
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
