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
    public partial class Parameters : MetroFramework.Controls.MetroUserControl
    {
        bool name_flag;
        bool value_flag;

        List<Models.Parameters> parameters_list;
        List<Models.Parameters> parameters_list_init;
        Controller.ParametersController parameterController;
        int cur_row;
        Controller.Result result;
        public Parameters()
        {
            InitializeComponent();
        }

        private void Parameters_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            parameterController = new Controller.ParametersController(user, password);
            Set_Flag_All(false);
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;

        }

        private void Load_Data()
        {
            result = parameterController.getParameters();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar parámetros", MessageBoxButtons.OK);
            else parameters_list = (List<Models.Parameters>)result.data;
        }


        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < parameters_list.Count(); i++)
            {
                    String[] row = new String[6];
                    row[0] = parameters_list[i].Id.ToString();
                    row[1] = parameters_list[i].Name;
                    row[2] = parameters_list[i].Value;
                    row[3] = parameters_list[i].State;
                    this.metroGrid1.Rows.Add(row);
            }
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

        private Models.Parameters CreateParameter(int operacion)
        {
            int id=0;
            String name, value,state;

            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
            name = textbox_name.Text;
            value = textbox_value.Text;
            state = "ACTIVE";
            Models.Parameters param = new Models.Parameters();

            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            param = new Models.Parameters(id, name, value,state);

            return param;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Models.Parameters param = new Models.Parameters();
            param.Name = textbox_name_s.Text;
            if (!String.IsNullOrWhiteSpace(param.Name)) {
                result = parameterController.getParameters(param);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al buscar parámetro con filtros", MessageBoxButtons.OK);
                }
                else
                {
                    parameters_list = (List<Models.Parameters>)result.data;
                    Load_DataGridView();
                }
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            Models.Parameters param = CreateParameter(0);
            if (param != null)
            {
                result = parameterController.insertParameter(param);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al registrar parámetro", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Parámetro registrado correctamente", "Registrar material", MessageBoxButtons.OK);
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
                btn_delete.Enabled = true;
            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cur_row = e.RowIndex;
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textbox_value.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                metroTabControl1.SelectedIndex = 1;
                Set_Flag_All(true);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Models.Parameters param = CreateParameter(1);
            if (param != null)
            {
                result = parameterController.updateParameter(param);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al modificar parámetro", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Parámetro editado correctamente", "Editar parámetro", MessageBoxButtons.OK);
                    Load_Data();
                }
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = parameterController.deleteParameter(parameters_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar parámetro", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Parámetro eliminado correctamente", "Eliminar material", MessageBoxButtons.OK);
                Load_Data();
            }
            btn_delete.Enabled = false;
            Load_DataGridView();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Clean();
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
            
        }
        // Validate Data 

        private bool Validate_Data()
        {
            if (name_flag && name_flag && value_flag)
            {
                return true;
            }
            return false;
        }

        private void Set_Flag_All(bool value)
        {
            name_flag = value;
            value_flag = value;
        }

        private void Set_Flag(string name, bool value)
        {
            switch (name)
            {
                case "textbox_name":
                    name_flag = value;
                    break;
                case "textbox_value":
                    value_flag = value;
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
    }
}
