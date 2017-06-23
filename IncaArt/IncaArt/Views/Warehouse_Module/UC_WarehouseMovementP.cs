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
namespace WindowsFormsApp1.Views.Warehouse_Module
{
    public partial class UC_WarehouseMovementP : UserControl
    {
        string user = "dp1admin";
        string password = "dp1admin";
        ProductMovementController pc;
        SalesOrderController soc;
        SalesRefundLineController src;
        ProductionOrderController prc;

        int claseAnt=-1;
        string idAnt;
        public UC_WarehouseMovementP()
        { 
            InitializeComponent();
            pc = new ProductMovementController("", "");
            soc= new SalesOrderController("", "");
            src = new SalesRefundLineController("", "");
            prc = new ProductionOrderController("", "");
            AdjustColumnOrder();
            fillTypeMovements();
            clearGrid();
            AdjustColumnOrder();
            hour.ShowUpDown = true;
            hour.Format = DateTimePickerFormat.Custom;
            hour.CustomFormat = "HH:mm tt";
            hour.Value = DateTime.Now.Date;
            Clean();
            Clean();

        }
        public void fillTypeMovements()
        {
            ProductMovementController pc = new ProductMovementController(user,password);
            List<ProductMovementType> movs = (List<ProductMovementType>)pc.getMovementTypes().data;
            this.types_movements.DataSource = movs;
            this.types_movements.DisplayMember = "name";

            // make it readonly
            this.types_movements.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void cleanAll()
        {

        }

        private void AdjustColumnOrder()
        {

            grid_movement_lines.Columns["product"].DisplayIndex = 0;
            grid_movement_lines.Columns["unit"].DisplayIndex = 1;
            grid_movement_lines.Columns["warehouse"].DisplayIndex = 2;
            grid_movement_lines.Columns["stock"].DisplayIndex = 3;
            grid_movement_lines.Columns["documentQuantity"].DisplayIndex = 4;
            grid_movement_lines.Columns["quantity"].DisplayIndex = 5;
        }

        private void populate_document_combo_box(int clase)
        {
            List<Document> documents=(List<Document>)pc.getDocuments(clase).data;
            this.documents_list.DataSource = documents;
            this.documents_list.DisplayMember = "name";
            this.documents_list.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void clearDocuments()
        {
            documents_list.DataSource = null;
            documents_list.DisplayMember = null;
            documents_list.ValueMember = null;
        }

        private void clearGrid()
        {
            List<Models.ProductMovementLine> emptyStudentDetail = new List<Models.ProductMovementLine>();
            grid_movement_lines.DataSource = emptyStudentDetail;
        }
        private void combobox_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mov = (ProductMovementType)this.types_movements.SelectedItem;
            List<int> checkValues = new List<int> { 0, 1, 2 };
            clearDocuments();
            clearGrid();
            if (checkValues.Contains(mov.clase))
            {
                this.buttonAddRow.Visible = false;
                this.documents_list.Visible = true;
                this.document_input.Visible = true;
                this.btn_delete.Visible = false;
                grid_movement_lines.Columns["documentQuantity"].Visible = true;
                populate_document_combo_box(mov.clase);
                
            }else            
            {
                this.btn_delete.Visible = true;
                this.buttonAddRow.Visible = true;
                grid_movement_lines.Columns["documentQuantity"].Visible = false;
                this.documents_list.Visible = false;
                this.document_input.Visible = false;
            }

            claseAnt = mov.clase;

        }

        private void  populateDetail(SalesOrder order)
        {
            clearGrid();
            if (order == null)
                return;
            var lines = order.Lines;
            var movs_lines = new List<Models.ProductMovementLine>();
            int i = 1;
            foreach(SalesOrderLine line in lines)
            {
                if (line.Delivery_quantity - line.Quantity != 0)
                {
                    movs_lines.Add(new Models.ProductMovementLine(line, i,user,password));
                    i++;
                 }
            }
            this.grid_movement_lines.DataSource = movs_lines;
            AdjustColumnOrder();
        }

        private void populateDetail(Models.ProductionOrder production)
        {
            clearGrid();
            if (production == null)
                return;
            
            var lines = production;
            var movs_lines = new List<Models.ProductMovementLine>();
            int i = 1;
           
            movs_lines.Add(new Models.ProductMovementLine(production, i, user, password));
             
            this.grid_movement_lines.DataSource = movs_lines;
            AdjustColumnOrder();
        }

        private void populateDetail(List<Models.SalesRefundLine> production)
        {
            clearGrid();
            if (production == null)
                return;            
            var lines = production;
            var movs_lines = new List<Models.ProductMovementLine>();
            int i = 1;
            foreach (Models.SalesRefundLine line in lines)
            {
                if (line.Refund_quantity - line.Quantity != 0)
                {
                    movs_lines.Add(new Models.ProductMovementLine(line, i, user, password));
                    i++;
                }
            }
            this.grid_movement_lines.DataSource = movs_lines;
            AdjustColumnOrder();
        }

        private void documents_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
             
                var doc = (Document)this.documents_list.SelectedItem;
                var clase = ((ProductMovementType)this.types_movements.SelectedItem).clase;
                List<int> checkValues = new List<int> { 3,4 };
                if (doc==null || (clase == claseAnt && idAnt == doc.id) || checkValues.Contains(clase)) return;
                
                if (clase == 0)
                {
                    var Order = (Models.SalesOrder)soc.getSalesOrder(Int32.Parse(doc.id)).data;
                    populateDetail(Order);
                }
                else if (clase==1)
                {
                    var lines = (List<Models.SalesRefundLine> )src.getSalesRefundLines(Int32.Parse(doc.id)).data;
                    populateDetail(lines);
                }else if (clase == 2)
                {
                    var production = (Models.ProductionOrder)prc.getProductionOrder(Int32.Parse(doc.id)).data;
                    populateDetail(production);
                }
                claseAnt = clase;
                idAnt = doc.id;
         

          
            Cursor.Current = Cursors.Default;
        }

        private void textbox_observation_Click(object sender, EventArgs e)
        {

        }

        private void grid_movement_lines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gb_OrderLine_Enter(object sender, EventArgs e)
        {

        }

        private void grid_order_lines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string getTipo(int clase)
        {
            if (clase == 0)
            {
                return "PEDIDO";
            }
            else if (clase == 1)
            {
                return "DEVOLUCION";
            }else if (clase==2)
                return "ORDEN_DE_PRODUCCION";
            return "";
        }

       

        

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            List<Models.ProductMovementLine> lines = new List<Models.ProductMovementLine>();
            ProductMovementLine order_line = new ProductMovementLine(ref lines,user,password);
            order_line.ShowDialog();

            List <Models.ProductMovementLine> current= (List<Models.ProductMovementLine>) this.grid_movement_lines.DataSource;
            current=current.Concat(lines).ToList();
            this.grid_movement_lines.DataSource = current;
            AdjustColumnOrder();
        }
        private bool allIsZero(List<Models.ProductMovementLine> lines)
        {
            foreach(Models.ProductMovementLine line in lines)
            {
                if (line.quantity != 0)
                    return false;               
            }
            return true;
        }

        private bool allGreatherThanZero(List<Models.ProductMovementLine> lines)
        {
            foreach (Models.ProductMovementLine line in lines)
            {
                if (line.quantity < 0)
                    return false;
            }
            return true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            List<Models.ProductMovementLine> detail = (List<Models.ProductMovementLine>)this.grid_movement_lines.DataSource;
            if (detail == null || detail.Count == 0 || allIsZero(detail))
            {
                MessageBox.Show("Seleccione por lo menos una linea con cantidad diferente de 0");
                return;
            }

            if (!allGreatherThanZero(detail))
            {
                MessageBox.Show("Las cantidades deben ser mayores a 0");
                return;
            }
            Models.ProductMovement movement = new Models.ProductMovement();
            movement.detail = detail;
            var doc = (Document)this.documents_list.SelectedItem;
            var tipo = ((ProductMovementType)this.types_movements.SelectedItem);
            movement.Tipo = tipo;
            DateTime complete_date = date.Value.Date + hour.Value.TimeOfDay;
            movement.Fecha = complete_date.ToString("MM/dd/yyyy hh:mm:ss");
            movement.Observacion = textbox_observation.Text.ToString();
            movement.TipoDocumentoOrigen = getTipo(tipo.clase);
            if (doc != null)
                 movement.NroDocumentoOrigen = doc.id;
            
            Result r =pc.insertMovement(movement);
            if (r.success)
            {
                MessageBox.Show("Se creo el movimiento Nro - " + r.data.ToString());
                btn_Clean.PerformClick();
                metroTabControl1.SelectedIndex = 0;
                buttonSearchV.PerformClick();
            }
            else
            {
                MessageBox.Show(r.message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ProductMovement currentObject = (ProductMovement)movements_grid.CurrentRow.DataBoundItem;
            if (currentObject == null)
                MessageBox.Show("Seleccione el movimiento que desea visualizar");
            currentObject = (ProductMovement)pc.getMovement(currentObject.id).data;
            ViewWarehouseMovementP order_line = new ViewWarehouseMovementP(user, password, currentObject);
            order_line.ShowDialog();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var movements = (List<ProductMovement>)pc.getMovements().data;
            movements_grid.DataSource = movements;

        }

        private void consulta_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewV_Click(object sender, EventArgs e)
        {
            try
            {
                ProductMovement currentObject = (ProductMovement)movements_grid.CurrentRow.DataBoundItem;
                if (currentObject == null)
                    MessageBox.Show("Seleccione el movimiento que desea visualizar");
                currentObject = (ProductMovement)pc.getMovement(currentObject.id).data;
                ViewWarehouseMovementP order_line = new ViewWarehouseMovementP(user, password, currentObject);
                order_line.ShowDialog();
                buttonSearchV.PerformClick();
            }
            catch
            {

            }
           
        }

        private void buttonSearchV_Click(object sender, EventArgs e)
        {
            var movements = (List<ProductMovement>)pc.getMovements(this.metroDateTime1.Value.ToString("yyyy-MM-dd"),
                                this.metroDateTime2.Value.ToString("yyyy-MM-dd")).data;
            if (movements ==null)
                movements=new List<ProductMovement>();
            movements_grid.DataSource = movements;
        }

        private void buttonCleanV_Click(object sender, EventArgs e)
        {
            var movements =new List<ProductMovement>();
            movements_grid.DataSource = movements;

        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
          
            try
            {
                List<Models.ProductMovementLine> data = (List<Models.ProductMovementLine>)grid_movement_lines.DataSource;
                try
                {
                    Models.ProductMovementLine currentObject = (Models.ProductMovementLine)grid_movement_lines.CurrentRow.DataBoundItem;
                    data.Remove(currentObject);
                    data = data.Concat(new List<Models.ProductMovementLine>().ToList()).ToList();
                    grid_movement_lines.DataSource = data;
                }
                catch 
                {
                    grid_movement_lines.DataSource = new List<Models.ProductMovementLine>();
                    return;
                }
            }
            catch
            {
                grid_movement_lines.DataSource = new List<Models.ProductMovementLine>();
                return;
            }            
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            textbox_observation.Text = "";
            date.Text = "";
            hour.Text = "";
            metroDateTime1.Text = "";
            metroDateTime2.Text = "";
            AdjustColumnOrder();
            fillTypeMovements();
            clearGrid();
            AdjustColumnOrder();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            buttonSearchV.PerformClick();
        }


        private int make_move(int sal_ini, string sign, int quantity)
        {
            if (sign == "+")
                return sal_ini + quantity;
            return sal_ini - quantity;
        }
        private void btn_Kardex_Click(object sender, EventArgs e)
        {
            KardexController kc = new KardexController("dp1admin", "dp1admin");
            var lines = (List<KardexLine>)kc.getMovements(this.metroDateTime1.Value.ToString("yyyy-MM-dd"),
                                this.metroDateTime2.Value.ToString("yyyy-MM-dd")).data;



            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Kardex";

                int cellRowIndex = 3;
                int cellColumnIndex = 3;
                int productAnt = 0;

                List<string> headers = new List<string>();



                headers.Add("Almacen");
                headers.Add("Movimiento");
                headers.Add("Cantidad");
                headers.Add("Fecha");


                int saldo_fin = 0;
                //Loop through each row and read value from each column. 
                for (int i = 0; i < lines.Count; i++)
                {
                    if (Int32.Parse(lines[i].codeProduct) != productAnt)
                    {
                        if (productAnt != 0)
                        {
                            cellRowIndex += 1;
                            worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Saldo Final";
                            worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = saldo_fin;
                            cellRowIndex += 2;
                        }
                        saldo_fin = lines[i].sal_ini;
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = "Producto";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 1] = lines[i].product;
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Saldo Inicial";
                        worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = lines[i].sal_ini;
                        cellRowIndex += 1;
                    }

                    for (int j = 0; j < headers.Count; j++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex+1] = lines[i].Cells(j);
                        cellColumnIndex++;
                    }
                    productAnt = Int32.Parse(lines[i].codeProduct);
                    saldo_fin = make_move(saldo_fin, lines[i].sign, lines[i].quantity);
                    cellColumnIndex = 3;
                    cellRowIndex++;
                }

                if (productAnt != 0)
                {
                    cellRowIndex += 1;
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 3] = "Saldo Final";
                    worksheet.Cells[cellRowIndex, cellColumnIndex + 4] = saldo_fin;
                    cellRowIndex += 2;
                }
                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    workbook.Close();
                    MessageBox.Show("Exportado correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }
    }
}
