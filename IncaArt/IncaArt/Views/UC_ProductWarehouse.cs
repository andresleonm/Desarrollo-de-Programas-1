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
        //List<Models.UnitOfMeasure> unit_list;
        List<Models.ProductTypeWarehouse> type_list;
        List<Models.Product> products_list;

        Controller.ProductWarehouseController warehouseController;
        Controller.ProductsController productsController;
        //Controller.UnitController unitController;
        Controller.ProductTypeWarehouseController typeController;
        

        Controller.Result result;

        public UC_ProductWarehouse()
        {
            InitializeComponent();
        }

        private void UC_ProductWarehouse_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            warehouseController = new Controller.ProductWarehouseController(user, password);
            productsController = new Controller.ProductsController(user, password);
            //unitController = new Controller.UnitController(user, password);
            typeController = new Controller.ProductTypeWarehouseController(user, password);
            warehouse_list = new List<Models.ProductWarehouse>();
            Load_Data();

            /*Cargar Combobox*/
            Dictionary<int, string> combo_products = new Dictionary<int, string>();
            foreach (var item in products_list)
            {
                combo_products.Add(item.Id, item.Name);
            }

            Dictionary<int, string> combo_types = new Dictionary<int, string>();
            foreach (var item in type_list)
            {
                combo_types.Add(item.Id, item.Name);
            }


            /*Pantalla - Registro*/
            combobox_products.DataSource = new BindingSource(combo_products,null);
            combobox_products.DisplayMember = "Value";
            combobox_products.ValueMember = "Key";
            
            combobox_types.DataSource = new BindingSource(combo_types, null);
            combobox_types.DisplayMember = "Value";
            combobox_types.ValueMember = "Key";

            /*combobox_unit.DataSource = new BindingSource(combo_data, null);
            combobox_unit.DisplayMember = "Value";
            combobox_unit.ValueMember = "Key";
            combobox_unit_s.DataSource = new BindingSource(combo_data, null);
            combobox_unit_s.DisplayMember = "Value";
            combobox_unit_s.ValueMember = "Key";*/

            //Load_DataGridView();
            //metroTabControl1.SelectedIndex = 0;
        }


        private void Load_Data()
        {
           // result = unitController.getUnits();
            //unit_list = (List<Models.UnitOfMeasure>)result.data;

            result = typeController.getProductTypeWarehouses();
            type_list = (List<Models.ProductTypeWarehouse>)result.data;

            result = typeController.getProductTypeWarehouses();
            products_list = (List<Models.Product>)result.data;

            warehouse_list = new List<Models.ProductWarehouse>();
            result = warehouseController.getProductWarehouses();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar almacenes", MessageBoxButtons.OK);
            else warehouse_list = (List<Models.ProductWarehouse>)result.data;
        }

        private bool validate_data(String name, String type, int m_capacity, int a_capacity, String u1, String u2)
        {
            bool isCorrect = true;
            String message = "";
            if (name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el nombre del almacén.\n";
            }
            if (type == "")
            {
                isCorrect = false;
                message += "- Debe seleccionar el producto/material del almacén. \n";
            }

            if (m_capacity < 0 || a_capacity < 0)
            {
                isCorrect = false;
                message += "- Las capacidades deben ser valores positivos. \n";
            }

            if (a_capacity > m_capacity)
            {
                isCorrect = false;
                message += "- La capacidad actual supera la máxima capacidad. \n";
            }
            MessageBox.Show(message, "Error al registrar un nuevo almacén", MessageBoxButtons.OK);
            return isCorrect;
        }

        /*
        private Models.ProductWarehouse CreateProductWarehouse(int operacion)
        {
            String name, state;
            int id, product_id, type_id, max_capacity, physical_stock, logical_stock;

            id = 0;
            name = textbox_name.Text;
            product_id = ((KeyValuePair<int, string>)combobox_products.SelectedItem).Key;
            type_id = ((KeyValuePair<int, string>)combobox_types.SelectedItem).Key;
            max_capacity=int.Parse(textbox_max_capacity.Text);
            state = "ACTIVE";
            physical_stock = 0;
            logical_stock  = 0;
            
            
            /*
            
            Models.Material mat = new Models.Material();

            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            Models.ProductWarehouse warehouse = new Models.ProductWarehouse(id,name,product_id,physical_stock,max_capacity,);
            mat = new Models.Material(id, unit_id, name, min_stock, max_stock);

            return mat;
        }
    */


        private void metroTabPage8_Click(object sender, EventArgs e)
        {

        }
    }
}
