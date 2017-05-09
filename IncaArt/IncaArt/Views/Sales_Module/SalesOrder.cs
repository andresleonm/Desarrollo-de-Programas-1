using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Sales_Module
{
    public partial class SalesOrder : Form
    {
        public SalesOrder()
        {
            InitializeComponent();
            textBox4.Text = "VENTA 00001";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.Text = "Seleccionar";

            dataGridView1.Rows[0].Cells[0].Value = "001";
            dataGridView1.Rows[0].Cells[1].Value = "Cerámico";
            dataGridView1.Rows[0].Cells[2].Value = "";
            dataGridView1.Rows[0].Cells[3].Value = "153";
            dataGridView1.Rows[0].Cells[4].Value = "5.00";
            dataGridView1.Rows[0].Cells[5].Value = "765.00";

            textBox1.Text = "765.00";
            textBox2.Text = "137.70";
            textBox3.Text = "902.70";
        }

        private void add_Click(object sender, EventArgs e)
        {
            SalesOrderLine orderLineForm = new SalesOrderLine();
            orderLineForm.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
