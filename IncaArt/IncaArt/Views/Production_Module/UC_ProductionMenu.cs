﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views.Production_Module
{
    public partial class UC_ProductionMenu : ICheckPermissions
    {
        User sessionUser;
        public UC_ProductionMenu()
        {
            InitializeComponent();
        }

        private void metroTile_RegisterOrder_Click(object sender, EventArgs e)
        {
            production_register.Visible = true;
            production_search.Visible = false;
        }

        private void metroTitle_SearchOrder_Click(object sender, EventArgs e)
        {
            production_register.Visible = false;
            production_search.Visible = true;
        }

        private void UC_ProductionMenu_Load()
        {
            if (!sessionUser.Profile.HasFunctionality("REGISTER PRODUCTION ORDER"))
            {
                metroTile_RegisterOrder.Visible = false;
            }
        }

        public override void CheckPermissions(User u)
        {
            sessionUser = u;
            UC_ProductionMenu_Load();
        }

        private void metroTile_WorkerPerformance_Click(object sender, EventArgs e)
        {
            production_register.Visible = false;
            production_search.Visible = false;
        }
    }
}
