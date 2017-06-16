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
    public partial class UC_Currency : ICheckPermissions
    {
        
        bool name_flag;
        bool symbol_flag;

        List<Models.Currency> currency_list;
        Controller.CurrencyController currencyController;
        int cur_row;
        Controller.Result result;

        Models.Currency curCurrency;
        Dictionary<int, string> combo_class = new Dictionary<int, string>();
        public UC_Currency()
        {
            InitializeComponent();
        }

        private void UC_Currency_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            currencyController = new Controller.CurrencyController(user, password);
           // Set_Flag_All(false);
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {
            result = currencyController.getCurrencies();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar tipos de almacén", MessageBoxButtons.OK);
            else currency_list = (List<Models.Currency>)result.data;
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < currency_list.Count(); i++)
            {
                String[] row = new String[5];
                row[0] = currency_list[i].Id.ToString();
                row[1] = i.ToString();
                row[2] = currency_list[i].Name;
                row[3] = currency_list[i].Symbol;
                row[4] = currency_list[i].State;
                this.metroGrid1.Rows.Add(row);
            }
        }

        private void Clean()
        {
            ClearTextBoxes(this);
            //combobox_class.SelectedIndex = 2;
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }


                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }

        private Models.Currency CreateCurrency(int operacion)
        {
            /*
            int id = 0;
            String name, symbol, state;

            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
            name = textbox_name.Text;
            //int type_id = ((KeyValuePair<int, string>)combobox_type.SelectedItem).Key;
            symbol = textbox_symbol.Text;
            state = "ACTIVE";
            Models.Currency currency = new Models.Currency();

            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            currency = new Models.MaterialTypeWarehouse(id, name, symbol, state);
            */
            // return typeWarehouse;
            return null;
        }

        private void register_Click(object sender, EventArgs e)
        {

        }
    }
}
