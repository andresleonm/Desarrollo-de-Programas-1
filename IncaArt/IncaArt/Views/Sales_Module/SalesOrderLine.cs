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
    public partial class SalesOrderLine : Form
    {
        public SalesOrderLine()
        {
            InitializeComponent();
            domainUpDown1.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("Cerámico"))
            {
                textBox2.Text = "5.00";
            }else if (comboBox1.SelectedItem.Equals("Retablo"))
            {
                textBox2.Text = "7.00";
            }else if (comboBox1.SelectedItem.Equals("Piedra Tallada"))
            {
                textBox2.Text = "10.00";
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
