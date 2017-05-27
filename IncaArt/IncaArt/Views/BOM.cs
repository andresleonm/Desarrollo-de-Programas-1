using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class BOM : UserControl
    {
        //private int last_id;
        //private List<Models.BOM> models_list;


        public BOM()
        {
            InitializeComponent();
        }


        private bool validate_data(string product, string material, string quantity)
        {
            bool isCorrect = true;
            String message = "";
            int i;

            if (product == "")
            {
                isCorrect = false;
                message += "- Debe seleccionar un producto.\n";
            }
            if (material == "")
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


            if (!isCorrect)
            {
                MessageBox.Show(message, "Error al registrar receta", MessageBoxButtons.OK);
            }

            return isCorrect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string product_name = comboBoxProduct.Text;
            string material_name = comboBoxMaterial.Text;
            string quantity_str = textBoxQuantity.Text;

            if(validate_data(product_name, material_name, quantity_str))
            {
                int quantity = Int32.Parse(quantity_str);
            }
        }
    }
}
