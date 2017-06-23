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

namespace WindowsFormsApp1.Views.Warehouse_M_Module
{
    public partial class UC_ProductTypeWarehouse : ICheckPermissions
    {

        bool name_flag;
        bool class_flag;

        List<Models.ProductTypeWarehouse> typewarehouse_list;
        Controller.ProductTypeWarehouseController typewarehouseController;
        int cur_row;
        Controller.Result result;

        Models.ProductTypeWarehouse curTypeWarehouse;
        Dictionary<int, string> combo_class = new Dictionary<int, string>();

     

        public UC_ProductTypeWarehouse()
        {
            InitializeComponent();
        }

        private void UC_ProductTypeWarehouse_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            typewarehouseController = new Controller.ProductTypeWarehouseController(user, password);

            combo_class.Add(2, "Seleccionar"); //0: Ventas 1 :No Ventas
            combo_class.Add(0, "Ventas");
            combo_class.Add(1, "No Ventas");

            combobox_class.DataSource = new BindingSource(combo_class, null);
            combobox_class.DisplayMember = "Value";
            combobox_class.ValueMember = "Key";

            combobox_class_s.DataSource = new BindingSource(combo_class, null);
            combobox_class_s.DisplayMember = "Value";
            combobox_class_s.ValueMember = "Key";

            Set_Flag_All(false);
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {
            result = typewarehouseController.getProductTypeWarehouses();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar tipos de almacén", MessageBoxButtons.OK);
            else typewarehouse_list = (List<Models.ProductTypeWarehouse>)result.data;
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < typewarehouse_list.Count(); i++)
            {
                String[] row = new String[5];
                row[0] = typewarehouse_list[i].Id.ToString();
                row[1] = i.ToString();
                row[2] = typewarehouse_list[i].Name;
                row[3] = combo_class[int.Parse(typewarehouse_list[i].Wclass)];
                row[4] = typewarehouse_list[i].State;
                this.metroGrid1.Rows.Add(row);
            }
        }
        private void Clean()
        {
            ClearTextBoxes(this);
            combobox_class.SelectedIndex = 2;
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

        private Models.ProductTypeWarehouse CreateTypeWarehouse(int operacion)
        {
            int id = 0;
            String name, classW, state;

            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
            name = textbox_name.Text;
            //int type_id = ((KeyValuePair<int, string>)combobox_type.SelectedItem).Key;
            classW = ((KeyValuePair<int, string>)combobox_class.SelectedItem).Key.ToString();
            state = "ACTIVE";
            Models.ProductTypeWarehouse typeWarehouse = new Models.ProductTypeWarehouse();

            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            typeWarehouse = new Models.ProductTypeWarehouse(id, name, classW, state);

            return typeWarehouse;
        }

        private void search_Click(object sender, EventArgs e)
        {
            Models.ProductTypeWarehouse typeWarehouse = new Models.ProductTypeWarehouse();
            typeWarehouse.Name = textbox_name_s.Text;
            typeWarehouse.Wclass = ((KeyValuePair<int, string>)combobox_class_s.SelectedItem).Key.ToString();
            result = typewarehouseController.getProductTypeWarehouses(typeWarehouse);
            if (!result.success)
            {
                MessageBox.Show(result.message, "Error al buscar almacén con filtros", MessageBoxButtons.OK);
            }
            else
            {
                typewarehouse_list = (List<Models.ProductTypeWarehouse>)result.data;
                Load_DataGridView();
            }
        }

        private void tabIndex_Enter(object sender, EventArgs e)
        {
            Clean();
            register.Text = "Guardar";
            //register.Visible = true;
            curTypeWarehouse = null;

            /*
            if (!sessionUser.Profile.HasFunctionality("CREATE PRODUCT WAREHOUSE"))
            {
                register.Visible = false;
            }*/
        }

        private void register_Click(object sender, EventArgs e)
        {

            Models.ProductTypeWarehouse type;
            string message = " ";

            if (curTypeWarehouse != null)
            {
                type = CreateTypeWarehouse(1);
                if (type != null) { 
                result = typewarehouseController.updateTypeWarehouse(type);
                message = "Tipo Almacén editado correctamente";
                }
            }
            else
            {
                type = CreateTypeWarehouse(0);
                if (type != null)
                {
                    result = typewarehouseController.insertTypeWarehouse(type);
                    message = "Tipo Almacén agregado correctamente";
                }
            }

            if (result.success)
            {
                MessageBox.Show(message, "Registro", MessageBoxButtons.OK);
                Set_Flag_All(false);
                Clean();
                Load_Data();
                Load_DataGridView();
                metroTabControl1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(result.message, "Error en la transacción", MessageBoxButtons.OK);
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) { 
            if (metroGrid1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                cur_row = e.RowIndex;
                //btn_delete.Enabled = true;
            }
        }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1) {
                
                    cur_row = e.RowIndex;


                    if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
                        curTypeWarehouse = typewarehouse_list[index];
                        textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        //---------------------------
                        string classname = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        combobox_class.SelectedIndex = combo_class.FirstOrDefault(x => x.Value == classname).Key + 1;
                        metroTabControl1.SelectedIndex = 1;
                        register.Text = "Editar";
                       // register.Visible = true;
                        Set_Flag_All(true);
                    }
                    /*
                    if (!sessionUser.Profile.HasFunctionality("EDIT PRODUCT WAREHOUSE"))
                    {
                        register.Visible = false;
                    }*/
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = typewarehouseController.deleteTypeWarehouse(typewarehouse_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar tipo almacén", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Tipo almacén eliminado correctamente", "Eliminar Tipo almacén", MessageBoxButtons.OK);
                Load_Data();
            }
            //btn_delete.Enabled = false;
            Load_DataGridView();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        //Cancel
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clean();
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        // Validate Data 

        private bool Validate_Data()
        {
            if (name_flag && class_flag)
            {
                return true;
            }
            return false;
        }

        private void Set_Flag_All(bool value)
        {
            name_flag = value;
            class_flag = value;
        }

        private void Set_Flag(string name, bool value)
        {
            switch (name)
            {
                case "textbox_name":
                    name_flag = value;
                    break;
                case "combobox_class":
                    class_flag = value;
                    break;
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

        private void combobox_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroComboBox combobox = (MetroFramework.Controls.MetroComboBox)sender;
            int unit_id = ((KeyValuePair<int, string>)combobox.SelectedItem).Key;

            if (unit_id == 2)
            {
                Set_Flag(combobox.Name, false);
                errorProvider.SetError(combobox, "Seleccionar una opción válida");

            }
            else
            {
                Set_Flag(combobox.Name, true);
                errorProvider.SetError(combobox, null);
            }
        }
        /*
        private void UC_Warehouse_Load()
        {
            if (!sessionUser.Profile.HasFunctionality("DELETE PRODUCT WAREHOUSE"))
            {
                btn_delete.Visible = false;
            }

            if (!sessionUser.Profile.HasFunctionality("CREATE PRODUCT WAREHOUSE") && !sessionUser.Profile.HasFunctionality("EDIT PRODUCT WAREHOUSE"))
            {
                this.metroTabControl1.TabPages.Remove(tabRegister);
            }
        }

        public override void CheckPermissions(User user)
        {
            sessionUser = user;
            UC_Warehouse_Load();
        }
        */
    }
}
