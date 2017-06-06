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
    public partial class UC_ProductWarehouse : MetroFramework.Controls.MetroUserControl
    {
        int cur_row;
        bool name_flag;
        bool product_flag;
        bool type_flag;
        bool capacity_flag;

        List<Models.ProductWarehouse> warehouse_list;
        List<Models.Product> products_list;
        List<Models.ProductTypeWarehouse> types_list;
        List<Models.UnitOfMeasure> unit_list;


        Controller.ProductWarehouseController productWarehouseController;
        Controller.ProductsController productController;
        Controller.ProductTypeWarehouseController typeController;
        Controller.UnitController unitController;

        Controller.Result result;
        Controller.Result resultP;
        Controller.Result resultT;
        public UC_ProductWarehouse()
        {
            InitializeComponent();
        }

        private void UC_ProductWarehouse_Load(object sender, EventArgs e)
        {
            Set_Flag_All(false);
            string user = "dp1admin";
            string password = "dp1admin";
            productWarehouseController = new Controller.ProductWarehouseController(user, password);
            productController = new Controller.ProductsController(user, password);
            typeController = new Controller.ProductTypeWarehouseController(user, password);
            unitController = new Controller.UnitController(user, password);

            Load_Data();

            //Cargar los combobox - Products
            Dictionary<int, string> combo_data_products = new Dictionary<int, string>();
            combo_data_products.Add(0, "Seleccionar");
            foreach (var item in products_list)
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
            combo_data_types.Add(0, "Seleccionar");
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

        /*

        WAREHOUSE_ID
        WAREHOUSE_NAME
        PRODUCT_ID
        WAREHOUSE_CURRENT_PHYSICAL_STOCK
        WAREHOUSE_MAX_CAPACITY
        WAREHOUSE_TYPE_ID
        STATE
        WAREHOUSE_CURRENT_LOGICAL_STOCK
*/
        private void Load_Data()
        {
            result = unitController.getUnits();
            unit_list = (List<Models.UnitOfMeasure>)result.data;

            resultT = typeController.getProductTypeWarehouses();
            types_list = (List<Models.ProductTypeWarehouse>)resultT.data;

            resultP= productController.getProducts();
            products_list = (List<Models.Product>)resultP.data;

            warehouse_list = new List<Models.ProductWarehouse>();
            result = productWarehouseController.getProductWarehouses();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar almacén", MessageBoxButtons.OK);
            else warehouse_list = (List<Models.ProductWarehouse>)result.data;
        }


        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < warehouse_list.Count(); i++)
            {
                //Producto
                Models.Product product = new Models.Product();
                resultP = productController.getProduct(warehouse_list[i].Product_id);


                //Tipo
                Models.ProductTypeWarehouse type = new Models.ProductTypeWarehouse();
                resultT = typeController.getProductWarehouse(warehouse_list[i].Type_id);

                if (resultP.data == null || resultT.data == null)
                {
                    MessageBox.Show(result.message, "Error en las búsquedas de Productos o Tipos de Almacén", MessageBoxButtons.OK);
                }
                else
                {
                    // Producto
                    product = (Models.Product)resultP.data;
                    //Tipo
                    type = (Models.ProductTypeWarehouse)resultT.data;
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



        private void Clean()
        {
            ClearTextBoxes(this);
            Load_DataGridView();
            combobox_product_s.SelectedIndex = 0;
            combobox_type_s.SelectedIndex = 0;
            combobox_products.SelectedIndex = 0;
            combobox_type.SelectedIndex = 0;
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


        private Models.ProductWarehouse CreateProductWarehouse(int operacion)
        {
            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
            int id = 0;
            String name = textbox_name.Text;
            int product_id = ((KeyValuePair<int, string>)combobox_products.SelectedItem).Key;
            int physical_stock = 0;
            int max_capacity = Int32.Parse(textbox_max_capacity.Text);
            int type_id = ((KeyValuePair<int, string>)combobox_type.SelectedItem).Key;
            String state = "ACTIVE";
            int logical_stock = 0;
            Models.ProductWarehouse warehouse = new Models.ProductWarehouse();

            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            warehouse = new Models.ProductWarehouse(id,name,product_id,physical_stock,max_capacity,type_id,state,logical_stock);

            return warehouse;
        }


        private void register_Click(object sender, EventArgs e)
        {

            // validate_data(textbox_name.Text, ((KeyValuePair<int, string>)combobox_products.SelectedItem).Key,Int32.Parse(textbox_max_capacity.Text));

            Models.ProductWarehouse warehouse = CreateProductWarehouse(0);
            if (warehouse != null)
            {
                result = productWarehouseController.insertProductWarehouse(warehouse);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al registrar almacén", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Almacén agregado correctamente", "Registrar almacén", MessageBoxButtons.OK);
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
            if (metroGrid1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                cur_row = e.RowIndex;
                delete.Enabled = true;
            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Id, Nombre,Tipo,Producto,Unidad,capacidad Actual,capacidad Maxima
            cur_row = e.RowIndex;
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                for (int i = 0; i < products_list.Count(); i++)
                {
                    if (products_list[i].Name == metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString())
                    {
                        combobox_products.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < types_list.Count(); i++)
                {
                    if (types_list[i].Name == metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString())
                    {
                        combobox_type.SelectedIndex = i;
                        break;
                    }
                }

                textbox_max_capacity.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();
                Set_Flag_All(true);
                metroTabControl1.SelectedIndex = 1;
            }
        }







        private void edit_Click(object sender, EventArgs e)
        {

            Models.ProductWarehouse warehouse = CreateProductWarehouse(1);
            if (warehouse != null)
            {
                result = productWarehouseController.updateProductWarehouse(warehouse);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al modificar almacén", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Almacén editado correctamente", "Editar almacén", MessageBoxButtons.OK);
                    Load_Data();
                }
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }

            /*

            String name = textbox_name.Text;
            int id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            int product_id = ((KeyValuePair<int, string>)combobox_products.SelectedItem).Key;
            int type_id = ((KeyValuePair<int, string>)combobox_type.SelectedItem).Key;
            int max_capacity = int.Parse(textbox_max_capacity.Text);
            int i=0;
            for (i = 0; i < warehouse_list.Count(); i++) {
                if (warehouse_list[i].Id == id) {
                    break;
                } 
            }
            int physical_stock = warehouse_list[i].Current_physical_stock;
            int logical_stock = warehouse_list[i].Current_logical_stock;
            String state = warehouse_list[i].State;


            Models.ProductWarehouse warehouse = new Models.ProductWarehouse(id,name,product_id,physical_stock,max_capacity,type_id,state,logical_stock);
            result = productWarehouseController.updateProductWarehouse(warehouse);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al modificar producto", MessageBoxButtons.OK);
            }
            else
            {
                warehouse_list[i] = warehouse;
            }

            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;*/
        }

        private void search_Click(object sender, EventArgs e)
        {
            Models.ProductWarehouse warehouse = new Models.ProductWarehouse();
            warehouse.Product_id = ((KeyValuePair<int, string>)combobox_product_s.SelectedItem).Key;
            warehouse.Type_id = ((KeyValuePair<int, string>)combobox_type_s.SelectedItem).Key;
            result = productWarehouseController.getProductWarehouses(warehouse);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al buscar almacén con filtros", MessageBoxButtons.OK);
            }
            else
            {
                warehouse_list = (List<Models.ProductWarehouse>)result.data;
                Load_DataGridView();
            }

        }
        
        //-----------------------
        private void delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            result = productWarehouseController.deleteProductWarehouse(warehouse_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar almacén", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Almacén eliminado correctamente", "Eliminar almacén", MessageBoxButtons.OK);
                warehouse_list.Remove(warehouse_list[index]);
            }
            Load_DataGridView();
        }


        //Limpiar


        private void btn_clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Clean();
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        //Validaciones

        private bool Validate_Data()
        {
            if (name_flag && product_flag && type_flag && capacity_flag)
            {
                return true;
            }
            return false;
        }

        private void Set_Flag_All(bool value)
        {
            name_flag = true;
            product_flag = true;
            type_flag = true;
            capacity_flag = true;
        }

        private void Set_Flag(string name, bool value)
        {
            switch (name)
            {
                case "textbox_name":
                    name_flag = value;
                    break;
                case "combobox_products":
                    product_flag = value;
                    break;
                case "combobox_type":
                    type_flag = value;
                    break;
                case "textbox_max_capacity":
                    capacity_flag = value;
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
                int number;
                if (!Int32.TryParse(text, out number))
                {
                    Set_Flag(textbox.Name, false);
                    errorProvider.SetError(textbox, "Capacidad debe ser número");
                }
                else
                {
                    Set_Flag(textbox.Name, true);
                    errorProvider.SetError(textbox, null);
                }

            }
        }

        private void combobox_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroComboBox combobox = (MetroFramework.Controls.MetroComboBox)sender;
            int unit_id = ((KeyValuePair<int, string>)combobox.SelectedItem).Key;

            if (unit_id == 0)
            {
                Set_Flag(combobox.Name, false);
                errorProvider.SetError(combobox_unit, combobox_unit.Name);

            }
            else
            {
                Set_Flag(combobox.Name, true);
                errorProvider.SetError(combobox_unit, null);
            }
        }


    }
}
