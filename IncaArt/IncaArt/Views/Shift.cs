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
    public partial class Shift : UserControl
    {
        public Shift()
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
            string name = textBox_Description.Text;
            DateTimePicker begin = dateTimePicker_Begin;
            DateTimePicker end = dateTimePicker_End;
            if (validate_data(name, begin, end)) {

            }

        }
    }
}
