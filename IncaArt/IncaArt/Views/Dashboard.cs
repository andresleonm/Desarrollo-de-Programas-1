using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class Dashboard : Form
    {
        public string userName = "dp1";
        public string password = "pass";
        public List<PurchaseOrder> purchase_order_list = new List<PurchaseOrder>();
        public List<Models.Material> material_list = new List<Material>();
        public List<Models.Warehouse> warehouse_list;
        public List<Models.User> user_list = new List<User>();
        public List<Models.Worker> worker_list = new List<Worker>();
        public List<Models.UnitOfMeasure> unit_list = new List<UnitOfMeasure>();
        public User sessionUser;
        public Dashboard(User sessionUser)
        {
            this.sessionUser = sessionUser;
            InitializeComponent();
            hide_UserControls();
            mainDashboard1.Visible = true;
            Cursor = Cursors.Arrow;
            mainDashboard1.Controls.Find("metroTile11", true)[0].Click += btn_supplier_Click;
            mainDashboard1.Controls.Find("metroTile10", true)[0].Click += btn_warehouse_Click;
            mainDashboard1.Controls.Find("metroTile11", true)[0].Click += btn_supplier_Click;
            mainDashboard1.Controls.Find("metroTile2", true)[0].Click += btn_client_Click;
            mainDashboard1.Controls.Find("metroTile5", true)[0].Click += btn_bom_Click;
            mainDashboard1.Controls.Find("metroTile8", true)[0].Click += btn_workstation_Click;
            mainDashboard1.Controls.Find("metroTile9", true)[0].Click += btn_parameters_Click;
            mainDashboard1.Controls.Find("metroTile1", true)[0].Click += btn_user_Click;
            mainDashboard1.Controls.Find("metroTile3", true)[0].Click += btn_worker_Click;
            mainDashboard1.Controls.Find("metroTile7", true)[0].Click += btn_material_Click;
            mainDashboard1.Controls.Find("metroTile4", true)[0].Click += btn_profile_Click;
            mainDashboard1.Controls.Find("metroTile6", true)[0].Click += btn_product_Click;
            mainDashboard1.Controls.Find("metroTile12", true)[0].Click += btn_shift_Click;
            mainDashboard1.Controls.Find("metroTile13", true)[0].Click += btn_typewarehouses_Click;
            mainDashboard1.Controls.Find("metroTile16", true)[0].Click += btn_ratio_Click;
            uc_reports.Controls.Find("metroTile8", true)[0].Click += btn_wperformance_Click;
            uc_reports.Controls.Find("metroTileLog", true)[0].Click += btn_log_Click;
            mainDashboard1.Controls.Find("metroTile14", true)[0].Click += btn_movementsType_Click;
            this.sessionUser = sessionUser;
            label_user_role.Text = "(" + sessionUser.Profile.Description + ")";
            label_user_name.Text = sessionUser.Name + " " + sessionUser.Middlename;
            CheckButtonsVisibility();
            Helpers.CheckPermissionsHelper.Check(this, sessionUser);
        }

        private void CheckButtonsVisibility()
        {
            btn_config.Visible = UserCanViewConfigButton();
            // -------------------------------------------------------
            btn_warehouse.Visible = sessionUser.Profile.HasFunctionality("VIEW WAREHOUSE MODULE");
            btn_sales.Visible = sessionUser.Profile.HasFunctionality("VIEW SALES MODULE");
            btn_purchase.Visible = sessionUser.Profile.HasFunctionality("VIEW PURCHASE MODULE");
            btn_production.Visible = sessionUser.Profile.HasFunctionality("VIEW PRODUCTION MODULE");
            btn_simulation.Visible = sessionUser.Profile.HasFunctionality("RUN SIMULATION");
            btn_reportes.Visible = sessionUser.Profile.HasFunctionality("VIEW REPORTS MODULE");
        }

        private bool UserCanViewConfigButton()
        {
            string[] permissions = new string[] {
                "VIEW USERS",
                "VIEW CUSTOMER",
                "VIEW WORKERS",
                "VIEW PROFILES",
                "VIEW RECIPE",
                "VIEW PRODUCT",
                "VIEW MATERIAL",
                "VIEW WORKSTATION",
                "VIEW PARAMETERS",
                "VIEW MATERIAL WAREHOUSE",
                "VIEW PRODUCT WAREHOUSE",
                "VIEW SUPPLIER",
                "VIEW SHIFT",
                "VIEW MATERIAL WAREHOUSE TYPE",
                "VIEW PRODCUT WAREHOUSE TYPE",
                "VIEW MATERIAL MOVEMENT TYPE",
                "VIEW PRODUCT MOVEMENT TYPE",
                "VIEW RATIOS"
            };

            foreach(string perm in permissions)
            {
                if (sessionUser.Profile.HasFunctionality(perm)) return true;
            }

            return false;
        }

        private void menuButton_Click(object sender, MouseEventArgs e)
        {
            highlightButtons(sender);
        }

        private void highlightButtons(object sender)
        {
            btn_config.BackColor = Color.FromArgb(64, 104, 104);
            btn_config.ForeColor = Color.White;
            btn_config.FlatAppearance.BorderColor = Color.FromArgb(64, 104, 104);
            btn_config.ImageIndex = 1;

            btn_warehouse.BackColor = Color.FromArgb(64, 104, 104);
            btn_warehouse.ForeColor = Color.White;
            btn_warehouse.FlatAppearance.BorderColor = Color.FromArgb(64, 104, 104);
            btn_warehouse.ImageIndex = 1;

            btn_sales.BackColor = Color.FromArgb(64, 104, 104);
            btn_sales.ForeColor = Color.White;
            btn_sales.FlatAppearance.BorderColor = Color.FromArgb(64, 104, 104);
            btn_sales.ImageIndex = 1;

            btn_purchase.BackColor = Color.FromArgb(64, 104, 104);
            btn_purchase.ForeColor = Color.White;
            btn_purchase.FlatAppearance.BorderColor = Color.FromArgb(64, 104, 104);
            btn_purchase.ImageIndex = 1;

            btn_production.BackColor = Color.FromArgb(64, 104, 104);
            btn_production.ForeColor = Color.White;
            btn_production.FlatAppearance.BorderColor = Color.FromArgb(64, 104, 104);
            btn_production.ImageIndex = 1;

            btn_simulation.BackColor = Color.FromArgb(64, 104, 104);
            btn_simulation.ForeColor = Color.White;
            btn_simulation.FlatAppearance.BorderColor = Color.FromArgb(64, 104, 104);
            btn_simulation.ImageIndex = 1;

            btn_reportes.BackColor = Color.FromArgb(64, 104, 104);
            btn_reportes.ForeColor = Color.White;
            btn_reportes.FlatAppearance.BorderColor = Color.FromArgb(64, 104, 104);
            btn_reportes.ImageIndex = 1;

            ((Button)sender).BackColor = Color.FromArgb(222, 234, 198);
            ((Button)sender).ForeColor = Color.FromArgb(64, 104, 104);
            ((Button)sender).FlatAppearance.BorderColor = Color.FromArgb(222, 234, 198);
            ((Button)sender).ImageIndex = Math.Abs(((Button)sender).ImageIndex - 1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(64, 104, 104);
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(222, 234, 198);
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }


        private void btn_supplier_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            supplier1.Visible = true;
        }

        private void btn_warehouse_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            warehouse1.Visible = true;
        }


        private void btn_parameters_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            parameters1.Visible = true;
        }
        private void btn_config_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            mainDashboard1.Visible = true;
        }

        private void btn_logo_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            btn_config.PerformClick();// ((object)btn_config, e);
            btn_config.PerformClick();
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uC_PurchasesMenu1.Visible = true;
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            client1.Visible = true;
        }

        private void btn_bom_Click(object sender, EventArgs e)
        {
            hide_UserControls();

            uc_recipe.Visible = true;
        }

        private void btn_workstation_Click(object sender, EventArgs e)
        {
            hide_UserControls();

            uc_workstation.Visible = true;
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            user.Visible = true;
        }

        private void btn_worker_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uc_worker.Visible = true;
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            hide_UserControls();

            uc_material.Visible = true;
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            profile.Visible = true;
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            hide_UserControls();

            uc_product.Visible = true;
        }

        private void btn_shift_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            shift.Visible = true;
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uC_SalesMain1.Visible = true;
        }

        private void hide_UserControls()
        {
            foreach (UserControl uc in panel5.Controls.OfType<UserControl>())
            {
                uc.Visible = false;
            }
        }

        private void btn_warehouse_Click_2(object sender, EventArgs e)
        {
            hide_UserControls();
            uC_WarehouseMovement1.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_production_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uc_ProductionMenu.Visible = true;
        }

        private void btn_simulation_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uC_Simulation1.Visible = true;
        }

        private void btn_typewarehouses_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            typeWarehouseMain1.Visible = true;
        }
        private void btn_ratio_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uc_ratio.Visible = true;
        }

        private void btn_currency_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uC_CurrencyMain1.Visible = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uc_reports.Visible = true;
        }
        
        private void btn_wperformance_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            workersPerformance_Report1.Visible = true;
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uC_LogReport1.Visible = true;
        }


        private void btn_movementsType_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uC_MovementsType1.Visible = true;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //this.metroLabel1.Visible = true;
        }

        private void metroLabel1_Leave(object sender, EventArgs e)
        {
            //this.metroLabel1.Visible = false;
        }

    }
}
