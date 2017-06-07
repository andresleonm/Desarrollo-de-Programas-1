﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Views
{
    public partial class UC_ProductionOrder : UserControl
    {
        private List<Models.ProductionOrderProductLine> product_lines = new List<Models.ProductionOrderProductLine>();
        private List<Models.ProductionOrderWorkLine> work_lines = new List<Models.ProductionOrderWorkLine>();
        private List<Models.ProductionOrderMaterialLine> material_lines = new List<Models.ProductionOrderMaterialLine>();

        string user = "dp1admin";
        string password= "dp1admin";
        ProductionOrderController production_controller;
        ProductionOrderProductLineController product_line_controller;
        ProductionOrderMaterialLineController material_line_controller;
        ProductionOrderWorkLineController work_line_controller;
        public bool editing = false;

        public UC_ProductionOrder()
        {
            InitializeComponent();
            production_controller = new ProductionOrderController(user, password);
            product_line_controller = new ProductionOrderProductLineController(user, password);
            material_line_controller = new ProductionOrderMaterialLineController(user, password);
            work_line_controller = new ProductionOrderWorkLineController(user, password);
            hide_buttons();
        }
        
        private void hide_buttons()
        {
            if (!editing)
            {
                metroButton_DeleteMaterial.Visible = false;
                metroButton_DeleteProduct.Visible = false;
                metroButton_DeleteWork.Visible = false;
                metroButton_EditMaterial.Visible = false;
                metroButton_EditProduct.Visible = false;
                metroButton_EditWork.Visible = false;
            }else
            {
                metroButton_DeleteMaterial.Visible = true;
                metroButton_DeleteProduct.Visible = true;
                metroButton_DeleteWork.Visible = true;
                metroButton_EditMaterial.Visible = true;
                metroButton_EditProduct.Visible = true;
                metroButton_EditWork.Visible = true;
            }
            
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
                //Header    
                DateTime begin = metroDateTime_Begin.Value;
                DateTime end = metroDateTime_End.Value;
                string description = metroTextBox_Description.Text;
                string observations = metroTextBox_Observation.Text;
                string status="Registrado";
                int order_id;
                Models.ProductionOrder production_order = new Models.ProductionOrder(description,observations,begin,end,status);
                if (!editing)
                {
                    //INSERT
                    order_id = Int32.Parse(production_controller.insertProductionOrder(production_order).data.ToString());
                    //List of products
                    for (int i = 0; i < product_lines.Count; i++)
                    {
                        product_lines[i].Order_Id = order_id;
                        Result result = product_line_controller.insertProductLine(product_lines[i]);
                    }
                    //List of materials           
                    for (int i = 0; i < material_lines.Count; i++)
                    {
                        material_lines[i].Order_Id = order_id;
                        Result result = material_line_controller.insertMaterialLine(material_lines[i]);
                    }
                    //List of work               
                    for (int i = 0; i < work_lines.Count; i++)
                    {
                        work_lines[i].Order_Id = order_id;
                        Result result = work_line_controller.insertWorkLine(work_lines[i]);
                    }

                    MessageBox.Show("Order de producción registrada.");
                }
                else
                {                
                   
                    //UPDATE HEADER
                    Result result=production_controller.updateProductionOrder(production_order);
                    //List of products
                    for (int i = 0; i < product_lines.Count; i++)
                    {
                        if (product_lines[i].Id == 0)
                        {
                            //INSERT
                            product_lines[i].Order_Id = production_order.Id;
                            result = product_line_controller.insertProductLine(product_lines[i]);
                        }
                        else
                        {
                            //UPDATE
                            result = product_line_controller.updateProductLine(product_lines[i]);
                        }                     
                    }
                    //List of materials           
                    for (int i = 0; i < material_lines.Count; i++)
                    {
                        if (material_lines[i].Id == 0)
                        {
                            //INSERT
                            material_lines[i].Order_Id = production_order.Id;
                            result = material_line_controller.insertMaterialLine(material_lines[i]);
                        }
                        else
                        {
                            //UPDATE
                            result = material_line_controller.updateMaterialLine(material_lines[i]);
                        }
                                          
                    }
                    //List of work               
                    for (int i = 0; i < work_lines.Count; i++)
                    {
                        if (work_lines[i].Id == 0)
                        {
                            //INSERT
                            work_lines[i].Order_Id = production_order.Id;
                            result = work_line_controller.insertWorkLine(work_lines[i]);
                        }
                        else
                        {
                            //UPDATE
                            result = work_line_controller.updateWorkLine(work_lines[i]);
                        }
                    }
                    MessageBox.Show("Order de producción actualizada.");
                }
            }

            
            this.Visible = false;
            clear_Form();
            editing = false;
        }
        
        private void metroButton_AddProduct_Click(object sender, EventArgs e)
        {
            ProductionOrderProductLine product_line = new ProductionOrderProductLine();
            product_line.ShowDialog();
            if (product_line.IsRegistered)
            {
                product_lines.Add(product_line.Line);
                Load_Product_DataGridView();
            }
            
        }

        private void metroButton_AddMaterial_Click(object sender, EventArgs e)
        {
            Models.ProductionOrderMaterialLine line = new Models.ProductionOrderMaterialLine();
            Production_Module.ProductionOrderMaterialLine material_line = new Production_Module.ProductionOrderMaterialLine();
            material_line.ShowDialog();
            if (material_line.IsRegistered)
            {
                material_lines.Add(material_line.Line);
                Load_Material_DataGridView();
            }           
        }

        private void metroButton_AddWorker_Click(object sender, EventArgs e)
        {
            Models.ProductionOrderWorkLine line = new Models.ProductionOrderWorkLine();
            Production_Module.ProductionOrderWorkLine work_line = new Production_Module.ProductionOrderWorkLine();
            work_line.ShowDialog();
            if (work_line.IsRegistered)
            {
                work_lines.Add(work_line.Line);
                Load_Work_DataGridView();
            }
        }
        private void clear_Form()
        {
            datagrid_Products.Rows.Clear();
            metroGrid_Material.Rows.Clear();
            metroGrid_Work.Rows.Clear();
            product_lines.Clear();
            material_lines.Clear();
            work_lines.Clear();
            //header
            metroTextBox_OrderNumber.Text = "";
            metroTextBox_Description.Text = "";
            metroTextBox_Observation.Text = "";
            metroDateTime_Begin.Text = "";
            metroDateTime_End.Text = "";
        }
        
        private void Load_Product_DataGridView()
        {
            datagrid_Products.Rows.Clear();
            for (int i = 0; i < product_lines.Count(); i++)
            {
                if (product_lines[i].State == "Registrado") { 
                    String[] row = new String[13];
                    row[0] = "0";
                    row[1] = product_lines[i].Product_id.ToString();
                    row[2] = product_lines[i].Product_name;
                    row[3] = product_lines[i].Quantity.ToString();
                    row[4] = product_lines[i].Produced_quantity.ToString();
                    row[5] = product_lines[i].Unit_id.ToString();
                    row[6] = product_lines[i].Unit_name.ToString();
                    row[7] = product_lines[i].Recipe_id.ToString();
                    row[8] = product_lines[i].Recipe_name;
                    row[9] = product_lines[i].Warehouse_id.ToString();
                    row[10] = product_lines[i].Warehouse_name;
                    row[11] = product_lines[i].Quantity_warehouse.ToString();
                    row[12] = product_lines[i].State;

                    this.datagrid_Products.Rows.Add(row);
               }
                
             }

          }

        private void Load_Material_DataGridView()
        {
            metroGrid_Material.Rows.Clear();
            for (int i = 0; i < material_lines.Count(); i++)
            {
                if (material_lines[i].State=="Registrado") { 
                    String[] row = new String[10];
                    row[0] = "0";
                    row[1] = material_lines[i].Material_id.ToString();
                    row[2] = material_lines[i].Material_name;
                    row[3] = material_lines[i].Quantity_required.ToString();
                    row[4] = material_lines[i].Quantity_taken_real.ToString();
                    row[5] = material_lines[i].Unit_id.ToString();
                    row[6] = material_lines[i].Unit_name;
                    row[7] = material_lines[i].Warehouse_id.ToString();
                    row[8] = material_lines[i].Warehouse_name.ToString();
                    row[9] = material_lines[i].State;
                    this.metroGrid_Material.Rows.Add(row);
                }
            }

        }

        private void Load_Work_DataGridView()
        {
            metroGrid_Work.Rows.Clear();
            for (int i = 0; i < work_lines.Count(); i++)
            {
                if (work_lines[i].State == "Registrado") { 
                    String[] row = new String[15];
                    row[0] = "0";
                    row[1] = work_lines[i].Worker_id.ToString();
                    row[2] = work_lines[i].Worker_name;
                    row[3] = work_lines[i].Product_id.ToString();
                    row[4] = work_lines[i].Product_name;
                    row[5] = work_lines[i].Workstation_id.ToString();
                    row[6] = work_lines[i].Workstation_name;
                    row[7] = work_lines[i].Unit_id.ToString();
                    row[8] = work_lines[i].Unit_name;
                    row[9] = work_lines[i].Quantity_required.ToString();
                    row[10] = work_lines[i].Quantity_produced.ToString();
                    row[11] = work_lines[i].Quantity_broken.ToString();
                    row[12] = work_lines[i].Production_time.ToString();
                    row[13] = work_lines[i].Observation;
                    row[14] = work_lines[i].State;
                    this.metroGrid_Work.Rows.Add(row);
                }
            }

        }

        public void fillEditForm(int orderId)
        {
            clear_Form();

            Result result = production_controller.getProductionOrder(orderId);
            Models.ProductionOrder order = (Models.ProductionOrder)result.data;
            result=product_line_controller.getProductLines(orderId);
            if(result.success)product_lines = (List<Models.ProductionOrderProductLine>)result.data;
            result=material_line_controller.getMaterialLines(orderId);
            if (result.success) material_lines = (List<Models.ProductionOrderMaterialLine>)result.data;
            result=work_line_controller.getWorkLines(orderId);
            if (result.success) work_lines =(List<Models.ProductionOrderWorkLine>)result.data;

            //Header
            metroTextBox_OrderNumber.Text = orderId.ToString();
            metroDateTime_Begin.Text = order.Begin.Date.ToString();
            metroDateTime_End.Text = order.End.Date.ToString();
            metroTextBox_Description.Text = order.Description;
            metroTextBox_Observation.Text = order.Observation;
            //List
            Load_Product_DataGridView();
            Load_Material_DataGridView();
            Load_Work_DataGridView();
            hide_buttons();
        }

        private void UC_ProductionOrder_Load(object sender, EventArgs e)
        {

        }

        private void UC_ProductionOrder_VisibleChanged(object sender, EventArgs e)
        {
            hide_buttons();
        }

        private void datagrid_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton_Cancel_Click(object sender, EventArgs e)
        {
            editing = false;
            clear_Form();
            this.Visible = false;
        }

        private void metroButton_EditProduct_Click(object sender, EventArgs e)
        {
            int selected_index = datagrid_Products.SelectedRows[0].Index;
            ProductionOrderProductLine product_line = new ProductionOrderProductLine();
            product_line.Line = product_lines[selected_index];
            product_line.Editing = true;
            product_line.ShowDialog();
            if (product_line.IsRegistered)
            {
                product_lines[selected_index]=product_line.Line;
                Load_Product_DataGridView();
            }
        }

        private void metroButton_EditMaterial_Click(object sender, EventArgs e)
        {
            int selected_index = metroGrid_Material.SelectedRows[0].Index;
            Production_Module.ProductionOrderMaterialLine material_line = new Production_Module.ProductionOrderMaterialLine();
            material_line.Line = material_lines[selected_index];
            material_line.Editing = true;
            material_line.ShowDialog();
            if (material_line.IsRegistered)
            {
                material_lines[selected_index] = material_line.Line;
                Load_Material_DataGridView();
            }
        }

        private void metroButton_EditWork_Click(object sender, EventArgs e)
        {
            int selected_index = metroGrid_Material.SelectedRows[0].Index;
            Production_Module.ProductionOrderWorkLine work_line = new Production_Module.ProductionOrderWorkLine();
            work_line.Line = work_lines[selected_index];
            work_line.Editing = true;
            work_line.ShowDialog();
            if (work_line.IsRegistered)
            {
                work_lines[selected_index] = work_line.Line;
                Load_Work_DataGridView();
            }
        }

        private void metroButton_DeleteProduct_Click(object sender, EventArgs e)
        {
           if (datagrid_Products.SelectedRows[0] == null)
            {
                MessageBox.Show(this, "Primero debe seleccionar una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "¿Está seguro que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNoCancel);
                {
                    if (result == DialogResult.Yes)
                    {
                        int selected_index = datagrid_Products.SelectedRows[0].Index;
                        Models.ProductionOrderProductLine product_line = product_lines[selected_index];
                        product_line.State = "Eliminado";
                        Load_Product_DataGridView();
                    }
                }
            }
        }

        private void metroButton_DeleteMaterial_Click(object sender, EventArgs e)
        {
            if (metroGrid_Material.SelectedRows[0] == null)
            {
                MessageBox.Show(this, "Primero debe seleccionar una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "¿Está seguro que desea eliminar este material?", "Confirmación", MessageBoxButtons.YesNoCancel);
                {
                    if (result == DialogResult.Yes)
                    {
                        int selected_index = metroGrid_Material.SelectedRows[0].Index;
                        Models.ProductionOrderMaterialLine material_line = material_lines[selected_index];
                        material_line.State = "Eliminado";
                        Load_Material_DataGridView();
                    }
                }
            }
        }

        private void metroButton_DeleteWork_Click(object sender, EventArgs e)
        {
            if (metroGrid_Work.SelectedRows[0] == null)
            {
                MessageBox.Show(this, "Primero debe seleccionar una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "¿Está seguro que desea eliminar esta notificación de trabajo?", "Confirmación", MessageBoxButtons.YesNoCancel);
                {
                    if (result == DialogResult.Yes)
                    {
                        int selected_index = metroGrid_Work.SelectedRows[0].Index;
                        Models.ProductionOrderWorkLine work_line = work_lines[selected_index];
                        work_line.State = "Eliminado";
                        Load_Work_DataGridView();
                    }
                }
            }
        }
    }
}
