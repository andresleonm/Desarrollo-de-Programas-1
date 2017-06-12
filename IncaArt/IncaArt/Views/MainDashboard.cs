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
    public partial class MainDashboard : UserControl
    {
        public MainDashboard()
        {
            InitializeComponent();            
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            User sessionUser = ((Dashboard)Parent).sessionUser;

            if (!sessionUser.Profile.HasFunctionality("VIEW USERS"))
            {
                metroTile1.Visible = false;
            }

            if (!sessionUser.Profile.HasFunctionality("VIEW PROFILES"))
            {
                metroTile4.Visible = false;
            }
        }
    }
}
