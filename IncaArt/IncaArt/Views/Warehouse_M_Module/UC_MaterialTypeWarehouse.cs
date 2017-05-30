using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Warehouse_M_Module
{
    public partial class UC_MaterialTypeWarehouse : MetroFramework.Controls.MetroUserControl
    {

        List<Models.MaterialTypeWarehouse> types_list;
        Controller.MaterialTypeWarehouseController typeController;
        int cur_row;
        Controller.Result result;
        public UC_MaterialTypeWarehouse()
        {
            InitializeComponent();
        }

        private void UC_MaterialTypeWarehouse_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            typeController = new Controller.MaterialTypeWarehouseController(user, password);
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void register_Click(object sender, EventArgs e)
        {
            int id = 0;
            String name = textbox_name.Text;
            String class1 = combobox_class.SelectedIndex.ToString();
            String state = "ACTIVE";

            Models.MaterialTypeWarehouse warehouse = new Models.MaterialTypeWarehouse(id, name,class1, state);
            result = typeController.insertMaterialTypeWarehouse(warehouse);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al registrar nuevo almacén", MessageBoxButtons.OK);
            }
            else
            {
                Load_Data();
            }
            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

         private void Load_Data(){
            types_list = new List<Models.MaterialTypeWarehouse>();
            result = typeController.getMaterialTypeWarehouses();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar almacén", MessageBoxButtons.OK);
            else types_list = (List<Models.MaterialTypeWarehouse>)result.data;
        }


        private void Clean()
        {
            ClearTextBoxes(this);
            Load_DataGridView();
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

                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedItem = -1;
                }

            }
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < types_list.Count(); i++)
            {


                    //Grilla
                    String[] row = new String[7];
                    row[0] = types_list[i].Id.ToString();
                    row[1] = types_list[i].Name;
                    String clase;
                if (types_list[i].Wclass.CompareTo('0') == 0) clase = "Producción".ToString();
                else clase = "Observación";

                    row[2] = clase;
                    row[3] = types_list[i].State;

                    this.metroGrid1.Rows.Add(row);

            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            combobox_class.SelectedIndex.ToString();
            String name = textbox_name.Text;
            int id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            String class1 = combobox_class.SelectedIndex.ToString();
            String state="ACTIVE";

            Models.MaterialTypeWarehouse warehouse = new Models.MaterialTypeWarehouse(id,name,class1,state);
            result = typeController.updateMaterialTypeWarehouse(warehouse);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al modificar almacén material", MessageBoxButtons.OK);
            }
            else
            {
                int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
                types_list[index] = warehouse;
            }

            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private void cancel_Click(object sender, EventArgs e)
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

        private void metroGrid1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cur_row = e.RowIndex;
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                metroTabControl1.SelectedIndex = 1;
            }
        }
    }
}
