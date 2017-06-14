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
        string user;
        string password;
        ProductMovementController pc;
        SalesOrderController soc;
        SalesRefundLineController src;
        ProductionOrderProductLineController prc;
        bool flgBegin=true;
        int claseAnt=-1;
        string idAnt;
        public UC_WarehouseMovementP(string user, string password)
        { 
            InitializeComponent();
            this.user = user;
            this.password = password;
            pc = new ProductMovementController(user, password);
            soc= new SalesOrderController(user, password);
            src = new SalesRefundLineController(user, password);
            prc = new ProductionOrderProductLineController(user, password);
            AdjustColumnOrder();
            fillTypeMovements();
            clearGrid();
            AdjustColumnOrder();
            hour.ShowUpDown = true;
            hour.Format = DateTimePickerFormat.Custom;
            hour.CustomFormat = "HH:mm tt";
            hour.Value = DateTime.Now.Date;
            
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
                flgBegin = true;
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

        private void populateDetail(List<Models.ProductionOrderProductLine> production)
        {
            clearGrid();
            if (production == null)
                return;
            
            var lines = production;
            var movs_lines = new List<Models.ProductMovementLine>();
            int i = 1;
            foreach (Models.ProductionOrderProductLine line in lines)
            {
                if (line.Quantity_warehouse - line.Produced_quantity != 0)
                {
                    movs_lines.Add(new Models.ProductMovementLine(line, i, user, password));
                    i++;
                }
            }
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
                    var productionLines = (List<Models.ProductionOrderProductLine>)prc.getProductLines(Int32.Parse(doc.id)).data;
                    populateDetail(productionLines);
                }
                claseAnt = clase;
                idAnt = doc.id;
         

            flgBegin = false;
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
            }catch(Exception exc)
            {

            }
           
        }

        private void buttonSearchV_Click(object sender, EventArgs e)
        {
            var movements = (List<ProductMovement>)pc.getMovements().data;
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
                catch (Exception excp)
                {
                    grid_movement_lines.DataSource = new List<Models.ProductMovementLine>();
                    return;
                }
            }
            catch (Exception excp)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Kardex kardex = new Kardex();
            kardex.ShowDialog();
        }
    }
}
