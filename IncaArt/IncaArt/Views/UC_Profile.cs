using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class UC_Profile : MetroFramework.Controls.MetroUserControl
    {

        ProfileController profile_controller;
        FunctionalityController functionality_controller;
        List<Profile> profile_list;
        List<Functionality> functionality_list;

        public UC_Profile()
        {
            InitializeComponent();
            this.metroTabControl1.SelectedIndex = 0;
        }
        private bool validate_data(string name) {
            //bool isCorrect = true;
            //string message = "";
            //if (name == "")
            //{
            //    isCorrect = false;
            //    message = "-Debe ingresar el nombre del perfil.\n";
            //}
            //if (dataGridView_Permissions.SelectedRows.Count == 0)
            //{
            //    isCorrect = false;
            //    message += "-Debe seleccionar como mínimo un permiso para el perfil.";
            //}
            //if (!isCorrect)
            //    MessageBox.Show(message, "Error al registrar un nuevo perfil", MessageBoxButtons.OK);
            //return isCorrect;
            return true;
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            //String name = textBox_Name.Text;
            //if (validate_data(name)) {
                 
            //}
        }


        private void Load_FunctionalityGridView()
        {
            metroGrid2.Rows.Clear();

            foreach (Functionality f in functionality_list)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells[0].Value = f.Id.ToString();
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells[1].Value = f.Name;
                row.Cells.Add(new DataGridViewCheckBoxCell());
                row.Cells[2] = new DataGridViewCheckBoxCell()
                {
                    TrueValue = "1",
                    FalseValue = "0",
                };

                row.Cells[2].Style.NullValue = false;

                metroGrid2.Rows.Add(row);
            }
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();

            foreach (Profile p in profile_list)
            {
                string[] row = new string[2];

                row[0] = p.Id.ToString();
                row[1] = p.Description;

                metroGrid1.Rows.Add(row);
            }
        }

        private void Load_Data()
        {
            Result profile_result = profile_controller.getProfiles();
            Result functionality_result = functionality_controller.getFunctionalities();

            if (profile_result.success)
            {
                profile_list = (List<Profile>)profile_result.data;
            }
            else
            {
                MessageBox.Show(profile_result.message);
            }

            if (functionality_result.success)
            {
                functionality_list = (List<Functionality>)functionality_result.data;
            }
            else
            {
                MessageBox.Show(functionality_result.message);
            }

            Load_FunctionalityGridView();
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            profile_controller = new ProfileController("", "");
            functionality_controller = new FunctionalityController("", "");
            profile_list = new List<Profile>();
            functionality_list = new List<Functionality>();

            Load_Data();
            Load_DataGridView();
        }
    }
}
