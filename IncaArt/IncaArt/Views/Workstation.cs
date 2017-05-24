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
    public partial class Workstation : UserControl
    {
        public Workstation()
        {
            InitializeComponent();
        }


        private bool validate_data(string name, string product, string quantity, string description)
        {
            bool isCorrect = true;
            String message = "";
            int i;

            if (name == "")
            {
                isCorrect = false;
                message += "- Debe seleccionar un producto.\n";
            }
            if (product == "")
            {
                isCorrect = false;
                message += "- Debe seleccionar un material.\n";
            }
            if (quantity == "")
            {
                isCorrect = false;
                message += "- Debe ingresar una cantidad.\n";
            }
            if (!Int32.TryParse(quantity, out i))
            {
                isCorrect = false;
                message += "- La cantidad ingresada no es válida.\n";
            }
            if (description == "")
            {
                isCorrect = false;
                message += "- Debe ingresar una descripcion.\n";
            }


            if (!isCorrect)
            {
                MessageBox.Show(message, "Error al registrar el puesto de trabajo", MessageBoxButtons.OK);
            }

            return isCorrect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = richTextBoxDescription.Text;
            string quantity_str = textBoxQuantity.Text;
            string product_name = comboBoxProduct.Text;

            if (validate_data(name, product_name, quantity_str, description))
            {
                int quantity = Int32.Parse(quantity_str);
            }
        }
    }
}
