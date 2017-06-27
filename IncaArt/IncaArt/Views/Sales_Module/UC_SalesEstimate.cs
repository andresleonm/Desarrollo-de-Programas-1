using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controller;
using System.Text.RegularExpressions;
namespace WindowsFormsApp1.Views.Sales_Module
{
    public partial class UC_SalesEstimate : UserControl
    {
        private string user = "dp1admin";
        private string password = "dp1admin";
        private bool edit = false;
        private SalesEstimate se_edit;
        private List<SalesEstimate> sales_estimates;
        private Customer customer;
        private List<Currency> currencies;
        private CurrencyController currency_controller;
        private SalesEstimateController sales_estimate_controller;
        private SalesEstimateLineController sales_estimate_line_controller;

    
        bool phone_flag;
        bool obs_flag;

        public UC_SalesEstimate()
        {
            InitializeComponent();

            currency_controller = new CurrencyController(user, password);
            sales_estimate_controller = new SalesEstimateController(user, password);
            sales_estimate_line_controller = new SalesEstimateLineController(user, password);

            fill_Sales_Estimate();

            Result result = currency_controller.getCurrencies();
            currencies = (List<Currency>)result.data;

            foreach (Currency curr in currencies)
                this.cbo_Currency.Items.Add(curr.Symbol + "  -  " + curr.Name);

            btn_production.Visible = false;

        }

        private void tab_Estimate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Estimate.SelectedIndex == 0) // Estimates
            {
                ctxt_estimate_id.Text = "";
                ctxt_customer.Text = "";
                customer = null;
                fill_Sales_Estimate();
            }
            else if (tab_Estimate.SelectedIndex == 1) // New Estimate
            {
                if (!edit)
                {
                    customer = null;
                    btn_Clean.PerformClick();
                    btn_Clean.PerformClick();
                }
            }
        }

        #region CONSULTANT ESTIMATE
        // -----------------------------------------------------
        //                   CONSULTANT ESTIMATE
        // -----------------------------------------------------

        private void btn_SearchClient_Click(object sender, EventArgs e)
        {
            var customerL = new List<Customer>();
            Sales_Module.SalesOrderSearchClient search_view = new Sales_Module.SalesOrderSearchClient(ref customerL, user, password, 'E');
            search_view.ShowDialog();

            if (customerL.Count != 0)
            {
                customer = customerL[0];
                ctxt_customer.Text = customer.Name;
            }
        }

        private void btn_Search_Estimates_Click(object sender, EventArgs e)
        {
            SalesEstimate sales_estimate = new SalesEstimate();
            DateTime init = dt_iniDate.Value.Date;
            DateTime end = dt_endDate.Value.Date;
            Boolean equals = false;
            if (init == end) equals = true;
            if (ctxt_estimate_id.Text != "")
                sales_estimate.Id = Int32.Parse((ctxt_estimate_id.Text));
            else
                sales_estimate.Id = -1;

            sales_estimate.Customer_name = ctxt_customer.Text;

            Result result = sales_estimate_controller.getSalesEstimate_by_filter(sales_estimate, init, end,equals);

            if (result.data == null)
                MessageBox.Show(result.message, "Error al buscar cotizaciones con filtros", MessageBoxButtons.OK);
            else
            {
                sales_estimates = new List<SalesEstimate>();
                sales_estimates = (List<SalesEstimate>)result.data;
                fill_gridView_Estimate(sales_estimates);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int selectedRowCount = grid_estimates.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount <= 0)
            {
                MessageBox.Show(this, "Primero debe seleccionar una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedRowCount > 1)
            {
                MessageBox.Show(this, "Solo debe seleccionar una fila para poder editar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedRowCount == 1)
            {
                active_Edit();
            }
        }

        private void grid_estimates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            active_Edit();
        }

        private void active_Edit()
        {
            edit = true;
            btn_production.Visible = edit;
            int index = grid_estimates.SelectedRows[0].Index;
            var id = sales_estimates[index].Id;
            se_edit = (Models.SalesEstimate)sales_estimate_controller.getSalesEstimate(id).data;
            grid_estimate_lines.DataSource = se_edit.Lines;
            tab_Estimate.SelectedIndex = 1;
            fill_Sales_Estimate_Form(se_edit);
        }

        private void fill_Sales_Estimate()
        {
            Result result = sales_estimate_controller.getSalesEstimates();
            sales_estimates = (List<SalesEstimate>)result.data;
            fill_gridView_Estimate(sales_estimates);
        }

        private void fill_gridView_Estimate(List<SalesEstimate> list)
        {
            clean_gridView_Estimate();
            List<SalesEstimate> current = (List<SalesEstimate>)this.grid_estimates.DataSource;
            if (current == null)
                current = new List<SalesEstimate>();
            current = current.Concat(list).ToList();
            this.grid_estimates.DataSource = current;
            AdjustColumnEstimate();
        }

        private void clean_gridView_Estimate()
        {
            List<SalesEstimate> empty_list = new List<SalesEstimate>();
            grid_estimates.DataSource = empty_list;
        }

        private void AdjustColumnEstimate()
        {
            grid_estimates.Columns["estimate_id"].DisplayIndex = 0;
            grid_estimates.Columns["customer_name"].DisplayIndex = 1;
            grid_estimates.Columns["issue_date"].DisplayIndex = 2;
            grid_estimates.Columns["currency_name"].DisplayIndex = 3;
            grid_estimates.Columns["amount2"].DisplayIndex = 4;
            grid_estimates.Columns["observation"].DisplayIndex = 5;
            grid_estimates.Columns["status"].DisplayIndex = 6;
        }

        #endregion

        #region REGISTER ESTIMATE
        // -----------------------------------------------------
        //                   REGISTER ESTIMATE
        // -----------------------------------------------------

        private void btn_Search_Client_Click(object sender, EventArgs e)
        {
            Set_Flag_All(true);
            var customerL = new List<Customer>();
            Sales_Module.SalesOrderSearchClient search_view = new Sales_Module.SalesOrderSearchClient(ref customerL, user, password, 'E');
            search_view.ShowDialog();

            if (customerL.Count != 0)
            {
                customer = customerL[0];
                txt_name.Text = customer.Name;
                txt_address.Text = customer.Address;
                txt_Doi.Text = customer.Doi;
                txt_phone.Text = customer.Phone;
                if (edit)
                    se_edit.Customer_id = customer.Id;
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            var lines = new List<Models.SalesEstimateLine>();
            Sales_Module.SalesEstimateLine estimate_line = new Sales_Module.SalesEstimateLine(ref lines, user, password);
            estimate_line.ShowDialog();

            fill_gridView_EstimateLine(lines);

            double acumulate = 0;
            for (int i = 0; i < grid_estimate_lines.RowCount; i++)
                acumulate += double.Parse(grid_estimate_lines.Rows[i].Cells["amount"].Value.ToString());
            txt_amount.Text = acumulate.ToString("0.00");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dt_IssueHour.Text = "";
            dt_IssueDate.Text = "";

            if (edit)
            {
                Set_Flag_All(true);
                fill_Sales_Estimate_Object(se_edit);
                var lines = (List<Models.SalesEstimateLine>)grid_estimate_lines.DataSource;
                if (lines.Count > 0)
                    se_edit.Lines = lines;

                Result result = sales_estimate_controller.updateSalesEstimate(se_edit);

                if (result.success)
                {
                    btn_Clean.PerformClick();
                    btn_Clean.PerformClick();
                    tab_Estimate.SelectedIndex = 0;
                    MessageBox.Show(this, "Cotización actualizada exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Set_Flag_All(false);
                    edit = false;
                    btn_production.Visible = false;
                    se_edit = new SalesEstimate();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la cotización", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (Validate_Data())
            {
                if (customer != null)
                {
                    if (customer.Name == "" || customer.Phone == "" || customer.Doi == "" ||
                        String.IsNullOrWhiteSpace(cbo_Currency.Text) ||
                        String.IsNullOrWhiteSpace(txt_name.Text) || String.IsNullOrWhiteSpace(txt_address.Text) || String.IsNullOrWhiteSpace(txt_Doi.Text) || String.IsNullOrWhiteSpace(txt_phone.Text))
                    {
                        MessageBox.Show(this, "Debe completar los campos de cliente y/o moneda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    List<Models.SalesEstimateLine> detail = (List<Models.SalesEstimateLine>)this.grid_estimate_lines.DataSource;
                    if (detail == null || detail.Count == 0 || allIsZero(detail))
                    {
                        MessageBox.Show("Seleccione por lo menos una línea de la cotización con cantidad diferente de 0");
                        return;
                    }

                    if (!allGreatherThanZero(detail))
                    {
                        MessageBox.Show("Las cantidades deben ser mayores a 0");
                        return;
                    }

                    Models.SalesEstimate sales_estimate = new Models.SalesEstimate();
                    sales_estimate.Customer_id = customer.Id;
                    fill_Sales_Estimate_Object(sales_estimate);
                    sales_estimate.Lines = detail;

                    Result result = sales_estimate_controller.insertSalesEstimate(sales_estimate);

                    if (result.success)
                    {
                        MessageBox.Show(this, "Se ha creado la cotización N° : " + result.data.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                        btn_Clean.PerformClick();
                        tab_Estimate.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show(result.message);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK);
                }
            }else {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                List<Models.SalesEstimateLine> data = (List<Models.SalesEstimateLine>)grid_estimate_lines.DataSource;
                try
                {
                    Models.SalesEstimateLine currentObject = (Models.SalesEstimateLine)grid_estimate_lines.CurrentRow.DataBoundItem;
                    if (currentObject == null)
                        MessageBox.Show("Seleccione la línea que desea eliminar");
                    data.Remove(currentObject);
                    data = data.Concat(new List<Models.SalesEstimateLine>().ToList()).ToList();
                    grid_estimate_lines.DataSource = data;
                    AdjustColumnEstimateLine();
                    refresh_amount();
                }
                catch
                {
                    grid_estimate_lines.DataSource = new List<Models.SalesEstimateLine>();
                    return;
                }
            }
            catch
            {
                grid_estimate_lines.DataSource = new List<Models.SalesEstimateLine>();
                return;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Clean.PerformClick();
            btn_Clean.PerformClick();
            this.Visible = false;
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            edit = false;
            btn_production.Visible = false;
            se_edit = new SalesEstimate();
            Clean();
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                txt_Doi.Select();
        }

        private void txt_Doi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                txt_address.Select();
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                txt_phone.Select();
        }

        private void grid_estimate_lines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 8 || e.ColumnIndex == 9)
                {
                    double update_amount = double.Parse(grid_estimate_lines.Rows[e.RowIndex].Cells["quantity"].Value.ToString()) * double.Parse(grid_estimate_lines.Rows[e.RowIndex].Cells["unit_price"].Value.ToString());
                    grid_estimate_lines.Rows[e.RowIndex].Cells["amount"].Value = update_amount;

                    refresh_amount();
                }
            }
        }

        private void refresh_amount()
        {
            double acumulate = 0;
            for (int i = 0; i < grid_estimate_lines.RowCount; i++)
            {
                acumulate += double.Parse(grid_estimate_lines.Rows[i].Cells["amount"].Value.ToString());
            }
            txt_amount.Text = acumulate.ToString("0.00");
        }

        private bool allIsZero(List<Models.SalesEstimateLine> lines)
        {
            foreach (Models.SalesEstimateLine line in lines)
            {
                if (line.Quantity != 0)
                    return false;
            }
            return true;
        }

        private bool allGreatherThanZero(List<Models.SalesEstimateLine> lines)
        {
            foreach (Models.SalesEstimateLine line in lines)
            {
                if (line.Quantity < 0)
                    return false;
            }
            return true;
        }

        private void fill_Sales_Estimate_Object(SalesEstimate se)
        {
            se.Customer_name = txt_name.Text;
            se.Customer_doi = txt_Doi.Text;
            se.Customer_address = txt_address.Text;
            se.Customer_phone = txt_phone.Text;

            se.Currency_id = currencies.ElementAt(cbo_Currency.SelectedIndex).Id;
            se.Currency_name = currencies.ElementAt(cbo_Currency.SelectedIndex).Name;
            se.Currency_symbol = currencies.ElementAt(cbo_Currency.SelectedIndex).Symbol;

            se.Issue_date = dt_IssueDate.Value.Date + dt_IssueHour.Value.TimeOfDay;

            se.Observation = txt_observation.Text;
            se.Amount = double.Parse(txt_amount.Text);
            
        }

        private void fill_Sales_Estimate_Form(SalesEstimate se)
        {
            Clean();
            txt_name.Text = se.Customer_name;
            txt_Doi.Text = se.Customer_doi;
            txt_address.Text = se.Customer_address;
            txt_phone.Text = se.Customer_phone;

            txt_idEstimate.Text = se.Id.ToString();
            cbo_Currency.Text = se.Currency_symbol + "  -  " + se.Currency_name;
            dt_IssueDate.Text = se.Issue_date.ToShortDateString();
            dt_IssueHour.Text = se.Issue_date.ToLongTimeString();

            txt_observation.Text = se.Observation;
            txt_amount.Text = se.Amount.ToString("0.00");
            txt_Status.Text = se.Status;

            fill_gridView_EstimateLine(se.Lines);

            int i = 0;
            foreach (Models.SalesEstimateLine sel in se.Lines)
            {
                grid_estimate_lines.Rows[i].Cells["amount"].Value = (sel.Quantity * sel.Unit_price).ToString();
                i++;
            }
        }

        private void Clean()
        {
            txt_name.Text = "";
            txt_Doi.Text = "";
            txt_address.Text = "";
            txt_phone.Text = "";

            txt_idEstimate.Text = "";
            cbo_Currency.Text = "";

            txt_observation.Text = "";
            txt_amount.Text = "";
            txt_Status.Text = "";

            dt_IssueHour.Text = "";
            dt_IssueDate.Text = "";

            customer = new Customer();
            clean_gridView_EstimateLine();
        }

        private void clean_gridView_EstimateLine()
        {
            List<Models.SalesEstimateLine> empty_list = new List<Models.SalesEstimateLine>();
            grid_estimate_lines.DataSource = empty_list;
        }

        private void fill_gridView_EstimateLine(List<Models.SalesEstimateLine> list)
        {

            List<Models.SalesEstimateLine> current = (List<Models.SalesEstimateLine>)this.grid_estimate_lines.DataSource;
            if (current == null)
                current = new List<Models.SalesEstimateLine>();
            current = current.Concat(list).ToList();
            this.grid_estimate_lines.DataSource = current;
            AdjustColumnEstimateLine();
        }

        private void AdjustColumnEstimateLine()
        {
            grid_estimate_lines.Columns["product"].DisplayIndex = 0;
            grid_estimate_lines.Columns["unit"].DisplayIndex = 1;
            grid_estimate_lines.Columns["warehouse"].DisplayIndex = 2;
            grid_estimate_lines.Columns["quantity"].DisplayIndex = 3;
            grid_estimate_lines.Columns["unit_price"].DisplayIndex = 4;
            grid_estimate_lines.Columns["amount"].DisplayIndex = 5;
        }

        #endregion

        #region VALIDATES

        private bool Validate_Data()
        {
            if (phone_flag && obs_flag)
                return true;
            return false;
        }

        private void Set_Flag_All(bool value)
        {
            phone_flag = value;
            obs_flag = value;
        }

        private void Set_Flag(string name, bool value)
        {
            switch (name)
            {
                case "txt_phone":
                    phone_flag = value;
                    break;
                case "txt_observation":
                    obs_flag = value;
                    break;
            }
        }
        private void textbox_ValidatingPhone(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            string text = textbox.Text;

            if (!isPhoneCorrect(text))
            {
                //e.Cancel = true;
                Set_Flag(textbox.Name, false);
                errorProvider.SetError(textbox, "Debe ingresar un teléfono válido");

            }
            else
            {
                //e.Cancel = false;
                Set_Flag(textbox.Name, true);
                errorProvider.SetError(textbox, null);
            }
        }


        private void textbox_ValidatingObs(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            string text = textbox.Text;

            if (!isObservationCorrect(text))
            {
                //e.Cancel = true;
                Set_Flag(textbox.Name, false);
                errorProvider.SetError(textbox, "La longitud máxima es de 400 caracteres");
            }
            else
            {
                //e.Cancel = false;
                Set_Flag(textbox.Name, true);
                errorProvider.SetError(textbox, null);
            }
        }

        private Boolean isObservationCorrect(String observation)
        {
            if (observation.Length > 400)
                return false;
            else
                return true;
        }
        private Boolean isPhoneCorrect(String phone)
        {
            String expresion;
            if (phone.Length > 11)
                return false;
            expresion = "^[+-]?\\d+(\\.\\d+)?$";

            if (Regex.IsMatch(phone, expresion))
            {
                if (Regex.Replace(phone, expresion, String.Empty).Length == 0)
                {
                    phone_flag = true;
                    return true;
                }
                else
                {
                    phone_flag = false;
                    return false;
                }
            }
            else
            {
                phone_flag = false;
                return false;
            }
        }

        private void txt_Doi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == (char)8)
                e.Handled = false;
        }

        #endregion

        private void btn_production_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea generar las ordenes de produccion?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Set_Flag_All(true);
                fill_Sales_Estimate_Object(se_edit);
                var lines = (List<Models.SalesEstimateLine>)grid_estimate_lines.DataSource;
                if (lines.Count > 0)
                    se_edit.Lines = lines;

                Result result = sales_estimate_controller.updateSalesEstimate(se_edit);

                if (result.success)
                {
                    sales_estimate_controller.make_production(se_edit);
                    btn_Clean.PerformClick();
                    btn_Clean.PerformClick();
                    tab_Estimate.SelectedIndex = 0;
                    MessageBox.Show(this, "Ordenes de Produccion Generadas Exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Set_Flag_All(false);
                    edit = false;
                    btn_production.Visible = false;
                    se_edit = new SalesEstimate();
                }
                else
                {
                    MessageBox.Show(result.message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
