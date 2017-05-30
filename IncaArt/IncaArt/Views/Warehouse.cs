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
    public partial class Warehouse : MetroFramework.Controls.MetroUserControl
    {
        List<UC_Product> products = new List<UC_Product>();
        List<UC_Material2> materials = new List<UC_Material2>();
        List<Warehouse> warehouses = new List<Warehouse>();

        Controller.SupplierController supplierController;
        Controller.Result result;
        List<Models.Supplier> supplier_list;

        public Warehouse()
        {
            InitializeComponent();
            this.Style = mStyle.Style;
        }

        private bool validate_data(String name,String type,int m_capacity,int a_capacity,String u1,String u2)
        {
            bool isCorrect = true;
            String message = "";
            if (name == "") {
                isCorrect = false;
                message += "- Debe ingresar el nombre del almacén.\n";
            }
            if (type == "") {
                isCorrect = false;
                message += "- Debe seleccionar el producto/material del almacén. \n";
            }

            if (m_capacity < 0 || a_capacity < 0) {
                isCorrect = false;
                message += "- Las capacidades deben ser valores positivos. \n";
            }

            if (a_capacity > m_capacity) {
                isCorrect = false;
                message += "- La capacidad actual supera la máxima capacidad. \n";
            }
            MessageBox.Show(message, "Error al registrar un nuevo almacén", MessageBoxButtons.OK);
            return isCorrect;
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            mStyle.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void newA_Click(object sender, EventArgs e)
        {
            

            
/*
            String nameWarehouse = name.Text;
            String typeWarehouse = type.Text;

            int m_capacity = Int32.Parse(max_capacity.Text);
            int a_capacity = Int32.Parse(actual_capacity.Text);

            String u1 = unity1.Text;
            String u2 = unity1.Text;

            bool isValid =validate_data(nameWarehouse, typeWarehouse, m_capacity, a_capacity, u1, u2);
            if (isValid) {
                
            }*/
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void combobox_obtener_Click(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            supplierController = new Controller.SupplierController(user, password);
            supplier_list = new List<Models.Supplier>();
            result = supplierController.getSuppliers();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar material", MessageBoxButtons.OK);
            else supplier_list = (List < Models.Supplier>)result.data;

            for (int i = 0; i < supplier_list.Count(); i++) {
                MessageBox.Show(supplier_list[i].Name);
            }

        }
    }
}
