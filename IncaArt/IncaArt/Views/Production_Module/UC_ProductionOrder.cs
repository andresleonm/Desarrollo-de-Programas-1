using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class UC_ProductionOrder : UserControl
    {
        
        private List<Models.ProductionOrderWorkLine> work_lines = new List<Models.ProductionOrderWorkLine>();
        private List<Models.ProductionOrderMaterialLine> material_lines = new List<Models.ProductionOrderMaterialLine>();
        //Resumen
        private Dictionary<int,int> product_summary_lines =new Dictionary<int,int>();
        private List<Models.ProductionOrderMaterialLine> material_summary_lines = new List<Models.ProductionOrderMaterialLine>();
        private List<Workstation> workstations = new List<Workstation>();
        string user = "dp1admin";
        string password= "dp1admin";
        ProductionOrderController production_controller;
        ProductionOrderProductLineController product_line_controller;
        ProductionOrderMaterialLineController material_line_controller;
        ProductionOrderWorkLineController work_line_controller;
        RecipesController recipe_controller;
        WorkstationsController workstation_controller;
        MaterialsController material_controller;
        UnitController unit_controller;
        ProductsController product_controller;
        ProductMovementDetailController product_movement_controller;
        ProductWarehouseController warehouse_controller;

        public bool editing = false;
        //validate
        bool flag_description = false;
        bool flag_begin = true;
        bool flag_end = true;
        bool flag_product = false;
        bool flag_quantity = false;

        public UC_ProductionOrder()
        {
            InitializeComponent();
           
            production_controller = new ProductionOrderController(user, password);
            product_line_controller = new ProductionOrderProductLineController(user, password);
            material_line_controller = new ProductionOrderMaterialLineController(user, password);
            work_line_controller = new ProductionOrderWorkLineController(user, password);
            recipe_controller = new RecipesController(user,password);
            workstation_controller = new WorkstationsController(user,password);
            material_controller = new MaterialsController(user,password);
            unit_controller = new UnitController(user,password);
            product_controller = new ProductsController(user,password);
            product_movement_controller = new ProductMovementDetailController(user,password);
            warehouse_controller = new ProductWarehouseController(user,password);
        }

        private bool validate_data()
        {
            bool isCorrect = true;

            validate_textbox(metroTextBox_Description);
            validate_begin_datetime(metroDateTime_Begin);
            validate_end_datetime(metroDateTime_End);
            validate_comboBox(comboBox_Product);
            validate_textbox_quantity(metroTextBox_Quantity);
            if (!flag_description ||!flag_begin||!flag_end||!flag_product||!flag_quantity)
            {
                MessageBox.Show("Hay campos inválidos en los datos de la orden de producción.","Error en el registro",MessageBoxButtons.OK);
                isCorrect = false;
            }       
            return isCorrect;
        }
        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                //Header    
                DateTime begin = metroDateTime_Begin.Value;
                DateTime end = metroDateTime_End.Value;
                string description = metroTextBox_Description.Text;
                string observations = metroTextBox_Observation.Text;
                string state = "Registrado";
                int order_id;
                string message = "";
                //Product
                Product product = (Product)comboBox_Product.SelectedItem;
                string unit_name = label_Unit.Text;
                int quantity = Int32.Parse(metroTextBox_Quantity.Text);
                int produced_quantity = Int32.Parse(metroTextBox_Quantity_produced.Text);
                int quantity_warehouse = Int32.Parse(metroTextBox_Quantity_warehouse.Text);
                ProductWarehouse warehouse = (ProductWarehouse)comboBox_Warehouse.SelectedItem;
                Recipe recipe = (Recipe)comboBox_Recipe.SelectedItem;
                int estimate_id;
                int estimate_line;

                if (metroTextBox_Estimate.Text != "")
                {
                    estimate_id = Int32.Parse(metroTextBox_Estimate.Text);
                    estimate_line = Int32.Parse(metroTextBox_Estimate_line.Text);
                }
                else
                {
                    estimate_id = 0;
                    estimate_line = 0;
                }

                Models.ProductionOrder production_order = new Models.ProductionOrder(description, observations, begin, end, state, product.Id,
                    product.Name, product.Unit_id, unit_name, quantity, produced_quantity, warehouse.Id, warehouse.Name, recipe.Id, recipe.Name, quantity_warehouse,
                    estimate_id, estimate_line);
                if (!editing)
                {
                    //INSERT
                    Result result = production_controller.insertProductionOrder(production_order);
                    if (result.success)
                    {
                        order_id = Int32.Parse(result.data.ToString());

                        //List of materials           
                        for (int i = 0; i < material_lines.Count; i++)
                        {
                            if (material_lines[i].State != "Anulado")
                            {
                                material_lines[i].Order_Id = order_id;
                                result = material_line_controller.insertMaterialLine(material_lines[i]);
                                if (!result.success) message += "-" + material_lines[i].Warehouse_name + ":" + result.message + "\n";
                            }
                        }
                        //List of work               
                        for (int i = 0; i < work_lines.Count; i++)
                        {
                            if (work_lines[i].State != "Anulado")
                            {
                                work_lines[i].Order_Id = order_id;
                                result = work_line_controller.insertWorkLine(work_lines[i]);
                                if (!result.success) message += "-" + result.message + "\n";
                            }
                        }

                        MessageBox.Show("Order de producción registrada.");
                    }
                    else { message += "-" + result.message + "\n"; }
                }
                else
                {
                    production_order.Id = Int32.Parse(this.metroTextBox_OrderNumber.Text);
                    //UPDATE HEADER
                    Result result = production_controller.updateProductionOrder(production_order);
                    if (!result.success) message += "-" + result.message + "\n";
                    else
                    {

                        //List of materials           
                        for (int i = 0; i < material_lines.Count; i++)
                        {
                            if (material_lines[i].Id == 0)
                            {
                                //INSERT
                                material_lines[i].Order_Id = production_order.Id;
                                result = material_line_controller.insertMaterialLine(material_lines[i]);
                                if (!result.success) message += "-" + material_lines[i].Warehouse_name + ":" + result.message + "\n";
                            }
                            else
                            {
                                //UPDATE
                                result = material_line_controller.updateMaterialLine(material_lines[i]);
                                if (!result.success) message += "-" + material_lines[i].Warehouse_name + ":" + result.message + "\n";
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
                                if (!result.success) message += "-" + result.message + "\n";
                            }
                            else
                            {
                                //UPDATE
                                result = work_line_controller.updateWorkLine(work_lines[i]);
                                if (!result.success) message += "-" + result.message + "\n";
                            }
                        }
                        MessageBox.Show("Order de producción actualizada.");
                    }
                }
                if (message != "")
                    MessageBox.Show(message, "Errores en el registro", MessageBoxButtons.OK);
                this.Visible = false;
                clear_Form();
                editing = false;
            }
        }

      
        private void metroButton_AddMaterial_Click(object sender, EventArgs e)
        {
            if (comboBox_Recipe.SelectedIndex != -1){
                Production_Module.ProductionOrderMaterialLine material_line = new Production_Module.ProductionOrderMaterialLine();
                material_line.IdRecipe = ((Recipe)(comboBox_Recipe.SelectedItem)).Id;
                material_line.ShowDialog();
                if (material_line.IsRegistered)
                {
                    material_lines.Add(material_line.Line);
                    Load_Material_DataGridView();
                }
            }
            else{
                MessageBox.Show(this, "Seleccione primero la receta que se utilizará en la orden de producción.", "Registro de material", MessageBoxButtons.OK);
            }
            
        }

        private void metroButton_AddWorker_Click(object sender, EventArgs e)
        {
            if (comboBox_Product.SelectedIndex != -1){
                Production_Module.ProductionOrderWorkLine work_line = new Production_Module.ProductionOrderWorkLine();
                work_line.Product = (Product)comboBox_Product.SelectedItem;
                work_line.ShowDialog();
                if (work_line.IsRegistered)
                {
                    work_lines.Add(work_line.Line);
                    Load_Work_DataGridView();
                }
                update_SummaryProduct();
            }
            else {
                MessageBox.Show(this, "Seleccione primero el producto de la orden de producción.", "Registro de notificación de trabajo", MessageBoxButtons.OK);
            }
        }
        private void clear_Form()
        {
            
            metroGrid_Material.Rows.Clear();
            metroGrid_Work.Rows.Clear();
            material_lines.Clear();
            work_lines.Clear();
            product_summary_lines.Clear();
            material_summary_lines.Clear();
            metroGrid_materials_summary.Rows.Clear();
            metroGrid_products_summary.Rows.Clear();
                
            //header
            metroTextBox_OrderNumber.Text = "";
            metroTextBox_Description.Text = "";
            metroTextBox_Observation.Text = "";
            metroDateTime_Begin.Text = "";
            metroDateTime_End.Text = "";
            metroTextBox_Estimate.Text = "";
            metroTextBox_Estimate_line.Text = "";

            metroLabel_estimate.Visible = true;
            metroTextBox_Estimate.Visible = true;
            metroLabel_Estimate_line.Visible = true;
            metroTextBox_Estimate_line.Visible = true;
            //product
            Load_Product();
            comboBox_Product.Enabled = true;
            comboBox_Warehouse.Enabled = true;
            errorProvider.SetError(metroTextBox_Description,null);
            errorProvider.SetError(comboBox_Product, null);
            errorProvider.SetError(metroTextBox_Quantity, null);
            errorProvider.SetError(metroDateTime_Begin, null);
            errorProvider.SetError(metroDateTime_End, null);
        }
        
        private void Load_Product()
        {
            Result result = product_controller.getProducts_withWarehouses();
            if (result.success)
            {
                comboBox_Product.DataSource = (List<Product>)result.data;
                comboBox_Product.DisplayMember = "name";
                comboBox_Product.SelectedIndex = -1;
                metroTextBox_Quantity_produced.Text = "0";
                metroTextBox_Quantity_warehouse.Text = "0";
                metroTextBox_Quantity.Text = "0";
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
                    String[] row = new String[13];
                    row[0] = "0";
                    row[1] = work_lines[i].Worker_id.ToString();
                    row[2] = work_lines[i].Worker_name;
                    row[3] = work_lines[i].Workstation_id.ToString();
                    row[4] = work_lines[i].Workstation_name;
                    row[5] = work_lines[i].Unit_id.ToString();
                    row[6] = work_lines[i].Unit_name;
                    row[7] = work_lines[i].Quantity_required.ToString();
                    row[8] = work_lines[i].Quantity_produced.ToString();
                    row[9] = work_lines[i].Quantity_broken.ToString();
                    int minute = (int)(work_lines[i].Production_time) % 60;
                    int hour = (int)(work_lines[i].Production_time) / 60;
                    //row[12] = work_lines[i].Production_time.ToString();
                    row[10] = hour.ToString() + "h " + minute.ToString() + "min";
                    row[11] = work_lines[i].Observation;
                    row[12] = work_lines[i].State;
                    this.metroGrid_Work.Rows.Add(row);
                }
            }

        }

        public void fillEditForm(int orderId)
        {
            clear_Form();

            Result result = production_controller.getProductionOrder(orderId);
            Models.ProductionOrder order = (Models.ProductionOrder)result.data;
            
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
            //Estimate
            if (order.Estimate_id != 0)
            {
                metroTextBox_Estimate.Text = order.Estimate_id.ToString();
                metroTextBox_Estimate.ReadOnly = true;

                metroTextBox_Estimate_line.Text = order.Estimate_line.ToString();
                metroTextBox_Estimate_line.ReadOnly = true;
            }else
            {
                metroLabel_estimate.Visible = false;
                metroTextBox_Estimate.Visible = false;
                metroLabel_Estimate_line.Visible = false;
                metroTextBox_Estimate_line.Visible = false;
            }
            //Product
            comboBox_Product.Text = order.Product_name;
            comboBox_Product.Enabled = false;
            comboBox_Warehouse.Enabled = false;
            metroTextBox_Quantity.Text = order.Quantity.ToString();
            metroTextBox_Quantity_produced.Text = order.Produced_quantity.ToString();
            comboBox_Recipe.Text = order.Recipe_name;
            comboBox_Warehouse.Text = order.Warehouse_name;
            metroTextBox_Quantity_warehouse.Text = order.Quantity_warehouse.ToString();
            label_Unit.Text = order.Unit_name;
            label_Unit3.Text = order.Unit_name;
            label_Unit2.Text = order.Unit_name;

            //List
            Load_Material_DataGridView();
            Load_Work_DataGridView();
            update_SummaryMaterial();
            update_SummaryProduct();

            flag_description = true;
            flag_product = true;
            flag_quantity = true;
            

        }

        private void UC_ProductionOrder_Load(object sender, EventArgs e)
        {
            
        }

        private void UC_ProductionOrder_VisibleChanged(object sender, EventArgs e)
        {          
            if (!Visible)
            {
                UC_ProductionOrderSearch uc_productionOrderSearch = (UC_ProductionOrderSearch)(this.Parent.Controls.Find("production_search", false)[0]);
                uc_productionOrderSearch.Visible = true;
            }
        }

        private void metroButton_Cancel_Click(object sender, EventArgs e)
        {
            editing = false;
            clear_Form();
            this.Visible = false;
        }


        private void metroButton_EditMaterial_Click(object sender, EventArgs e)
        {
            if (metroGrid_Material.Rows.Count > 0)
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
           
        }

        private void metroButton_EditWork_Click(object sender, EventArgs e)
        {
            if (metroGrid_Work.Rows.Count > 0)
            {
                if (metroGrid_Work.SelectedRows[0] == null)
                {
                    MessageBox.Show(this, "Primero debe seleccionar una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int selected_index = metroGrid_Work.SelectedRows[0].Index;
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
            }
            update_SummaryProduct();

        }
      
        private void metroButton_DeleteMaterial_Click(object sender, EventArgs e)
        {
            if (metroGrid_Material.Rows.Count > 0)
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
                            material_line.State = "Anulado";
                            Load_Material_DataGridView();
                        }
                    }
                }
            }
        }

        private void metroButton_DeleteWork_Click(object sender, EventArgs e)
        {
            if (metroGrid_Work.Rows.Count > 0)
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
                            work_line.State = "Anulado";
                            Load_Work_DataGridView();
                        }
                    }
                    update_SummaryProduct();
                }
            }
        }

      

        //Summary
        private void update_SummaryProduct()
        {
            if(comboBox_Product.SelectedIndex != -1)
            {
                calculate_products_summary();
                Load_SummaryProduct_DataGridView();
                
            }else
            {
                product_summary_lines.Clear();
                Load_SummaryProduct_DataGridView();
            }
            
        }
        private void update_SummaryMaterial()
        {
            int quantity=0;
            if (metroTextBox_Quantity.Text != "")
            {
                quantity = Int32.Parse(metroTextBox_Quantity.Text);
            }
            if((quantity>0) && (comboBox_Product.SelectedIndex != -1) && (comboBox_Recipe.SelectedIndex != -1))
            {
                calculate_materials_summary();
                Load_SummaryMaterial_DataGridView();
            }else
            {
                material_summary_lines.Clear();
                Load_SummaryMaterial_DataGridView();
            }           
        }


        private void Load_SummaryProduct_DataGridView()
        {
            metroGrid_products_summary.Rows.Clear();

            foreach(KeyValuePair<int,int>k in product_summary_lines)
            {
                String[] row = new String[3];
                row[0] = workstations.Find(w=>w.Id==k.Key).Name;                  
                row[1] = k.Value.ToString();
                row[2] = label_Unit.Text;                               
                    
                this.metroGrid_products_summary.Rows.Add(row);
            }
        }
        private void Load_SummaryMaterial_DataGridView()
        {
            metroGrid_materials_summary.Rows.Clear();
            for (int i = 0; i < material_summary_lines.Count(); i++)
            {
                String[] row = new String[3];      
                row[0] = material_summary_lines[i].Material_name;
                row[1] = material_summary_lines[i].Quantity_required.ToString();   
                row[2] = material_summary_lines[i].Unit_name;
            
                this.metroGrid_materials_summary.Rows.Add(row);
            }
        }

        public void calculate_products_summary()
        {
            product_summary_lines.Clear();
            Product product = (Product)comboBox_Product.SelectedItem;
            Workstation workstation = new Workstation();
            workstation.Product_id = product.Id;

            Result result = workstation_controller.getWorkstations(workstation);
            if (result.success)
            {
                workstations = (List<Workstation>)result.data;

                foreach (Workstation w in workstations)
                {
                    product_summary_lines.Add(w.Id,0);
                    foreach (Models.ProductionOrderWorkLine work_line in work_lines)
                    {
                        if (work_line.Workstation_id==w.Id)
                        {
                            product_summary_lines[w.Id] += work_line.Quantity_produced;
                        }
                    }
                    if (w.Next_workstation == 0){
                        metroTextBox_Quantity_produced.Text = product_summary_lines[w.Id].ToString();
                    }
                }
            }          
        }

        public void calculate_materials_summary()
        {
            Product product = (Product)comboBox_Product.SelectedItem;
            int quantity = Int32.Parse(metroTextBox_Quantity.Text);
            if (product != null)
            {
                material_summary_lines.Clear();
                List<Models.Material> materials = (List<Models.Material>)material_controller.getMaterials().data;
                List<Models.UnitOfMeasure> units = (List<Models.UnitOfMeasure>)unit_controller.getUnits().data;

                //Detalle de receta del producto
                Recipe recipe = (Recipe)comboBox_Recipe.SelectedItem;
                List<RecipeDetail> recipe_details = (List<Models.RecipeDetail>)recipe_controller.getRecipeDetails(recipe.Id).data;
                //Por cada ingrediente de la receta
                foreach (Models.RecipeDetail detail in recipe_details)
                {
                    int index = material_summary_lines.FindIndex(m => m.Material_id == detail.Material_id);
                    if (index == -1) //No se encuentra
                    {
                        Models.Material material_found = materials.Find(m => m.Id == detail.Material_id);
                        Models.ProductionOrderMaterialLine new_line = new Models.ProductionOrderMaterialLine();
                        new_line.Material_id = material_found.Id;
                        new_line.Material_name = material_found.Name;
                        new_line.Quantity_required = detail.Quantity * quantity;
                        new_line.Unit_id = material_found.Unit_id;
                        new_line.Unit_name = units.Find(u => u.Id == material_found.Unit_id).Name;
                        material_summary_lines.Add(new_line);
                    }
                    else
                    {
                        material_summary_lines[index].Quantity_required += detail.Quantity * quantity;
                    }

                }

            }

        }

        //Validaciones
        private void validate_textbox_quantity(MetroFramework.Controls.MetroTextBox textbox)
        {
            string text = textbox.Text;
            int num;
            if (String.IsNullOrWhiteSpace(text))
            {
                flag_quantity = false;
                errorProvider.SetError(textbox, "Campo requerido");
            }
            else if (!Int32.TryParse(text, out num) || num <= 0)
            {
                if (num == 0 && textbox.Name == "metroTextBox_quantity_produced")
                {
                    flag_quantity = true;
                    errorProvider.SetError(textbox, null);
                }
                else {
                    flag_quantity = false;
                    errorProvider.SetError(textbox, "La cantidad debe ser mayor que cero.");
                }

            }
            else
            {
                flag_quantity = true;
                errorProvider.SetError(textbox, null);
            }
        }


        private void validate_comboBox(System.Windows.Forms.ComboBox combobox)
        {
            int index = combobox.SelectedIndex;
            if (index == -1)
            {
                flag_product=false;
                errorProvider.SetError(combobox, "Campo requerido");

            }
            else
            {
                flag_product = true;
                errorProvider.SetError(combobox, null);
            }
        }

        private void validate_textbox(MetroFramework.Controls.MetroTextBox textbox)
        {
            string text = textbox.Text;
            if (String.IsNullOrWhiteSpace(text))
            {
                flag_description = false;
                errorProvider.SetError(textbox, "Campo requerido");
            }
            else
            {
                flag_description = true;
                errorProvider.SetError(textbox, null);
            }
        }

        private void validate_begin_datetime(MetroFramework.Controls.MetroDateTime date_time) {
            DateTime end = metroDateTime_End.Value.Date;
            if (date_time.Value.Date > end)
            {
                flag_begin = false;
                errorProvider.SetError(date_time, "La fecha de inicio debe ser menor o igual que la de fin.");
            }
            else if (!editing && date_time.Value.Date < DateTime.Now.Date)
            {
                flag_begin = false;
                errorProvider.SetError(date_time, "La fecha de inicio debe ser mayor a la fecha actual");
            }
            else {
                flag_begin = true;
                errorProvider.SetError(date_time, null);
            }
        }

        private void validate_end_datetime(MetroFramework.Controls.MetroDateTime date_time) {
            DateTime begin = metroDateTime_Begin.Value.Date;
            if (date_time.Value.Date < begin)
            {
                flag_end = false;
                errorProvider.SetError(date_time, "La fecha de fin debe ser mayor o igual que la de inicio.");
            }
            else
            {
                flag_end = true;
                errorProvider.SetError(date_time, null);
            }
        }
        
        private void metroTextBox_Description_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            validate_textbox(textbox);
        }

        private void metroDateTime_Begin_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroDateTime date_time = (MetroFramework.Controls.MetroDateTime)sender;
            validate_begin_datetime(date_time);
        }

        private void metroDateTime_End_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroDateTime date_time = (MetroFramework.Controls.MetroDateTime)sender;
            validate_end_datetime(date_time);
        }

        private void comboBox_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Product.SelectedIndex != -1)
            {
                int product_id = ((Product)comboBox_Product.SelectedItem).Id;

                Result result = product_movement_controller.getWarehouses(product_id);
                comboBox_Warehouse.DataSource = null;
                comboBox_Warehouse.DataSource = (List<Warehouse_Module.ProductWarehouseM>)result.data;
                comboBox_Warehouse.DisplayMember = "name";
                //validate_comboBox(comboBox_Warehouse);

                Recipe recipe = new Recipe();
                recipe.Product_id = product_id;
                result = recipe_controller.getRecipes(recipe);
                comboBox_Recipe.DataSource = null;
                comboBox_Recipe.DataSource = (List<Recipe>)result.data;
                comboBox_Recipe.DisplayMember = "name";
                //validate_comboBox(comboBox_Recipe);

                UnitOfMeasure unit = (UnitOfMeasure)unit_controller.getUnit(((Product)comboBox_Product.SelectedItem).Unit_id).data;

                label_Unit.Text = unit.Name;
                label_Unit2.Text = unit.Name;
                label_Unit3.Text = unit.Name;
                
            }else
            {
                Result result = warehouse_controller.getProductWarehouses();
                comboBox_Warehouse.DataSource = null;
                comboBox_Warehouse.DataSource = (List<ProductWarehouse>)result.data;
                comboBox_Warehouse.DisplayMember = "name";
                comboBox_Warehouse.SelectedIndex = -1;
                

                Recipe recipe = new Recipe();
                
                result = recipe_controller.getRecipes();
                comboBox_Recipe.DataSource = null;
                comboBox_Recipe.DataSource = (List<Recipe>)result.data;
                comboBox_Recipe.DisplayMember = "name";
                comboBox_Recipe.SelectedIndex = -1;             

                label_Unit.Text = "";
                label_Unit2.Text = "";
                label_Unit3.Text = "";
            }
            update_SummaryProduct();
            update_SummaryMaterial();
        }

        private void comboBox_Recipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_SummaryMaterial();
        }

        private void metroTextBox_Quantity_TextChanged(object sender, EventArgs e)
        {
            update_SummaryMaterial();
        }

        private void metroTextBox_Estimate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void metroTextBox_Estimate_line_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void metroTextBox_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void metroTextBox_Quantity_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            validate_textbox_quantity(textbox);
        }

        private void comboBox_Product_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox combobox=(System.Windows.Forms.ComboBox)sender;
            validate_comboBox(combobox);
        }
    }
}
