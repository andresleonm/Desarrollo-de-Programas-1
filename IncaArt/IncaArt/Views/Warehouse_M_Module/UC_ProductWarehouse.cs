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
            string user = "dp1admin";
            string password = "dp1admin";
            productWarehouseController = new Controller.ProductWarehouseController(user, password);
            productController = new Controller.ProductsController(user, password);
            typeController = new Controller.ProductTypeWarehouseController(user, password);
            unitController = new Controller.UnitController(user, password);

            Load_Data();

            //Cargar los combobox - Products
            Dictionary<int, string> combo_data_products = new Dictionary<int, string>();
            foreach (var item in products_list)
            {
                combo_data_products.Add(item.Id, item.Name);
            }

            combobox_products.DataSource = new BindingSource(combo_data_products, null);
            combobox_unit.DisplayMember = "Value";
            combobox_unit.ValueMember = "Key";

            //Cargar los combobox - Types
            Dictionary<int, string> combo_data_types = new Dictionary<int, string>();
            foreach (var item in types_list)
            {
                combo_data_types.Add(item.Id, item.Name);
            }

            combobox_type.DataSource = new BindingSource(combo_data_types, null);
            combobox_unit.DisplayMember = "Value";
            combobox_unit.ValueMember = "Key";

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

            Models.ProductWarehouse warehouse = new Models.ProductWarehouse(id, name, product_id, physical_stock, max_capacity, type_id, state, logical_stock);
            result = productWarehouseController.insertProductWarehouse(warehouse);
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
                resultT= typeController.getProductWarehouse(warehouse_list[i].Type_id);

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


        private void edit_Click(object sender, EventArgs e)
        {
            /*
            String name = textbox_name.Text;
            int id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            int unit_id = ((KeyValuePair<int, string>)combobox_unit.SelectedItem).Key;
            int stock_min, stock_max;
            stock_min = int.Parse(textbox_stock_min.Text);
            stock_max = int.Parse(textbox_stock_max.Text);
            double price = double.Parse(textbox_price.Text);
            Models.Product product = new Models.Product(id, unit_id, name, stock_min, stock_max, price);
            result = productController.updateProduct(product);
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
            metroTabControl1.SelectedIndex = 0;*/
        }

        private void Cancel_Click(object sender, EventArgs e)
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
            /*
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
            }*/
        }
    }
}
