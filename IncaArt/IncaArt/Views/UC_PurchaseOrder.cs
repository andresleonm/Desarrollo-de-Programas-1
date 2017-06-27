using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Diagnostics;

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
            this.cellDateTimePicker.VisibleChanged += new EventHandler(cellDateTimePickerVisibleChanged);
            this.cellDateTimePicker.Visible = false;
            this.grid_order_lines.Controls.Add(cellDateTimePicker);            
        }

        void cellDateTimePickerValueChanged(object sender, EventArgs e) // coloca la fecha en la celda correspondiente
        {
            grid_order_lines.CurrentRow.Cells[0].Value = cellDateTimePicker.Value.ToShortDateString();
            cellDateTimePicker.Visible = false;
        }

        void cellDateTimePickerVisibleChanged(object sender, EventArgs e)
        {
            if (cellDateTimePicker.Visible && grid_order_lines.CurrentRow != null)
            {
                grid_order_lines.CurrentRow.Cells[0].Value = cellDateTimePicker.Value.ToShortDateString();                
            }
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
            grid_order_lines.Rows.Clear();
            loadLists();
            loadCombos();
            editing_order = order;
            txt_id.Text = order.Id.ToString();
            txt_external_number.Text = order.External_number;            
            date_order_date.Text = order.Creation_date.ToShortDateString();            
                        
            txt_state.Text = order.State;

            foreach (Models.PurchaseOrderLine line in order.Lines)
            {
                string[] grid_line = new string[8];
                grid_line[0] = line.Scheluded_date.ToShortDateString();
                grid_line[1] = materials.Find(m => m.Id == line.Material).Name;
                grid_line[2] = line.Quantity.ToString();
                grid_line[3] = line.Deliver_quantity.ToString();
                grid_line[4] = units_of_measure.Find(uom => uom.Id == line.Unit_of_measure).Name;
                grid_line[5] = warehouses.Find(w => w.Id == line.Warehouse).Name;
                grid_line[6] = line.Price.ToString();
                grid_line[7] = (line.Quantity * line.Price).ToString();
                grid_order_lines.Rows.Add(grid_line);
            }
            calculateCosts();
            this.Visible = true;
            combo_supplier.Text = order.Supplier_name;
            combo_currency.Text = currencies.Find(c => c.Id == order.Currency_id).Name;
        }

        private void grid_order_lines_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txt_no_taxes.Text = (Double.Parse(txt_no_taxes.Text) + (Double.Parse(grid_order_lines.Rows[grid_order_lines.Rows.Count].Cells[6].Value.ToString())) / 1.18).ToString();
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
            if (String.IsNullOrWhiteSpace(txt_total.Text))
            {
                btn_calculate.PerformClick();
            }
            Controller.PurchaseOrderController po_controller = new Controller.PurchaseOrderController("dp1admin", "dp1admin");
            Controller.PurchaseOrderLineController pol_controller = new Controller.PurchaseOrderLineController("dp1admin", "dp1admin");
            Models.PurchaseOrder po = new Models.PurchaseOrder();
            po.Id = 0;
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
            po.Currency_id = currencies.Find(c => c.Name == combo_currency.Text).Id;       
            if (editing)
            {
                bool edited = false;
                po.Id = Int32.Parse(txt_id.Text);
                Controller.Result r = po_controller.updatePurchaseOrder(po);
                if (r.success) edited = true;
                for (int i = 0; i < grid_order_lines.RowCount - 1; i++)
                {
                    if (i < editing_order.Lines.Count)
                    {
                        int unit_of_measure_id = units_of_measure.Find(uom => uom.Name == grid_order_lines.Rows[i].Cells[4].Value.ToString()).Id;
                        int material_id = materials.Find(m => m.Name == grid_order_lines.Rows[i].Cells[1].Value.ToString()).Id;
                        int warehouse_id = warehouses.Find(w => w.Name == grid_order_lines.Rows[i].Cells[5].Value.ToString()).Id;
                        Models.PurchaseOrderLine pol = new Models.PurchaseOrderLine(editing_order.Lines[i].Id, po.Id, unit_of_measure_id, Int32.Parse(grid_order_lines.Rows[i].Cells[2].Value.ToString())
                                                            , Double.Parse(grid_order_lines.Rows[i].Cells[7].Value.ToString()), DateTime.Parse(grid_order_lines.Rows[i].Cells[0].Value.ToString()), editing_order.Lines[i].State,
                                                            Int32.Parse(grid_order_lines.Rows[i].Cells[3].Value.ToString()), material_id, warehouse_id, double.Parse(grid_order_lines.Rows[i].Cells[6].Value.ToString()));
                        Controller.Result result = pol_controller.updatePurchaseOrderLine(pol);                        
                        edited = result.success ? true : false;
                    }
                    else
                    {
                        int unit_of_measure_id = units_of_measure.Find(uom => uom.Name == grid_order_lines.Rows[i].Cells[4].Value.ToString()).Id;
                        int material_id = materials.Find(m => m.Name == grid_order_lines.Rows[i].Cells[1].Value.ToString()).Id;
                        int warehouse_id = warehouses.Find(w => w.Name == grid_order_lines.Rows[i].Cells[5].Value.ToString()).Id;
                        Models.PurchaseOrderLine pol = new Models.PurchaseOrderLine(po.Id,unit_of_measure_id, Int32.Parse(grid_order_lines.Rows[i].Cells[2].Value.ToString())
                                                            , Double.Parse(grid_order_lines.Rows[i].Cells[7].Value.ToString()), DateTime.Parse(grid_order_lines.Rows[i].Cells[0].Value.ToString()),
                                                            Int32.Parse(grid_order_lines.Rows[i].Cells[3].Value.ToString()), material_id, warehouse_id, double.Parse(grid_order_lines.Rows[i].Cells[6].Value.ToString()));
                    }
                }
                if (edited)
                {
                    MessageBox.Show("Orden editada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo editar la orden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                int po_id = Int32.Parse(po_controller.insertPurchaseOrder(po).data.ToString());
                for (int i = 0; i < grid_order_lines.RowCount - 1; i++)
                {
                    int unit_of_measure_id = units_of_measure.Find(uom => uom.Name == grid_order_lines.Rows[i].Cells[4].Value.ToString()).Id;
                    int material_id = materials.Find(m => m.Name == grid_order_lines.Rows[i].Cells[1].Value.ToString()).Id;
                    int warehouse_id = warehouses.Find(w => w.Name == grid_order_lines.Rows[i].Cells[5].Value.ToString()).Id;
                    if(grid_order_lines.Rows[i].Cells[3].Value == null)
                    {
                        grid_order_lines.Rows[i].Cells[3].Value = 0;
                    }
                    Models.PurchaseOrderLine pol = new Models.PurchaseOrderLine(po_id, unit_of_measure_id, Int32.Parse(grid_order_lines.Rows[i].Cells[2].Value.ToString())
                                                        , Double.Parse(grid_order_lines.Rows[i].Cells[7].Value.ToString()), DateTime.Parse(grid_order_lines.Rows[i].Cells[0].Value.ToString()),
                                                        Int32.Parse(grid_order_lines.Rows[i].Cells[3].Value.ToString()),material_id, warehouse_id, double.Parse(grid_order_lines.Rows[i].Cells[6].Value.ToString()));
                    Controller.Result result = pol_controller.insertPurchaseOrderLine(pol);
                    if (result.success)
                    {
                        MessageBox.Show("Orden creada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear la orden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }                                    
        }

        private void UC_PurchaseOrder_Load(object sender, EventArgs e)
        {
            Controller.ParametersController param_controller = new Controller.ParametersController("dp1admin", "dp1admin");
            Controller.Result result = param_controller.getParameters();
            List<Models.Parameters> parameters = (List<Models.Parameters>)result.data;
            lbl_igv.Text = (Double.Parse(parameters.Where(p => p.Name == "IGV").ElementAt(0).Value) * 100).ToString();

            loadLists();
            loadCombos();                    

            txt_taxes.Text = "0";
            txt_total.Text = "0";
            txt_total.Text = "0";
            txt_state.Text = "Registrado";                                    
        }

        private void grid_order_lines_CellContentClick(object sender, DataGridViewCellEventArgs e) // añade un datetimepicker a la grilla
        {
            if (e.ColumnIndex == 0)

            {
                System.Drawing.Rectangle tempRect = grid_order_lines.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
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

                    grid_order_lines.Rows[e.RowIndex].Cells[4].Value =
                        units_of_measure.Find(uom => uom.Id ==
                            materials.Find(m => m.Name == grid_order_lines.Rows[e.RowIndex].Cells[1].Value.ToString()).Unit_id).Name;

                    grid_order_lines.Rows[e.RowIndex].Cells[6].Value = avg_cost;                 
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

        private void loadCombos()
        {
            foreach (Models.Material m in materials)
            {
                ((DataGridViewComboBoxColumn)grid_order_lines.Columns["material"]).Items.Add(m.Name);
            }                                                  

            foreach (Models.MaterialWarehouse w in warehouses)
            {
                ((DataGridViewComboBoxColumn)grid_order_lines.Columns["warehouse"]).Items.Add(w.Name);
            }

            combo_supplier.Items.Clear();
            combo_currency.Items.Clear();
            foreach(Models.Supplier s in suppliers)
            {
                combo_supplier.Items.Add(s.Name);
            }

            foreach(Models.Currency c in currencies)
            {
                combo_currency.Items.Add(c.Name);
            }
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
                grid_order_lines.Rows[i].Cells[7].Value = double.Parse(grid_order_lines.Rows[i].Cells[2].Value.ToString()) * double.Parse(grid_order_lines.Rows[i].Cells[6].Value.ToString());
                grid_order_lines.Rows[i].Cells[7].Value = double.Parse(grid_order_lines.Rows[i].Cells[7].Value.ToString()) - double.Parse(grid_order_lines.Rows[i].Cells[7].Value.ToString()) * (Double.Parse(lbl_igv.Text) / 100);
                taxes = taxes + double.Parse(grid_order_lines.Rows[i].Cells[7].Value.ToString()) * (Double.Parse(lbl_igv.Text)/100);
                no_taxes = no_taxes + Double.Parse(grid_order_lines.Rows[i].Cells[grid_order_lines.Rows[i].Cells.Count - 1].Value.ToString());
                total = total + no_taxes + taxes;
            }

            txt_taxes.Text = taxes.ToString();
            txt_total.Text = total.ToString();
            txt_no_taxes.Text = no_taxes.ToString();
        }

        public void cleanForm()
        {
            txt_address.Text = "";
            txt_external_number.Text = "";
            txt_no_taxes.Text = "";
            txt_observation.Text = "";
            txt_state.Text = "Registrado";
            txt_supplier_doi.Text = "";
            txt_supplier_phone.Text = "";
            txt_taxes.Text = "";
            txt_total.Text = "";
            txt_id.Text = "";
            grid_order_lines.Rows.Clear();
        }

        private void grid_order_lines_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //double avg_cost;
            //if (grid_order_lines.Rows[e.RowIndex].Cells[2].Value != null && grid_order_lines.Rows[e.RowIndex].Cells[6].Value != null) {
            //    avg_cost = materials.Find(m => m.Name == grid_order_lines.Rows[e.RowIndex].Cells[1].Value.ToString()).Average_cost;
            //    grid_order_lines.Rows[e.RowIndex].Cells[7].Value =
            //        Double.Parse(grid_order_lines.Rows[e.RowIndex].Cells[2].Value.ToString()) * avg_cost;
            //    calculateCosts();
            //}
        }

        private void btn_Pdf_Click(object sender, EventArgs e)
        {
            if (editing)
                To_pdf(editing_order);
            else
                MessageBox.Show(this, "Debe haber seleccionado un documento, primero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void To_pdf(Models.PurchaseOrder sd)
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;            
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                string date = DateTime.Now.ToString();

                Chunk chunk = new Chunk("Orden de Compra " + "N° " + sd.Id.ToString(), FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("Proveedor              " + sd.Supplier_name.ToUpper(), FontFactory.GetFont("ARIAL", 16, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("                                        Dirección: " + sd.Supplier_address));
                doc.Add(new Paragraph("                                        Teléfono: " + sd.Supplier_phone));                
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("     Fecha: " + date));
                doc.Add(new Paragraph("     Fecha de Emisión: " + sd.Creation_date));                                
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("_________________________________________________________________________________________________________________________"));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerateDocument(doc, grid_order_lines);
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.AddCreationDate();
                doc.Add(new Paragraph("_________________________________________________________________________________________________________________________"));
                doc.Add(new Paragraph("                                                                                                                                                                                            SubTotal   " + (sd.Igv_amount/0.18 - sd.Igv_amount), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("                                                                                                                                                                                                 IGV   " + (sd.Igv_amount * sd.Amount).ToString("0.00"), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("                                                                                                                                                                                                          __________________"));
                doc.Add(new Paragraph("                                                                                                                                                                                               Total   " + ((1 + sd.Amount) * sd.Amount).ToString("0.00"), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("_________________________________________________________________________________________________________________________"));
                doc.Close();
                Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }

        }

        public void GenerateDocument(Document document, DataGridView dgv)
        {
            int i, j;
            int visibleColums = getColumsVisible(dgv);
            PdfPTable datatable = new PdfPTable(visibleColums);
            datatable.DefaultCell.Padding = 3;

            float[] headerwidths = GetSizeColumn(dgv, visibleColums);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 0;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            for (i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Columns[i].Visible == true && !dgv.Columns[i].HeaderText.Equals("Almacen"))
                    datatable.AddCell(new Phrase(dgv.Columns[i].HeaderText, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
            }

            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 0;
            for (i = 0; i < dgv.Rows.Count; i++)
            {
                for (j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv[j, i].Value != null && (dgv.Columns[j].Visible == true) && !dgv.Columns[j].HeaderText.Equals("Almacen"))
                    {
                        datatable.AddCell(new Phrase(dgv[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }

        private int getColumsVisible(DataGridView dgv)
        {
            int quantity = 0;
            for (int i = 0; i < dgv.ColumnCount; i++)
                if (dgv.Columns[i].Visible == true && !dgv.Columns[i].HeaderText.Equals("Almacen")) quantity++;

            return quantity;
        }

        private float[] GetSizeColumn(DataGridView dgv, int colums)
        {
            float[] values = new float[colums];
            int j = 0;
            for (int i = 0; i < dgv.ColumnCount; i++)
                if (dgv.Columns[i].Visible == true && !dgv.Columns[i].HeaderText.Equals("Almacen"))
                {
                    values[j] = (float)dgv.Columns[i].Width;
                    j++;
                }
            return values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculateCosts();            
        }

        private void grid_order_lines_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            
            tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);

            e.Control.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
        }


        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void grid_order_lines_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                
            }
        }

        private void grid_order_lines_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell.ColumnIndex == 6)
            {
                try
                {
                    DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
                    tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);

                    e.Control.KeyPress += new KeyPressEventHandler(grid_order_pu_KeyPress);
                }
                catch
                {
                }
            }
            else if (((DataGridView)sender).CurrentCell.ColumnIndex == 2)
            {
                try
                {
                    DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
                    tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);

                    e.Control.KeyPress += new KeyPressEventHandler(grid_order_q_KeyPress);
                }
                catch 
                {
                }
            }
                        
        }

        private void grid_order_pu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void grid_order_q_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }            
        }

    }
}
