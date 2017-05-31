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
    public partial class UC_MaterialWarehouse : MetroFramework.Controls.MetroUserControl
    {

        int cur_row;
        List<Models.MaterialWarehouse> warehouse_list;
        List<Models.Material> materials_list;
        List<Models.MaterialTypeWarehouse> types_list;
        List<Models.UnitOfMeasure> unit_list;


        Controller.MaterialWarehouseController materialWarehouseController;
        Controller.MaterialsController materialController;
        Controller.MaterialTypeWarehouseController typeController;
        Controller.UnitController unitController;

        Controller.Result result;
        Controller.Result resultP;
        Controller.Result resultT;

        public UC_MaterialWarehouse()
        {
            InitializeComponent();
            //Load_Data();
        }

        private void UC_MaterialWarehouse_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            materialWarehouseController = new Controller.MaterialWarehouseController(user, password);
            materialController = new Controller.MaterialsController(user, password);
            typeController = new Controller.MaterialTypeWarehouseController(user, password);
            unitController = new Controller.UnitController(user, password);

            Load_Data();

            //Cargar los combobox - Products
            Dictionary<int, string> combo_data_products = new Dictionary<int, string>();
            combo_data_products.Add(-1, "");
            foreach (var item in materials_list)
            {
                combo_data_products.Add(item.Id, item.Name);
            }

            combobox_products.DataSource = new BindingSource(combo_data_products, null);
            combobox_products.DisplayMember = "Value";
            combobox_products.ValueMember = "Key";

            combobox_product_s.DataSource = new BindingSource(combo_data_products, null);
            combobox_product_s.DisplayMember = "Value";
            combobox_product_s.ValueMember = "Key";

            //Cargar los combobox - Types
            Dictionary<int, string> combo_data_types = new Dictionary<int, string>();
            combo_data_types.Add(-1, "");
            foreach (var item in types_list)
            {
                combo_data_types.Add(item.Id, item.Name);
            }

            combobox_type.DataSource = new BindingSource(combo_data_types, null);
            combobox_type.DisplayMember = "Value";
            combobox_type.ValueMember = "Key";

            combobox_type_s.DataSource = new BindingSource(combo_data_types, null);
            combobox_type_s.DisplayMember = "Value";
            combobox_type_s.ValueMember = "Key";


            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {
            result = unitController.getUnits();
            unit_list = (List<Models.UnitOfMeasure>)result.data;

            resultT = typeController.getMaterialTypeWarehouses();
            types_list = (List<Models.MaterialTypeWarehouse>)resultT.data;

            resultP = materialController.getMaterials();
            materials_list = (List<Models.Material>)resultP.data;

            warehouse_list = new List<Models.MaterialWarehouse>();
            result = materialWarehouseController.getMaterialWarehouses();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar almacén", MessageBoxButtons.OK);
            else warehouse_list = (List<Models.MaterialWarehouse>)result.data;
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
            for (int i = 0; i < warehouse_list.Count(); i++)
            {
                //Producto
                Models.Material product = new Models.Material();
                resultP = materialController.getMaterial(warehouse_list[i].Material_id);


                //Tipo
                Models.MaterialTypeWarehouse type = new Models.MaterialTypeWarehouse();
                resultT = typeController.getMaterialTypeWarehouse(warehouse_list[i].Type_id);

                if (resultP.data == null || resultT.data == null)
                {
                    MessageBox.Show(result.message, "Error en las búsquedas de Materiales o Tipos de Almacén", MessageBoxButtons.OK);
                }
                else
                {
                    // Producto
                    product = (Models.Material)resultP.data;
                    //Tipo
                    type = (Models.MaterialTypeWarehouse)resultT.data;
                    //Unidad
                    Models.UnitOfMeasure unit = new Models.UnitOfMeasure();
                    result = unitController.getUnit(product.Unit_id);
                    unit = (Models.UnitOfMeasure)result.data;

                    //Grilla
                    String[] row = new String[7];
                    row[0] = warehouse_list[i].Id.ToString();
                    row[1] = warehouse_list[i].Name;
                    row[2] = type.Name;
                    row[3] = product.Name;
                    row[4] = unit.Symbol;
                    row[5] = warehouse_list[i].Current_physical_stock.ToString();
                    row[6] = warehouse_list[i].Max_capacity.ToString();
                    this.metroGrid1.Rows.Add(row);
                }

            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            int id = 0;
            String name = textbox_name.Text;
            int product_id = ((KeyValuePair<int, string>)combobox_products.SelectedItem).Key;
            int physical_stock = 0;
            int max_capacity = Int32.Parse(textbox_max_capacity.Text);
            int type_id = ((KeyValuePair<int, string>)combobox_type.SelectedItem).Key;
            String state = "ACTIVE";
            int logical_stock = 0;

            Models.MaterialWarehouse warehouse = new Models.MaterialWarehouse(id, name, product_id, physical_stock, max_capacity, type_id, state, logical_stock);
            result = materialWarehouseController.insertMaterialWarehouse(warehouse);
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

        private void edit_Click(object sender, EventArgs e)
        {
            String name = textbox_name.Text;
            int id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            int product_id = ((KeyValuePair<int, string>)combobox_products.SelectedItem).Key;
            int type_id = ((KeyValuePair<int, string>)combobox_type.SelectedItem).Key;
            int max_capacity = int.Parse(textbox_max_capacity.Text);
            int i = 0;
            for (i = 0; i < warehouse_list.Count(); i++)
            {
                if (warehouse_list[i].Id == id)
                {
                    break;
                }
            }
            int physical_stock = warehouse_list[i].Current_physical_stock;
            int logical_stock = warehouse_list[i].Current_logical_stock;
            String state = warehouse_list[i].State;


            Models.MaterialWarehouse warehouse = new Models.MaterialWarehouse(id, name, product_id, physical_stock, max_capacity, type_id, state, logical_stock);
            result = materialWarehouseController.updateMaterialWarehouse(warehouse);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al modificar almacén material", MessageBoxButtons.OK);
            }
            else
            {
                warehouse_list[i] = warehouse;
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

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Id, Nombre,Tipo,Producto,Unidad,capacidad Actual,capacidad Maxima
            cur_row = e.RowIndex;
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                for (int i = 0; i < materials_list.Count(); i++)
                {
                    if (materials_list[i].Name == metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString())
                    {
                        combobox_products.SelectedIndex = i + 1;
                        break;
                    }
                }

                for (int i = 0; i < types_list.Count(); i++)
                {
                    if (types_list[i].Name == metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString())
                    {
                        combobox_type.SelectedIndex = i + 1;
                        break;
                    }
                }

                textbox_max_capacity.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();

                metroTabControl1.SelectedIndex = 1;
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = materialWarehouseController.deleteMaterialWarehouse(warehouse_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar almacén", MessageBoxButtons.OK);
            }
            else
            {
                warehouse_list.Remove(warehouse_list[index]);
            }
            Load_DataGridView();
        }

        private void search_Click(object sender, EventArgs e)
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < warehouse_list.Count(); i++)
            {
                //Producto
                Models.Material product = new Models.Material();
                resultP = materialController.getMaterial(warehouse_list[i].Material_id);


                //Tipo
                Models.MaterialTypeWarehouse type = new Models.MaterialTypeWarehouse();
                resultT = typeController.getMaterialTypeWarehouse(warehouse_list[i].Type_id);

                if (resultP.data == null || resultT.data == null)
                {
                    MessageBox.Show(result.message, "Error en las búsquedas de Productos o Tipos de Almacén", MessageBoxButtons.OK);
                }
                else
                {
                    // Producto
                    product = (Models.Material)resultP.data;
                    //Tipo
                    type = (Models.MaterialTypeWarehouse)resultT.data;
                    //Unidad
                    Models.UnitOfMeasure unit = new Models.UnitOfMeasure();
                    result = unitController.getUnit(product.Unit_id);
                    unit = (Models.UnitOfMeasure)result.data;

                    String nameSelect = ((KeyValuePair<int, string>)combobox_product_s.SelectedItem).Value;
                    String typeSelect = ((KeyValuePair<int, string>)combobox_type_s.SelectedItem).Value;
                    if (product.Name == nameSelect && type.Name == typeSelect)
                    {

                        //Grilla
                        String[] row = new String[7];
                        row[0] = warehouse_list[i].Id.ToString();
                        row[1] = warehouse_list[i].Name;
                        row[2] = type.Name;
                        row[3] = product.Name;
                        row[4] = unit.Symbol;
                        row[5] = warehouse_list[i].Current_physical_stock.ToString();
                        row[6] = warehouse_list[i].Max_capacity.ToString();
                        this.metroGrid1.Rows.Add(row);

                    }
                }

            }
        }
    }
}
