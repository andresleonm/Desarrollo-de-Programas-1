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
using MetroFramework.Controls;

namespace WindowsFormsApp1.Views
{
    public partial class MainDashboard : ICheckPermissions
    {
        public MainDashboard()
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
            if (!sessionUser.Profile.HasFunctionality("VIEW PRODUCT"))
            {
                metroTile6.Visible = false;
            }
            if (!sessionUser.Profile.HasFunctionality("VIEW RECIPE"))
            {
                metroTile5.Visible = false;
            }
            if (!sessionUser.Profile.HasFunctionality("VIEW WORKSTATION"))
            {
                metroTile8.Visible = false;
            }
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            UC_Ratio uc_ratio = new UC_Ratio();
            uc_ratio.Visible = true;
        }

        private void ReorderTiles()
        {
            int x0 = 26;
            int y0 = 102;
            int deltaX = 221;
            int deltaY = 101;
            int added = 0;
            int tilesPerRow = 4;
            int hidden = 0;


            for (int i = (Controls.Count - 1); i >= 0; i--)
            {
                Control c = Controls[i];

                if (c is MetroTile)
                {
                    MetroTile t = (MetroTile)c;

                    if (t.Visible)
                    {
                        int xLoc = x0 + (added % tilesPerRow) * deltaX;
                        int yLoc = y0 + (added / tilesPerRow) * deltaY;

                        t.Location = new Point(xLoc, yLoc);
                        added++;
                    }
                }
            }
        }

        public override void CheckPermissions(User u)
        {
            MainDashboard_Load(u);
            Helpers.CheckPermissionsHelper.Check(this, u);
        }

        private void MainDashboard_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                ReorderTiles();
            }
        }
    }
}
