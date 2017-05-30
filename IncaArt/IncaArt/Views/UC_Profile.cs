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
        bool data_loaded;
        List<int> selected_functionalities;
        Profile current_profile;

        public UC_Profile()
        {
            InitializeComponent();
            this.metroTabControl1.SelectedIndex = 0;
            data_loaded = false;
            selected_functionalities = new List<int>();
            current_profile = null;
        }

        private void Clean()
        {
            textbox_name.Text = "";
        }

        private void Clean_FuncGrid()
        {
            foreach (DataGridViewRow funcGridRow in metroGrid2.Rows)
            {
                funcGridRow.Cells[3].Value = false;
            }
        }

        private bool validate_data(string name) {
            bool isCorrect = true;
            string message = "";
            if (name == "")
            {
                isCorrect = false;
                message = "-Debe ingresar el nombre del perfil.\n";
            }
            if (selected_functionalities.Count == 0)
            {
                isCorrect = false;
                message += "-Debe seleccionar como mínimo un permiso para el perfil.";
            }
            if (!isCorrect)
                MessageBox.Show(message, "Error al registrar un nuevo perfil", MessageBoxButtons.OK);
            return isCorrect;
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            String name = textbox_name.Text;
            if (validate_data(name))
            {
                Profile profile = new Profile(0, name);

                foreach (int index in selected_functionalities)
                {
                    profile.Functionalities.Add(functionality_list[index]);
                }

                Result insert_result = profile_controller.insertProfile(profile);

                if (insert_result.success)
                {
                    Load_Data();
                    MessageBox.Show("Perfile agregado correctamente");
                    Load_DataGridView();
                    metroTabControl1.SelectedIndex = 0;
                    Clean();
                    Load_FunctionalityGridView();
                }
                else
                {
                    MessageBox.Show(insert_result.message);
                }
            }
        }


        private void Load_FunctionalityGridView()
        {
            metroGrid2.Rows.Clear();

            for (int i = 0; i < functionality_list.Count; i++)
            {
                Functionality f = functionality_list[i];
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells[0].Value = f.Id.ToString();
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells[1].Value = i.ToString();
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells[2].Value = f.Description;
                row.Cells.Add(new DataGridViewCheckBoxCell());
                row.Cells[3] = new DataGridViewCheckBoxCell();
                row.Cells[3].Style.NullValue = false;

                metroGrid2.Rows.Add(row);
            }
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();

            for (int i = 0; i < profile_list.Count; i++)
            {
                Profile p = profile_list[i];
                string[] row = new string[3];

                row[0] = p.Id.ToString();
                row[1] = i.ToString();
                row[2] = p.Description;

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
        

        private void UC_Profile_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && !data_loaded)
            {
                profile_controller = new ProfileController("", "");
                functionality_controller = new FunctionalityController("", "");
                profile_list = new List<Profile>();
                functionality_list = new List<Functionality>();

                Load_Data();
                Load_DataGridView();
                data_loaded = true;
            }
            else if (!Visible)
            {
                metroTabControl1.SelectedIndex = 0;
            }
        }

        private void metroGrid2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (metroGrid2.IsCurrentCellDirty)
            {
                metroGrid2.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void metroGrid2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid2.Columns[e.ColumnIndex].HeaderText == "Agregar" && e.RowIndex >= 0 && metroGrid2.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = metroGrid2.Rows[e.RowIndex];
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells[e.ColumnIndex];

                if ((Boolean)checkCell.Value)
                {
                    selected_functionalities.Add(Int32.Parse(row.Cells[1].Value.ToString()));
                } else
                {
                    selected_functionalities.Remove(Int32.Parse(row.Cells[1].Value.ToString()));
                }
            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];

            if (row.Cells[0].Value != null)
            {
                current_profile = profile_list[Int32.Parse(row.Cells[1].Value.ToString())];
                textbox_name.Text = current_profile.Description;
                selected_functionalities = current_profile.Functionalities.Select(f => f.Id).ToList();

                foreach(DataGridViewRow funcGridRow in metroGrid2.Rows)
                {
                    if (funcGridRow.Cells[0].Value != null)
                    {
                        int cellIndex = Int32.Parse(funcGridRow.Cells[0].Value.ToString());
                        funcGridRow.Cells[3].Value = selected_functionalities.Contains(cellIndex);
                    }
                }

                buttonSave.Text = "Registrar";
                metroTabControl1.SelectedIndex = 1;
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            Clean();
            Clean_FuncGrid();
            selected_functionalities.Clear();
            buttonSave.Text = "Guardar";
        }
    }
}
