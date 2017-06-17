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

namespace WindowsFormsApp1.Views.Reports_Module
{
    public partial class ReportDashboard : ICheckPermissions
    {
        public ReportDashboard()
        {
            InitializeComponent();            
        }

        private void MainDashboard_Load(User sessionUser)
        {
            if (!sessionUser.Profile.HasFunctionality("VIEW USERS"))
            {
                metroTile1.Visible = false;
            }

            if (!sessionUser.Profile.HasFunctionality("VIEW PROFILES"))
            {
                metroTile4.Visible = false;
            }
            if (!sessionUser.Profile.HasFunctionality("VIEW MATERIAL"))
            {
                metroTile7.Visible = false;
            }
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            UC_Ratio uc_ratio = new UC_Ratio();
            uc_ratio.Visible = true;
        }

        public override void CheckPermissions(User u)
        {
            MainDashboard_Load(u);
            Helpers.CheckPermissionsHelper.Check(this, u);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {

        }
    }
}
