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
    public partial class UC_Product : UserControl
    {
        public UC_Product()
        {
            InitializeComponent();
        }
        private bool validate_data(string name)
        {
            bool isCorrect = true;
            string message = "";
            double numberDouble;
            Int32 numberInt;

            if (name == "")
            {
                isCorrect = false;
                message = "-Debe ingresar el nombre del producto.\n";
            }
            if (comboBox_UnitMeasure.SelectedItem== null) {
                isCorrect = false;
                message += "-Debe seleccionar la unidad de medida del producto.\n";
            }
            if (textBox_Price.Text == "") {
                isCorrect = false;
                message += "-Debe ingresar el precio del producto.\n";
            }else if (!Double.TryParse(textBox_Price.Text,out numberDouble)) {
                isCorrect = false;
                message += "-Debe ingresar un número válido en el precio del producto.\n";
            }
            if (comboBox_Currency.SelectedItem == null) {
                isCorrect = false;
                message += "-Debe seleccionar la moneda correspondiente al precio del producto.\n";
            }
            if (textBox_StockMin.Text == "")
            {
                isCorrect = false;
                message += "-Debe ingresar el stock mínimo del producto.\n";
            }
            else if (!Int32.TryParse(textBox_StockMin.Text, out numberInt))
            {
                isCorrect = false;
                message += "-Debe ingresar un número válido para el stock mínimo del producto.\n";
            }
            if (textBox_StockMax.Text == "")
            {
                isCorrect = false;
                message += "-Debe ingresar el stock máximo del producto.\n";
            }
            else if (!Int32.TryParse(textBox_StockMax.Text, out numberInt))
            {
                isCorrect = false;
                message += "-Debe ingresar un número válido para el stock máximo del producto.\n";
            }

            if(!isCorrect)
                MessageBox.Show(message, "Error al registrar un nuevo perfil", MessageBoxButtons.OK);
            return isCorrect;
        }
        private void button_New_Click(object sender, EventArgs e)
        {
            String name = textBox_Name.Text;
            if (validate_data(name)) { 
            
                    }
            
        }

        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_StockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_StockMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
