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
    public partial class UC_Ratio : MetroFramework.Controls.MetroUserControl
    {
        List<Models.Ratio> ratio_list;
        List<Models.Product> product_list;
        List<Models.Workstation> workstation_list;
        List<Models.Worker> worker_list;
        Controller.RatioController ratioController;
        Controller.ProductsController productController;
        Controller.WorkstationsController workstationController;
        Controller.WorkerController workerController;
        Controller.Result result;
        bool data_loaded;
        public UC_Ratio()
        {
            InitializeComponent();
        }

        private void UC_Ratio_Load(object sender, EventArgs e)
        {
            //string user = "dp1admin";
            //string password = "dp1admin";
            //ratioController = new Controller.RatioController(user, password);
            //productController = new Controller.ProductsController(user, password);
            //workstationController = new Controller.WorkstationsController(user, password);
            //workerController = new Controller.WorkerController(user, password);
            //Load_Data();
            //Load_DataGridView();
            data_loaded = false;
        }

        private void UC_Ratio_VisibleChanged(object sender, EventArgs e)
        {
            if (!data_loaded)
            {
                string user = "dp1admin";
                string password = "dp1admin";
                ratioController = new Controller.RatioController(user, password);
                productController = new Controller.ProductsController(user, password);
                workstationController = new Controller.WorkstationsController(user, password);
                workerController = new Controller.WorkerController(user, password);
                data_loaded = true;
            }
            Load_Data();
            Load_DataGridView();
        }

        private void UC_Ratio_ParentChanged(object sender, EventArgs e)
        {

        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();

            foreach (Models.Ratio ratio in ratio_list)
            {

                Models.Worker worker = null;
                foreach (var item in worker_list)
                {
                    if (item.Id == ratio.worker_id)
                    {
                        worker = item;
                        break;
                    }
                }
                Models.Product product = null;
                foreach (var item in product_list)
                {
                    if (item.Id == ratio.product_id)
                    {
                        product = item;
                        break;
                    }
                }
                Models.Workstation workstation = null;
                foreach (var item in workstation_list)
                {
                    if (item.Id == ratio.workstation_id)
                    {
                        workstation = item;
                        break;
                    }
                }
                string type = "";
                if (ratio.ratio_type == 1)
                {
                    type = "Eficiencia";
                }
                if (worker != null && product != null && workstation != null)
                {
                    string[] row = new string[5];
                    row[0] = worker.Name + " " + worker.Paternal_name + " " + worker.Maternal_name;
                    row[1] = product.Name;
                    row[2] = workstation.Name;
                    row[3] = type;
                    row[4] = ratio.value.ToString("F4");
                    metroGrid1.Rows.Add(row);
                }
            }
        }

        private void Load_Data()
        {
            result = workerController.getWokers();
            if (result.success)
            {
                worker_list = (List<Models.Worker>)result.data;
            }
            else
            {
                MessageBox.Show(result.message);
            }

            result = productController.getProducts();
            if (result.success)
            {
                product_list = (List<Models.Product>)result.data;
            }
            else
            {
                MessageBox.Show(result.message);
            }

            result = workstationController.getWorkstations();
            if (result.success)
            {
                workstation_list = (List<Models.Workstation>)result.data;
            }
            else
            {
                MessageBox.Show(result.message);
            }

            result = ratioController.getRatios("","","",0,0,0);
            if (result.success)
            {
                ratio_list = (List<Models.Ratio>)result.data;
            }
            else
            {
                MessageBox.Show(result.message);
            }

            Dictionary<int, string> combo_data;
            combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "Seleccionar");
            foreach (var item in product_list)
            {
                combo_data.Add(item.Id, item.Name);
            }
            combobox_product_s.DataSource = new BindingSource(combo_data, null);
            combobox_product_s.DisplayMember = "Value";
            combobox_product_s.ValueMember = "Key";

            combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "Seleccionar");
            combo_data.Add(1, "Eficiencia");
            combobox_ratio_type_s.DataSource = new BindingSource(combo_data, null);
            combobox_ratio_type_s.DisplayMember = "Value";
            combobox_ratio_type_s.ValueMember = "Key";

            combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "Seleccionar");
            foreach (var item in workstation_list)
            {
                combo_data.Add(item.Id, item.Name);
            }
            combobox_workstation_s.DataSource = new BindingSource(combo_data, null);
            combobox_workstation_s.DisplayMember = "Value";
            combobox_workstation_s.ValueMember = "Key";

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string worker_name=textbox_wname_s.Text;
            string paternal_name = textbox_wpaternal_s.Text;
            string maternal_name = textbox_wmaternal_s.Text;
            int product_id = ((KeyValuePair<int, string>)combobox_product_s.SelectedItem).Key;
            int workstation_id = ((KeyValuePair<int, string>)combobox_workstation_s.SelectedItem).Key;
            int ratio_type_id = ((KeyValuePair<int, string>)combobox_ratio_type_s.SelectedItem).Key;

            result = ratioController.getRatios(worker_name,paternal_name,maternal_name,workstation_id,product_id,ratio_type_id);
            if (result.success)
            {
                ratio_list = (List<Models.Ratio>)result.data;
            }
            else
            {
                MessageBox.Show(result.message);
            }
            Load_DataGridView();
        }

        private void btn_clean_s_Click(object sender, EventArgs e)
        {
            textbox_wname_s.Text = "";
            textbox_wmaternal_s.Text = "";
            textbox_wpaternal_s.Text = "";
            combobox_product_s.SelectedIndex = 0;
            combobox_ratio_type_s.SelectedIndex = 0;
            combobox_workstation_s.SelectedIndex = 0;
        }
    }
}
