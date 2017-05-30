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
    public partial class UC_PurchaseOrder : UserControl
    {
        Boolean editing;
        Models.PurchaseOrder editing_order;
        private List<Models.Material> materials;
        private List<Models.MaterialWarehouse> warehouses;
        private List<Models.Supplier> suppliers;
        private List<Models.Currency> currencies;
        private List<Models.UnitOfMeasure> units_of_measure;
        private DateTimePicker cellDateTimePicker;
        public UC_PurchaseOrder()
        {
            InitializeComponent();
            this.cellDateTimePicker = new DateTimePicker();
            this.cellDateTimePicker.Format = DateTimePickerFormat.Short;
            this.cellDateTimePicker.ValueChanged += new EventHandler(cellDateTimePickerValueChanged);
            this.cellDateTimePicker.Visible = false;
            this.grid_order_lines.Controls.Add(cellDateTimePicker);            
        }

        void cellDateTimePickerValueChanged(object sender, EventArgs e)
        {
            grid_order_lines.CurrentRow.Cells[0].Value = cellDateTimePicker.Value.ToShortDateString();//convert the date as per your format
            cellDateTimePicker.Visible = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if(grid_order_lines.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar por lo menos una línea a la orden de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (editing)
                {                    
                }
            }
        }

        public void fillForm(Models.PurchaseOrder order)
        {
            editing = true;
            editing_order = order;
            txt_id.Text = order.Id.ToString();
            date_order_date.Text = order.Creation_date.ToString();
            //combo_supplier.Text = order.Supplier.Supplier_name;
            //combo_address.Text = order.Supplier.Supplier_addres;
            txt_state.Text = order.State;

            foreach(Models.PurchaseOrderLine line in order.Lines)
            {
                string[] grid_line = new string[6];                
                grid_line[1] = "";
                grid_line[2] = line.Quantity.ToString();
                //grid_line[3] = line.Material.Name;
                grid_line[4] = line.Price.ToString();
                grid_line[5] = (line.Quantity * line.Price).ToString();
                grid_order_lines.Rows.Add(grid_line);
            }
            

        }

        private void grid_order_lines_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txt_no_taxes.Text = (Double.Parse(txt_no_taxes.Text) + (Double.Parse(grid_order_lines.Rows[grid_order_lines.Rows.Count].Cells[5].Value.ToString())) / 1.18).ToString();
            txt_taxes.Text = (Double.Parse(txt_no_taxes.Text) * 0.18).ToString();
            txt_total.Text = (Double.Parse(txt_no_taxes.Text) + Double.Parse(txt_taxes.Text)).ToString();
        }

        private void btn_new_line_Click(object sender, EventArgs e)
        {
            Models.PurchaseOrderLine line = new Models.PurchaseOrderLine();
            Purchase_Module.PurchaseOrderLine frm_line = new Purchase_Module.PurchaseOrderLine(ref line);
            frm_line.ShowDialog();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Controller.PurchaseOrderController po_controller = new Controller.PurchaseOrderController("dp1admin", "dp1admin");
            Controller.PurchaseOrderLineController pol_controller = new Controller.PurchaseOrderLineController("dp1admin", "dp1admin");
            Models.PurchaseOrder po = new Models.PurchaseOrder();
            po.Id = Int32.Parse(txt_id.Text);
            po.Amount = Double.Parse(txt_total.Text);
            po.Creation_date = DateTime.Parse(date_order_date.Text);
            po.External_number = txt_external_number.Text;
            po.Igv_amount = Double.Parse(txt_taxes.Text);
            po.Igv_percentage = Double.Parse(lbl_igv.Text);
            po.Observation = txt_observation.Text;
            po.State = txt_state.Text;
            po.Supplier_address = txt_address.Text;
            po.Supplier_doi = txt_supplier_doi.Text;
            po.Supplier_id = suppliers.Find(s => s.Name == combo_supplier.Text).Id;
            po.Supplier_name = combo_supplier.Text;
            po.Supplier_phone = txt_supplier_phone.Text;
            po.Currency_id = currencies.Find(c => c.Name == txt_currency.Text).Id;
            int po_id = Int32.Parse(po_controller.insertPurchaseOrder(po).data.ToString());
                        
            for (int i=0;i<grid_order_lines.RowCount-1;i++)
            {
                int unit_of_measure_id = units_of_measure.Find(uom => uom.Name == grid_order_lines.Rows[i].Cells[3].Value.ToString()).Id;
                int material_id = materials.Find(m => m.Name == grid_order_lines.Rows[i].Cells[1].Value.ToString()).Id;
                int warehouse_id = warehouses.Find(w => w.Name == grid_order_lines.Rows[i].Cells[4].Value.ToString()).Id;
                Models.PurchaseOrderLine pol = new Models.PurchaseOrderLine(po_id, unit_of_measure_id, Int32.Parse(grid_order_lines.Rows[i].Cells[2].Value.ToString())
                                                    , Double.Parse(grid_order_lines.Rows[i].Cells[6].Value.ToString()), DateTime.Parse(grid_order_lines.Rows[i].Cells[0].Value.ToString()), 0
                                                    , material_id,warehouse_id);
                pol_controller.insertPurchaseOrderLine(pol);
            }
        }

        private void UC_PurchaseOrder_Load(object sender, EventArgs e)
        {
            loadLists();         
            foreach (Models.Material m in materials)
            {
                ((DataGridViewComboBoxColumn)grid_order_lines.Columns["material"]).Items.Add(m.Name);
            }                                                  

            foreach (Models.MaterialWarehouse w in warehouses)
            {
                ((DataGridViewComboBoxColumn)grid_order_lines.Columns["warehouse"]).Items.Add(w.Name);
            }                                 

            foreach(Models.Supplier s in suppliers)
            {
                combo_supplier.Items.Add(s.Name);
            }

            txt_taxes.Text = "0";
            txt_total.Text = "0";
            txt_total.Text = "0";
            txt_state.Text = "Registrado";
            txt_id.Text = "2";
            txt_currency.Text = currencies[0].Name;
        }

        private void grid_order_lines_CellContentClick(object sender, DataGridViewCellEventArgs e) // añade un datetimepicker a la grilla
        {
            if (e.ColumnIndex == 0)

            {
                Rectangle tempRect = grid_order_lines.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                cellDateTimePicker.Location = tempRect.Location;
                cellDateTimePicker.Width = tempRect.Width;
                cellDateTimePicker.Visible = true;
            }
        }

        private void grid_order_lines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double avg_cost = 0;
            if (materials != null)
            {
                if (e.ColumnIndex == 1) // si cambió el material
                {
                    avg_cost = materials.Find(m => m.Name == grid_order_lines.Rows[e.RowIndex].Cells[1].Value.ToString()).Average_cost;

                    grid_order_lines.Rows[e.RowIndex].Cells[3].Value =
                        units_of_measure.Find(uom => uom.Id ==
                            materials.Find(m => m.Name == grid_order_lines.Rows[e.RowIndex].Cells[1].Value.ToString()).Unit_id).Name;

                    grid_order_lines.Rows[e.RowIndex].Cells[5].Value = avg_cost;                                           

                }
                else if(e.ColumnIndex == 2) // si cambió la cantidad
                {
                    grid_order_lines.Rows[e.RowIndex].Cells[6].Value =
                        Double.Parse(grid_order_lines.Rows[e.RowIndex].Cells[2].Value.ToString()) * avg_cost;                        
                    calculateCosts();
                }
            }
        }

        public void loadLists()
        {

            string user = "dp1admin";
            string password = "dp1admin";
            
            Controller.MaterialsController material_controller = new Controller.MaterialsController(user, password);
            Controller.MaterialWarehouseController warehouse_controller = new Controller.MaterialWarehouseController(user, password);
            Controller.UnitController unit_controller = new Controller.UnitController(user, password);
            Controller.SupplierController supplier_controller = new Controller.SupplierController(user, password);
            Controller.CurrencyController currencies_controller = new Controller.CurrencyController(user, password);

            Controller.Result result = material_controller.getMaterials();
            materials = (List<Models.Material>)result.data;

            result = warehouse_controller.getMaterialWarehouses();
            warehouses = (List<Models.MaterialWarehouse>)result.data;

            result = unit_controller.getUnits();
            units_of_measure = (List<Models.UnitOfMeasure>)result.data;

            result = supplier_controller.getSuppliers();
            suppliers = (List<Models.Supplier>)result.data;

            result = currencies_controller.getCurrencies();
            currencies = (List<Models.Currency>)result.data;
            
        }

        private void combo_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_address.Text = suppliers.Find(s => s.Name == combo_supplier.Text).Address;
            txt_supplier_doi.Text = suppliers.Find(s => s.Name == combo_supplier.Text).Doi;
            txt_supplier_phone.Text = suppliers.Find(s => s.Name == combo_supplier.Text).Phone;            

        }

        private void calculateCosts()
        {
            double taxes = 0;
            double no_taxes = 0;
            double total = 0;

            for(int i=0; i<grid_order_lines.RowCount-1;i++)
            {
                taxes = taxes + Double.Parse(grid_order_lines.Rows[i].Cells[2].Value.ToString()) *
                        Double.Parse(grid_order_lines.Rows[i].Cells[6].Value.ToString()) * Double.Parse(lbl_igv.Text);
                no_taxes = no_taxes + Double.Parse(grid_order_lines.Rows[i].Cells[grid_order_lines.Rows[i].Cells.Count - 1].Value.ToString());
                total = total + no_taxes + taxes;
            }

            txt_taxes.Text = taxes.ToString();
            txt_total.Text = total.ToString();
            txt_no_taxes.Text = no_taxes.ToString();
        }
    }
}
