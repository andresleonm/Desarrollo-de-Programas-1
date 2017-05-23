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
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }
        private bool validate_data(string name) {
            bool isCorrect = true;
            string message = "";
            if (name == "")
            {
                isCorrect = false;
                message = "-Debe ingresar el nombre del perfil.\n";
            }
            if (dataGridView_Permissions.SelectedRows.Count == 0)
            {
                isCorrect = false;
                message += "-Debe seleccionar como mínimo un permiso para el perfil.";
            }
            if (!isCorrect)
                MessageBox.Show(message, "Error al registrar un nuevo perfil", MessageBoxButtons.OK);
            return isCorrect;
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            String name = textBox_Name.Text;
            if (validate_data(name)) {
                 
            }
        }
    }
}
