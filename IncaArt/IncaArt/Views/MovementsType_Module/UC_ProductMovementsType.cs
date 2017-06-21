using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.MovementsType_Module
{
    public partial class UC_ProductMovementsType : ICheckPermissions
    {
        bool name_flag;
        bool class_flag;
        int cur_row;
        int operation_value;// 0 para Create, 1 para Update
        int current_class;
        List<Models.ProductMovementType> movement_type_list;
        Controller.ProductMovementTypeController movementTypeController;
        Controller.Result result;
        //Controller.ProductMovementController
        public UC_ProductMovementsType()
        {
            InitializeComponent();
        }

        private void UC_ProductMovementsType_Load(object sender, EventArgs e)
        {
            string user = "";
            string password = "";
            movementTypeController = new Controller.ProductMovementTypeController(user, password);
        }

        private void UC_ProductMovementsType_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                current_class = -1;
                metroTabControl1.SelectedIndex = 0;
                Set_Flag_All(false);
                operation_value = 0;
                Load_Data();
                Load_DataGridView();
            }
            
        }

        private void Load_Data()
        {
            Models.ProductMovementType movement= new Models.ProductMovementType();
            movement.clase = -1;
            movement.name = "";
            result = movementTypeController.getProductMovementTypes(movement);
            if (result.success)
            {
                movement_type_list = (List<Models.ProductMovementType>)result.data;
            }
            else
            {
                MessageBox.Show(result.message, "Error al listar Tipos de Movimiento de Product", MessageBoxButtons.OK);
            }
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < movement_type_list.Count(); i++)
            {
                String[] row = new String[4];
                row[0] = movement_type_list[i].id.ToString();
                row[1] = i.ToString();
                row[2] = movement_type_list[i].name;
                row[3] = getClass(movement_type_list[i].clase);
                this.metroGrid1.Rows.Add(row);
            }
        }

        private string getClass(int value)
        {
            string clase;
            switch (value)
            {
                case 0:
                    clase = "Ventas";
                    break;
                case 1:
                    clase = "Devolución";
                    break;
                case 2:
                    clase = "Producción";
                    break;
                case 3:
                    clase = "Entrada Generica";
                    break;
                case 4:
                    clase = "Salida Generica";
                    break;
                default:
                    clase = "";
                    break;
            }
            return clase;
        }

        private int getClass(String value)
        {
            int clase;
            switch (value)
            {
                case "Ventas":
                case "radio0":
                case "radio0_s":
                    clase = 0;
                    break;
                case "Devolución":
                case "radio1":
                case "radio1_s":
                    clase = 1;
                    break;
                case "Producción":
                case "radio2":
                case "radio2_s":
                    clase = 2;
                    break;
                case "Entrada Generica":
                case "radio3":
                case "radio3_s":
                    clase = 3;
                    break;
                case "Salida Generica":
                case "radio4":
                case "radio4_s":
                    clase = 4;
                    break;
                default:
                    clase = -1;
                    break;
            }
            return clase;
        }

        private char getSign(int value)
        {
            char sign;
            switch (value)
            {
                case 0:
                case 2:
                case 4:
                    sign = '-';
                    break;
                case 1:
                case 3:
                    sign = '+';
                    break;
                default:
                    sign = ' ';
                    break;
            }
            return sign;
        }

        private void Clean()
        {
            name_flag = false;
            class_flag = false;
            ClearTextBoxes(this);
            operation_value = 0;
            current_class = -1;
            radio0.Enabled = true;
            radio1.Enabled = true;
            radio2.Enabled = true;
            radio3.Enabled = true;
            radio4.Enabled = true;
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

        private bool Validate_Data()
        {
            if (name_flag && class_flag)
            {
                return true;
            }
            return false;
        }

        private void Set_Flag_All(bool value)
        {
            name_flag = value;
            class_flag = value;
        }

        private void Set_Flag(string name, bool value)
        {
            if (name == "textbox_name")
            {
                name_flag = value;
            }
        }

        private Models.ProductMovementType CreateMovementType(int operation)
        {
            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
            Models.ProductMovementType movement_type = new Models.ProductMovementType();
            movement_type.name = textbox_name.Text;
            movement_type.clase = current_class;
            movement_type.sign = getSign(current_class);
            int id = 0;
            if (operation == 1)//UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            movement_type.id = id.ToString();
            return movement_type;
        }

        private void radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            class_flag = true;
            MetroFramework.Controls.MetroRadioButton radio = (MetroFramework.Controls.MetroRadioButton)sender;
            if (radio.Checked)
            {
                current_class = getClass(radio.Name);
            }
        }

        private void textbox_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            string text = textbox.Text;

            if (String.IsNullOrWhiteSpace(text))
            {
                //e.Cancel = true;
                name_flag = false;
                errorProvider.SetError(textbox, "Campo requerido");

            }
            else
            {
                //e.Cancel = false;
                name_flag = true;
                errorProvider.SetError(textbox, null);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Models.ProductMovementType type = CreateMovementType(operation_value);
            if (type != null)
            {
                if (type.id == "0") //CREATE
                {
                    result = movementTypeController.insertProductMovementType(type);
                    if (result.success)
                    {
                        MessageBox.Show("Tipo movimiento agregado correctamente", "Registrar Tipo Movimiento Product", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Error registro de Tipo Movimiento Product", MessageBoxButtons.OK);
                    }
                }
                else //UPDATE
                {
                    result = movementTypeController.updateProductMovementType(type);
                    if (result.success)
                    {
                        MessageBox.Show("Tipo movimiento modificacion correctamente", "Registrar Tipo Movimiento Product", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Product agregado correctamente", "Error modificación de Tipo Movimiento Product", MessageBoxButtons.OK);
                    }
                }
                Set_Flag_All(false);
                Load_Data();
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
                operation_value = 0;
                radio0.Enabled = true;
                radio1.Enabled = true;
                radio2.Enabled = true;
                radio3.Enabled = true;
                radio4.Enabled = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            operation_value = 0;
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = movementTypeController.deleteProductMovementType(movement_type_list[index]);
            if (result.success)
            {
                MessageBox.Show("Tipo Movimiento Product eliminado correctamente", "Eliminar Tipo Movimiento Product", MessageBoxButtons.OK);
                Load_Data();
                btn_delete.Enabled = false;
                Load_DataGridView();
            }
            else
            {
                MessageBox.Show(result.message, "Error al eliminar Tipo Movimiento Product", MessageBoxButtons.OK);
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < movement_type_list.Count())
            {
                cur_row = e.RowIndex;
                btn_delete.Enabled = true;
            }
        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cur_row != 1 && cur_row < movement_type_list.Count())
            {
                Models.ProductMovementType type;
                result = movementTypeController.getProductMovementType(Int32.Parse(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                if (result.success)
                {
                    type = (Models.ProductMovementType)result.data;
                    textbox_name.Text = type.name;
                    switch (type.clase)
                    {
                        case 0:
                            radio0.Checked = true;
                            break;
                        case 1:
                            radio1.Checked = true;
                            break;
                        case 2:
                            radio2.Checked = true;
                            break;
                        case 3:
                            radio3.Checked = true;
                            break;
                        case 4:
                            radio4.Checked = true;
                            break;
                        default:
                            break;
                    }
                    metroTabControl1.SelectedIndex = 1;
                    operation_value = 1;
                    name_flag = true;
                    radio0.Enabled = false;
                    radio1.Enabled = false;
                    radio2.Enabled = false;
                    radio3.Enabled = false;
                    radio4.Enabled = false;
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Models.ProductMovementType type = new Models.ProductMovementType();
            type.name = textbox_name_s.Text;
            type.clase = current_class;
            result = movementTypeController.getProductMovementTypes(type);
            if (result.success)
            {
                movement_type_list = (List<Models.ProductMovementType>)result.data;
                Load_DataGridView();
            }
            else
            {
                MessageBox.Show(result.message, "Error al listar Tipo Movimiento Product", MessageBoxButtons.OK);
            }
            Clean();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
