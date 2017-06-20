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
    public partial class TypeWarehouseMain:ICheckPermissions
    {
        public TypeWarehouseMain()
        {
            InitializeComponent();
            uC_ProductTypeWarehouse1.Visible = true;
            uC_MaterialTypeWarehouse1.Visible = false;
           
           
        }

        private void TypeWarehouseMain_Load(object sender, EventArgs e)
        {

        }

        private void select_products_Click(object sender, EventArgs e)
        {
            uC_ProductTypeWarehouse1.Visible = true;
            uC_MaterialTypeWarehouse1.Visible = false;
        }

        private void select_materials_Click(object sender, EventArgs e)
        {
            uC_MaterialTypeWarehouse1.Visible = true;
            uC_ProductTypeWarehouse1.Visible = false;
        }


    }
}
