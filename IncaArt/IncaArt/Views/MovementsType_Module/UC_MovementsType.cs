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

namespace WindowsFormsApp1.Views.MovementsType_Module
{
    public partial class UC_MovementsType : ICheckPermissions
    {
        Models.User sessionUser;
        public UC_MovementsType()
        {
            InitializeComponent();
        }

        private void UC_MovementsType_Load(object sender, EventArgs e)
        {
            uC_ProductMovementsType1.Visible = true;
            uC_MaterialMovementsType1.Visible = false;
        }

        private void select_products_Click(object sender, EventArgs e)
        {
            uC_ProductMovementsType1.Visible = true;
            uC_MaterialMovementsType1.Visible = false;
        }

        private void select_materials_Click(object sender, EventArgs e)
        {
            uC_MaterialMovementsType1.Visible = true;
            uC_ProductMovementsType1.Visible = false;
        }

        public override void CheckPermissions(User u)
        {
            sessionUser = u;
            Permissions();
        }

        private void Permissions()
        {
            if (!sessionUser.Profile.HasFunctionality("VIEW MATERIAL MOVEMENT TYPE"))
            {
                select_materials.Visible = false;
            }
            if (!sessionUser.Profile.HasFunctionality("VIEW PRODUCT MOVEMENT TYPE"))
            {
                select_products.Visible = false;
            }
        }
    }
}
