using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class Frm_AdvancedSimulationConfig : Form
    {
        public int iterations, tabu_size, neighborhood_size, combinations;
        public Frm_AdvancedSimulationConfig()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            iterations = int.Parse(txt_iterations.Text);
            tabu_size = int.Parse(txt_tabu_list_size.Text);
            neighborhood_size = int.Parse(txt_neighborhood_size.Text);
            combinations = int.Parse(txt_combination_frecuency.Text);
        }

        private void txt_iterations_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_iterations.Text) || Math.Truncate(Double.Parse(txt_iterations.Text)) <= 0){
                txt_iterations.Text = "8000";
            }
        }

        private void txt_tabu_list_size_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_tabu_list_size.Text) || Math.Round(Double.Parse(txt_tabu_list_size.Text)) <= 0){
                txt_iterations.Text = "10";
            }
        }

        private void txt_neighborhood_size_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_neighborhood_size.Text) || Math.Round(Double.Parse(txt_neighborhood_size.Text)) <= 0)
            {
                txt_iterations.Text = "50";
            }
        }

        private void txt_combination_frecuency_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_combination_frecuency.Text) || Math.Round(Double.Parse(txt_combination_frecuency.Text)) <= 0)
            {
                txt_iterations.Text = "100";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_iterations.Text = "8000";
            txt_tabu_list_size.Text = "10";
            txt_neighborhood_size.Text = "50";
            txt_combination_frecuency.Text = "100";
        }
    }
}
