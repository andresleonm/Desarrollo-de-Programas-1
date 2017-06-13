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
    public partial class UC_Shift : UserControl
    {

        bool description_flag;
        bool begin_flag;
        bool end_flag;

        List<Models.Shift> shifts_list;
        Controller.ShiftsController shiftsController;
        int cur_row;
        Controller.Result result;

        Models.Shift curShift;

        public UC_Shift()
        {
            InitializeComponent();
        }

        private bool validate_data(string name, DateTimePicker begin, DateTimePicker end) {
            bool isCorrect = true;
            string message = "";
            if (name == "")
            {
                isCorrect = false;
                message = "-Debe ingresar el nombre del turno.\n";
            }
            if(begin.Value.TimeOfDay>=end.Value.TimeOfDay)
            {
                isCorrect = false;
                message += "-La hora de inicio debe ser menor que la hora de fin.";
            }
            if (!isCorrect)
                MessageBox.Show(message,"Error al registrar un nuevo turno",MessageBoxButtons.OK);
            return isCorrect;
        }

        private void button_New_Click(object sender, EventArgs e)
        {

            /*string name = textBox_Description.Text;
            DateTimePicker begin = dateTimePicker_Begin;
            DateTimePicker end = dateTimePicker_End;
            if (validate_data(name, begin, end)) {

            }*/

        }

        private void UC_Shift_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            shiftsController = new Controller.ShiftsController(user, password);
            Set_Flag_All(false);
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {
            result = shiftsController.getShifts();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar horarios", MessageBoxButtons.OK);
            else shifts_list = (List<Models.Shift>)result.data;
        }


        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < shifts_list.Count(); i++)
            {
                String[] row = new String[6];
                row[0] = shifts_list[i].Id.ToString();
                row[1] = i.ToString();
                row[2] = shifts_list[i].Description;
                row[3] = shifts_list[i].Begin_date.ToString();
                row[4] = shifts_list[i].End_date.ToString();
                row[5] = shifts_list[i].State;
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

        private Models.Shift CreateShift(int operacion)
        {
            int id = 0;
            String name, state;
            DateTime begin, end;
            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
            name = textbox_name.Text;
            begin = time_begin.Value.Date;
            end = time_end.Value.Date;
            state = "ACTIVE";
            Models.Shift shift = new Models.Shift();

            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            shift = new Models.Shift(id, name, begin,end, state);

            return shift;
        }

        private void search_Click(object sender, EventArgs e)
        {

            Models.Shift shift = new Models.Shift();
            shift.Description = textbox_name_s.Text;
            shift.Begin_date = time_begin_s.Value.Date;
            shift.End_date = time_end_s.Value.Date;

            result = shiftsController.getShifts(shift);
            if (!result.success)
            {
                MessageBox.Show(result.message, "Error al buscar horarios con filtros", MessageBoxButtons.OK);
            }
            else
            {
                shifts_list = (List<Models.Shift>)result.data;
                Load_DataGridView();
            }
        }

        private void tabIndex_Enter(object sender, EventArgs e)
        {
            Clean();
            register.Text = "Guardar";
            curShift = null;
        }





        private void register_Click(object sender, EventArgs e)
        {
            Models.Shift shift;
            string message = " ";

            if (curShift != null)
            {
                shift = CreateShift(1);
                if (shift != null)
                {
                    result = shiftsController.updateShift(shift);
                    message = "Horario editado correctamente";
                }
            }
            else
            {
                shift = CreateShift(0);
                if (shift != null)
                {
                    result = shiftsController.insertShift(shift);
                    message = "Horario agregado correctamente";
                }
            }

            if (result.success)
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
                int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
                curShift = shifts_list[index];
                textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                time_begin.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
                time_end.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                metroTabControl1.SelectedIndex = 1;
                register.Text = "Editar";
                Set_Flag_All(true);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = shiftsController.deleteShift(shifts_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar horario", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Horario eliminado correctamente", "Eliminar horario", MessageBoxButtons.OK);
                Load_Data();
            }
            btn_delete.Enabled = false;
            Load_DataGridView();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        //Cancel
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clean();
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        // Validate Data 

        private bool Validate_Data()
        {
            if (description_flag && begin_flag && end_flag)
            {
                return true;
            }
            return false;
        }

        private void Set_Flag_All(bool value)
        {
            description_flag = value;
            begin_flag = value;
            end_flag = value;
        }

        private void Set_Flag(string name, bool value)
        {
            switch (name)
            {
                case "textbox_name":
                    description_flag = value;
                    break;
                case "time_begin":
                    begin_flag = value;
                    break;
                case "time_end":
                    end_flag = value;
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
