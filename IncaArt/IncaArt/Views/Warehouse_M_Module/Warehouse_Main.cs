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
    public partial class Warehouse : ICheckPermissions
    {

        public Warehouse()
        {
            InitializeComponent();
          //  this.Style = mStyle.Style;
            uC_ProductWarehouse1.Visible = true;
            uC_MaterialWarehouse1.Visible = false;

        }

        private bool validate_data(String name,String type,int m_capacity,int a_capacity,String u1,String u2)
        {
            bool isCorrect = true;
            String message = "";
            if (name == "") {
                isCorrect = false;
                message += "- Debe ingresar el nombre del almacén.\n";
            }
            if (type == "") {
                isCorrect = false;
                message += "- Debe seleccionar el producto/material del almacén. \n";
            }

            if (m_capacity < 0 || a_capacity < 0) {
                isCorrect = false;
                message += "- Las capacidades deben ser valores positivos. \n";
            }

            if (a_capacity > m_capacity) {
                isCorrect = false;
                message += "- La capacidad actual supera la máxima capacidad. \n";
            }
            MessageBox.Show(message, "Error al registrar un nuevo almacén", MessageBoxButtons.OK);
            return isCorrect;
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            //mStyle.Style = MetroFramework.MetroColorStyle.Silver;
        }


        private void select_products_Click(object sender, EventArgs e)
        {
            uC_ProductWarehouse1.Visible = true;
            uC_MaterialWarehouse1.Visible = false;
         }

        private void select_materials_Click(object sender, EventArgs e)
        {
            uC_MaterialWarehouse1.Visible = true;
            uC_ProductWarehouse1.Visible = false;
        }


        public override void CheckPermissions(User user)
        {
            Helpers.CheckPermissionsHelper.Check(this, user);
        }

    }
}
