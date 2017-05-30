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
    public partial class UC_ProductionOrder : UserControl
    {
        private List<Models.ProductionOrderProductLine> product_lines = new List<Models.ProductionOrderProductLine>();
        private List<Models.ProductionOrderWorkLine> work_lines = new List<Models.ProductionOrderWorkLine>();
        private List<Models.ProductionOrderMaterialLine> material_lines = new List<Models.ProductionOrderMaterialLine>();
         
        public UC_ProductionOrder()
        {
            InitializeComponent();
        }
        
        private bool validate_data()
        {
            bool isCorrect = true;

            return isCorrect;
        }

        private void metroButton_Register_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                int numOrder = Int32.Parse(metroTextBox_OrderNumber.Text);
                DateTime begin = metroDateTime_Begin.Value;
                DateTime end = metroDateTime_End.Value;
                string description = metroTextBox_Description.Text;
                string observations = metroTextBox_Observation.Text;
                string status = "Created";
                Models.ProductionOrder productionOrder = new Models.ProductionOrder(description,observations,begin,end,status); 

            }
        }

        private void metroButton_AddProduct_Click(object sender, EventArgs e)
        {
            ProductionOrderProductLine product_line = new ProductionOrderProductLine();
            product_line.Show();
            if (product_line.IsRegistered)
            {
                product_lines.Add(product_line.Line);
            }
            Load_Product_DataGridView();
        }

        private void metroButton_AddMaterial_Click(object sender, EventArgs e)
        {
            Models.ProductionOrderMaterialLine line = new Models.ProductionOrderMaterialLine();
            Production_Module.ProductionOrderMaterialLine material_line = new Production_Module.ProductionOrderMaterialLine();
            material_line.Show();
            if (material_line.IsRegistered)
            {
                material_lines.Add(material_line.Line);
            }
        }

        private void metroButton_AddWorker_Click(object sender, EventArgs e)
        {
            Models.ProductionOrderWorkLine line = new Models.ProductionOrderWorkLine();
            Production_Module.ProductionOrderWorkLine work_line = new Production_Module.ProductionOrderWorkLine();
            work_line.Show();
        }

        private void Load_Product_DataGridView()
        {
            datagrid_Products.Rows.Clear();
            for (int i = 0; i < product_lines.Count(); i++)
            {
                String[] row = new String[6];
                row[0] = product_lines[i].Product.Name;
                row[1] = product_lines[i].Quantity.ToString();
                row[2] = product_lines[i].Produced_quantity.ToString();
                row[3] = product_lines[i].Product.Unit.Name;
                row[4] = product_lines[i].Recipe.Name;
                row[5] = product_lines[i].Warehouse.Name;
                row[5] = product_lines[i].Quantity_warehouse.ToString();
                this.datagrid_Products.Rows.Add(row);
             }

            }
        



    }
}
