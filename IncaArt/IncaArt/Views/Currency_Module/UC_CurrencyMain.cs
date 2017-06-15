using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Currency_Module
{
    public partial class UC_CurrencyMain : ICheckPermissions
    {
        public UC_CurrencyMain()
        {
            InitializeComponent();
            this.uC_Currency1.Visible = true;
            this.uC_Exchange1.Visible = false;
        }

        private void UC_CurrencyMain_Load(object sender, EventArgs e)
        {

        }

        private void select_currency_Click(object sender, EventArgs e)
        {
            this.uC_Currency1.Visible = true;
            this.uC_Exchange1.Visible = false;
        }

        private void select_exchange_Click(object sender, EventArgs e)
        {
            this.uC_Exchange1.Visible = true;
            this.uC_Currency1.Visible = false;
        }
    }
}
