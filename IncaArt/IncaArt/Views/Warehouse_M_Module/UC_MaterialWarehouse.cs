using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views.Warehouse_M_Module
{
    public partial class UC_MaterialWarehouse : ICheckPermissions
    {
        int cur_row;
        bool name_flag;
        bool product_flag;
        bool type_flag;
        bool capacity_flag;

        User sessionUser;
        bool deletedTab = false;
        //Models.User sessionUser;

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


        Models.MaterialWarehouse curWarehouse;
        public UC_MaterialWarehouse()
        {
            InitializeComponent();
        }

        private void UC_MaterialWarehouse_Load(object sender, EventArgs e)
        {

        }

        public override void CheckPermissions(User user)
        {
            sessionUser = user;
            UC_MaterialWarehouse_Load();
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
            if (!result.success) MessageBox.Show(result.message, "Error al listar almacén", MessageBoxButtons.OK);
            else warehouse_list = (List<Models.MaterialWarehouse>)result.data;

            //Cargar los combobox - Products
            Dictionary<int, string> combo_data_materials = new Dictionary<int, string>();
            combo_data_materials.Add(0, "Seleccionar");
            foreach (var item in materials_list)
            {
                combo_data_materials.Add(item.Id, item.Name);
            }

            combobox_products.DataSource = new BindingSource(combo_data_materials, null);
            combobox_products.DisplayMember = "Value";
            combobox_products.ValueMember = "Key";

            combobox_product_s.DataSource = new BindingSource(combo_data_materials, null);
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

        }


        private void Load_DataGridView()
        {
            Models.Material material = new Models.Material();
            Models.MaterialTypeWarehouse type = new Models.MaterialTypeWarehouse();
            Models.UnitOfMeasure unit = new Models.UnitOfMeasure();

            metroGrid1.Rows.Clear();
            for (int i = 0; i < warehouse_list.Count(); i++)
            {
                material = materials_list.Find(u => u.Id == warehouse_list[i].Material_id);
                type = types_list.Find(u => u.Id == warehouse_list[i].Type_id);
                //User user_to_delete = user_list.Find(u => u.Id == Int32.Parse(metroGrid1.CurrentRow.Cells[0].Value.ToString()));

                /*
                //Producto
                Models.Product product = new Models.Product();
                resultP = productController.getProduct(warehouse_list[i].Product_id);


                //Tipo
                Models.ProductTypeWarehouse type = new Models.ProductTypeWarehouse();
                resultT = typeController.getProductWarehouse(warehouse_list[i].Type_id);
                (resultP.data == null || resultT.data == null
                */
                if (material == null || type == null)
                {
                    MessageBox.Show("Error en transacción","Error en las búsquedas de Materiales o Tipos de Almacén", MessageBoxButtons.OK);
                }
                else
                {
                    /*
                    // Producto
                    product = (Models.Product)resultP.data;
                    //Tipo
                    type = (Models.ProductTypeWarehouse)resultT.data;*/
                    //Unidad

                    unit = unit_list.Find(u => u.Id == material.Unit_id);

                    //Grilla
                    String[] row = new String[9];
                    row[0] = warehouse_list[i].Id.ToString();
                    row[1] = i.ToString();
                    row[2] = warehouse_list[i].Name;
                    row[3] = type.Name;
                    row[4] = material.Name;
                    row[5] = unit.Symbol;
                    row[6] = warehouse_list[i].Current_physical_stock.ToString();
                    row[7] = warehouse_list[i].Max_capacity.ToString();
                    row[8] = warehouse_list[i].State;

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

            if (!deletedTab)
            {
                combobox_products.SelectedIndex = 0;
                combobox_type.SelectedIndex = 0;
            }
        }



        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }



                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }


        private Models.MaterialWarehouse CreateMaterialWarehouse(int operacion)
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
            Models.MaterialWarehouse warehouse = new Models.MaterialWarehouse();

            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            warehouse = new Models.MaterialWarehouse(id, name, product_id, physical_stock, max_capacity, type_id, state, logical_stock);

            return warehouse;
        }

        private void register_Click(object sender, EventArgs e)
        {
            Models.MaterialWarehouse warehouse;
            string message = " ";

            if (curWarehouse != null)
            {
                warehouse = CreateMaterialWarehouse(1);
                if (warehouse != null)
                {
                    result = materialWarehouseController.updateMaterialWarehouse(warehouse);
                    message = "Almacén editado correctamente";
                }
            }
            else
            {
                warehouse = CreateMaterialWarehouse(0);
                if (warehouse != null)
                {
                    result = materialWarehouseController.insertMaterialWarehouse(warehouse);
                    message = "Almacén agregado correctamente";
                }
            }

            if (result.success && result.data != null)
            {
                MessageBox.Show(message, "Registro", MessageBoxButtons.OK);
                Set_Flag_All(false);
                Clean();
                Load_Data();
                Load_DataGridView();
                metroTabControl1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(result.message, "Error en la transacción", MessageBoxButtons.OK);
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
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
                textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                for (int i = 0; i < materials_list.Count(); i++)
                {
                    if (materials_list[i].Name == metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString())
                    {
                        combobox_products.SelectedIndex = i + 1;
                        break;
                    }
                }

                for (int i = 0; i < types_list.Count(); i++)
                {
                    if (types_list[i].Name == metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString())
                    {
                        combobox_type.SelectedIndex = i + 1;
                        break;
                    }
                }

                textbox_max_capacity.Text = metroGrid1.Rows[e.RowIndex].Cells[7].Value.ToString();
                Set_Flag_All(true);
                register.Text = "Editar";
                register.Visible = true;
                metroTabControl1.SelectedIndex = 1;
                if (!sessionUser.Profile.HasFunctionality("EDIT MATERIAL WAREHOUSE"))
                {
                    register.Visible = false;
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Models.MaterialWarehouse warehouse = CreateMaterialWarehouse(1);
            if (warehouse != null)
            {
                result = materialWarehouseController.updateMaterialWarehouse(warehouse);
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
        }

        private void search_Click(object sender, EventArgs e)
        {
            Models.MaterialWarehouse warehouse = new Models.MaterialWarehouse();
            warehouse.Material_id = ((KeyValuePair<int, string>)combobox_product_s.SelectedItem).Key;
            warehouse.Type_id = ((KeyValuePair<int, string>)combobox_type_s.SelectedItem).Key;
            warehouse.Name = textbox_name_s.Text;
            result = materialWarehouseController.getMaterialWarehouses(warehouse);
            if (!result.success)
            {
                MessageBox.Show(result.message, "Error al buscar almacén con filtros", MessageBoxButtons.OK);
            }
            else
            {
                warehouse_list = (List<Models.MaterialWarehouse>)result.data;
                Load_DataGridView();
            }
        }

        private void tabIndex_Enter(object sender, EventArgs e)
        {
            if (!deletedTab) Clean();
            register.Text = "Guardar";
            register.Visible = true;
            curWarehouse = null;
            /*
                if (!sessionUser.Profile.HasFunctionality("CREATE MATERIAL WAREHOUSE"))
                {
                    register.Visible = false;
                }*/
            
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
                MessageBox.Show("Almacén eliminado correctamente", "Eliminar almacén", MessageBoxButtons.OK);
                warehouse_list.Remove(warehouse_list[index]);
            }
            Load_DataGridView();
        }
   




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

        private bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                if (x < 0) return false;
                return true;
            }
            catch (Exception)
            {
                return false;
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
                if (!IsNumeric(text))
                {
                    Set_Flag(textbox.Name, false);
                    errorProvider.SetError(textbox, "Capacidad debe ser número positivo");
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
                errorProvider.SetError(combobox,"Seleccionar una opción válida");

            }
            else
            {
                Set_Flag(combobox.Name, true);
                errorProvider.SetError(combobox, null);
            }
        }

        private void put_unit(object sender, EventArgs e)
        {
           
            if (combobox_products.SelectedIndex !=0) {
                int id = ((KeyValuePair<int, string>)combobox_products.SelectedItem).Key;
                Models.Material material = materials_list.Find(u => u.Id == id);
                textbox_unit.Text = id.ToString();
                if (material != null)
                {
                    Models.UnitOfMeasure unit = unit_list.Find(u => u.Id == material.Unit_id);
                    textbox_unit.Text = unit.Symbol;
                }
            }
        }

        // Excel Prueba
        private partial class MaterialWarehouseError //Clase temporal para manejo de Excel con filas con errores
        {
            public List<string> error_list;
            public List<string> string_list;
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Excel |*.xlsx;*.xls";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openDialog.FileName, "Ventana", MessageBoxButtons.OK);
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                if (excel == null)
                {
                    Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                    return;
                }
                Workbook wb = excel.Workbooks.Open(openDialog.FileName);
                Worksheet ws = (Worksheet)wb.Worksheets[1];
                Range range = ws.UsedRange;
                int row_count = range.Rows.Count;
                int column_count = range.Columns.Count;
                Range datarange;
                string name = "", material = "", typewarehouse = "";
                int capacity = -1;
                double number;
                bool error; //error individual
                List<string> error_list, string_list; //para hacer control de cada error de fila

                Models.MaterialWarehouse warehouse;
                int material_id, type_id, success_lines = 0, error_lines = 0;
                List<MaterialWarehouseError> materialwarehouse_error_list = new List<MaterialWarehouseError>(); //Lista de almacenes para el Excel con error
                //En Interop Excel el indice comienza en 1

                for (int i = 3; i <= row_count; i++) //Fila 3 comienza las filas de Almacenes
                {
                    error = false;
                    MaterialWarehouseError materialwarehouse_error = new MaterialWarehouseError();
                    error_list = new List<string>();
                    string_list = new List<string>();
                    material_id = -1;
                    type_id = -1;
                    datarange = (Range)ws.Cells[i, 1];//Nombre Almacén
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("name");
                    }
                    else
                    {
                        name = (string)datarange.Value2;
                    }
                    datarange = (Range)ws.Cells[i, 2];//Material
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("material");
                    }
                    else
                    {
                        material = (string)datarange.Value2;
                        foreach (var item in materials_list)
                        {
                            if (item.Name.Equals(material))
                            {
                                material_id = item.Id;
                                break;
                            }
                        }
                        if (material_id == -1)
                        {
                            error = true;
                            error_list.Add("material_find");
                        }
                    }

                    datarange = (Range)ws.Cells[i, 3];//Tipo Almacén
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("typewarehouse");
                    }
                    else
                    {
                        typewarehouse = (string)datarange.Value2;
                        foreach (var item in types_list)
                        {
                            if (item.Name.ToUpper().Equals(typewarehouse.ToUpper()))
                            {
                                type_id = item.Id;
                                break;
                            }
                        }
                        if (type_id == -1)
                        {
                            error = true;
                            error_list.Add("typewarehouse_find");
                        }
                    }


                    datarange = (Range)ws.Cells[i, 4];//Capacidad Máxima
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number) || (int)datarange.Value2 < 0)
                    {
                        error = true;
                        error_list.Add("capacity");
                    }
                    else
                    {
                        capacity = (int)datarange.Value2;
                    }

                    if (error)//Si hay error entonces, se agrega a la lista de productwarehouse error
                    {
                        materialwarehouse_error.error_list = error_list;
                        materialwarehouse_error.string_list = string_list;
                        materialwarehouse_error_list.Add(materialwarehouse_error);
                        error_lines++;
                    }
                    else
                    {
                        warehouse = new Models.MaterialWarehouse();
                        warehouse.Name = name;
                        warehouse.Material_id = Convert.ToInt32(material_id);
                        warehouse.Type_id = Convert.ToInt32(type_id);
                        warehouse.State = "ACTIVE";
                        warehouse.Max_capacity = Convert.ToInt32(capacity);

                        materialWarehouseController.insertMaterialWarehouse(warehouse);
                        if (result.data == null)
                        {
                            MessageBox.Show("Error en registro de almacén");
                            error = true;
                            error_list.Add("register");
                            error_lines++;
                        }
                        else
                        {
                            success_lines++;
                        }
                    }
                }
                MessageBox.Show("Lineas correctas: " + success_lines + "\n" + "Lineas inccorrectas: " + error_lines, "Resultado de importación desde Excel", MessageBoxButtons.OK);
                if (materialwarehouse_error_list.Count > 0) //Hubo por lo menos una fila con error
                {
                    CreateExcelError(materialwarehouse_error_list);
                }
            }
            openDialog.Dispose();
        }

        private void CreateExcelError(List<MaterialWarehouseError> list)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            if (excel == null)
            {
                Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                return;
            }
            excel.Visible = true;

            Workbook wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            ws.Name = "Almacenes";
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }

            ws.Range["A1"].Value2 = "Lista de Almacenes con Error";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "Material";
            ws.Range["C2"].Value2 = "Tipo de Almacén";
            ws.Range["D2"].Value2 = "Capacidad";
            ws.Range["E2"].Value2 = "Observaciones";
            string observation;
            MaterialWarehouseError materialwarehouse_error;
            for (int i = 0; i < list.Count(); i++)
            {
                observation = "";
                materialwarehouse_error = list[i];
                for (int j = 0; j < list[i].string_list.Count(); j++)//Se pone los datos del almacen escrito
                {
                    ((Range)ws.Cells[i + 3, j + 1]).Value2 = materialwarehouse_error.string_list[j];
                }
                foreach (var item in materialwarehouse_error.error_list)
                {
                    switch (item)
                    {
                        case "name":
                            observation += "Nombre inválido. ";
                            break;
                        case "material":
                            observation += "Material inválido. ";
                            break;
                        case "material_find":
                            observation += "Material no encontrado. ";
                            break;
                        case "typewarehouse":
                            observation += "Tipo Almacén inválido. ";
                            break;
                        case "typewarehouse_find":
                            observation += "Tipo Almacén no encontrado. ";
                            break;
                        case "capacity":
                            observation += "Capacidad inválida. ";
                            break;
                        default:
                        case "register":
                            observation += "Error en registro";
                            break;
                    }
                }
                ((Range)ws.Cells[i + 3, 5]).Value2 = observation;
            }
            ws.Columns.AutoFit();
        }

        private void btn_template_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            if (excel == null)
            {
                Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                return;
            }
            excel.Visible = true;

            Workbook wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            ws.Name = "Almacenes";
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }
            ws.Range["A1"].Value2 = "Lista de Almacenes";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "Material";
            ws.Range["C2"].Value2 = "Tipo Almacén";
            ws.Range["D2"].Value2 = "Capacidad";
            ws.Columns.AutoFit();
        }




        //Permissions
        private void UC_MaterialWarehouse_Load()
        {
            if (!sessionUser.Profile.HasFunctionality("DELETE MATERIAL WAREHOUSE"))
            {
                delete.Visible = false;
            }

            if (!sessionUser.Profile.HasFunctionality("CREATE MATERIAL WAREHOUSE") && !sessionUser.Profile.HasFunctionality("EDIT MATERIAL WAREHOUSE"))
            {
                deletedTab = true;
                this.metroTabControl1.TabPages.Remove(registerTab);

            }
        }



        private void UC_MaterialWarehouse_VisibleChanged(object sender, EventArgs e)
        {
            Set_Flag_All(false);
            string user = "dp1admin";
            string password = "dp1admin";
            materialWarehouseController = new Controller.MaterialWarehouseController(user, password);
            materialController = new Controller.MaterialsController(user, password);
            typeController = new Controller.MaterialTypeWarehouseController(user, password);
            unitController = new Controller.UnitController(user, password);
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

    }
}
