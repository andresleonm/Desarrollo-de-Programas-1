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
    public partial class UC_WarehouseMovementM : UserControl
    {
        string user;
        string password;
        MaterialMovementController pc;
        PurchaseOrderController poc;
        PurchaseOrderLineController pocl;
        ProductionOrderMaterialLineController pomlc;
        bool flgBegin = true;
        int claseAnt = -1;
        string idAnt;
        public UC_WarehouseMovementM(string user, string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
            pc = new MaterialMovementController(user, password);
            poc = new PurchaseOrderController(user, password);
            pocl = new PurchaseOrderLineController(user, password);
            pomlc = new ProductionOrderMaterialLineController(user, password);
            AdjustColumnOrder();
            fillTypeMovements();
            clearGrid();
            AdjustColumnOrder();
        }
        public void fillTypeMovements()
        {
            MaterialMovementController pc = new MaterialMovementController(user, password);
            List<MaterialMovementType> movs = (List<MaterialMovementType>)pc.getMovementTypes().data;
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

            grid_movement_lines.Columns["material"].DisplayIndex = 0;
            grid_movement_lines.Columns["unit"].DisplayIndex = 1;
            grid_movement_lines.Columns["warehouse"].DisplayIndex = 2;
            grid_movement_lines.Columns["stock"].DisplayIndex = 3;
            grid_movement_lines.Columns["quantity"].DisplayIndex = 4;
            grid_movement_lines.Columns["documentQuantity"].DisplayIndex = 5;
            grid_movement_lines.Columns["action"].DisplayIndex = 6;
        }

        private void populate_document_combo_box(int clase)
        {
            List<Document> documents = (List<Document>)pc.getDocuments(clase).data;
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
            List<Models.MaterialMovementLine> emptyStudentDetail = new List<Models.MaterialMovementLine>();
            grid_movement_lines.DataSource = emptyStudentDetail;
        }
        private void combobox_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mov = (MaterialMovementType)this.types_movements.SelectedItem;
            List<int> checkValues = new List<int> { 0, 1 };
            clearDocuments();
            clearGrid();
            if (checkValues.Contains(mov.clase))
            {
                this.buttonAddRow.Visible = false;
                this.documents_list.Visible = true;
                this.document_input.Visible = true;
                this.action.Visible = false;
                grid_movement_lines.Columns["documentQuantity"].Visible = true;
                populate_document_combo_box(mov.clase);
                flgBegin = true;
            } else
            {
                this.buttonAddRow.Visible = true;
                grid_movement_lines.Columns["documentQuantity"].Visible = false;
                this.documents_list.Visible = false;
                this.document_input.Visible = false;
                this.action.Visible = true;
            }

            claseAnt = mov.clase;

        }

        private void populateDetail(PurchaseOrder order)
        {
            clearGrid();
            var lines = order.Lines;
            var movs_lines = new List<Models.MaterialMovementLine>();
            int i = 1;
            foreach (PurchaseOrderLine line in lines)
            {
                movs_lines.Add(new Models.MaterialMovementLine(line, i, user, password));
                i++;
            }
            this.grid_movement_lines.DataSource = movs_lines;
            AdjustColumnOrder();
        }

        private void populateDetail(List<ProductionOrderMaterialLine> production)
        {
            clearGrid();
            var lines = production;
            var movs_lines = new List<Models.MaterialMovementLine>();
            int i = 1;
            foreach (ProductionOrderMaterialLine line in lines)
            {
                movs_lines.Add(new Models.MaterialMovementLine(line, i, user, password));
                i++;
            }
            this.grid_movement_lines.DataSource = movs_lines;
            AdjustColumnOrder();
        }

        private void documents_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (flgBegin)
            {

                var doc = (Document)this.documents_list.SelectedItem;
                var clase = ((MaterialMovementType)this.types_movements.SelectedItem).clase;
                List<int> checkValues = new List<int> { 2, 3 };
                if (doc == null  || (clase == claseAnt && idAnt == doc.id) || checkValues.Contains(clase)) return;

                if (clase == 0)
                {
                    var productionLines = (List<Models.ProductionOrderMaterialLine>)pomlc.getMaterialLines(Int32.Parse(doc.id)).data;
                    populateDetail(productionLines);
                }
                else
                {
                    var purchase = (Models.PurchaseOrder)poc.getPurchaseOrder(Int32.Parse(doc.id)).data;
                    purchase.Lines = (List<Models.PurchaseOrderLine>)pocl.getPurchaseOrderLines(purchase.Id).data;
                    populateDetail(purchase);
                }
                claseAnt = clase;
                idAnt = doc.id;
            }

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
                return "ORDEN_DE_PRODUCCION";
            }
            else if (clase == 1)
            {
                return "ORDEN_DE_COMPRA";
            }

            return "";
        }



        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            List<Models.MaterialMovementLine> lines = new List<Models.MaterialMovementLine>();
            MaterialMovementLine order_line = new MaterialMovementLine(ref lines, user, password);
            order_line.ShowDialog();

            List<Models.MaterialMovementLine> current = (List<Models.MaterialMovementLine>)this.grid_movement_lines.DataSource;
            current = current.Concat(lines).ToList();
            this.grid_movement_lines.DataSource = current;
            AdjustColumnOrder();
        }

        private bool allIsZero(List<Models.MaterialMovementLine> lines)
        {
            foreach (Models.MaterialMovementLine line in lines)
            {
                if (line.quantity != 0)
                    return false;
            }
            return true;
        }

        private bool allGreatherThanZero(List<Models.MaterialMovementLine> lines)
        {
            foreach (Models.MaterialMovementLine line in lines)
            {
                if (line.quantity < 0)
                    return false;
            }
            return true;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            List<Models.MaterialMovementLine> detail = (List<Models.MaterialMovementLine>)this.grid_movement_lines.DataSource;
            if (detail == null || detail.Count == 0 || allIsZero(detail))
            {
                MessageBox.Show("Seleccione por lo menos una linea con cantidad mayor a 0");
                return;
            }
            if (!allGreatherThanZero(detail))
            {
                MessageBox.Show("Las cantidades deben ser mayores a 0");
                return;
            }
            Models.MaterialMovement movement = new Models.MaterialMovement();
            movement.detail = detail;
            var doc = (Document)this.documents_list.SelectedItem;
            var tipo = ((MaterialMovementType)this.types_movements.SelectedItem);
            movement.Tipo = tipo;
            movement.Fecha = date.Value.ToString("MM/dd/yyyy");
            movement.Observacion = textbox_observation.Text.ToString();
            movement.TipoDocumentoOrigen = getTipo(tipo.clase);
            if (doc != null)
                movement.NroDocumentoOrigen = doc.id;

            Result r = pc.insertMovement(movement);
            if (r.success)
            {
                MessageBox.Show("Se creo el movimiento Nro - " + r.data.ToString());
            }
            else
            {
                MessageBox.Show(r.message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MaterialMovement currentObject = (MaterialMovement)movements_grid.CurrentRow.DataBoundItem;
            if (currentObject == null)
                MessageBox.Show("Seleccione el movimiento que desea visualizar");
            currentObject = (MaterialMovement)pc.getMovement(currentObject.id).data;
            ViewWarehouseMovementM order_line = new ViewWarehouseMovementM(user, password, currentObject);
            order_line.ShowDialog();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var movements = (List<MaterialMovement>)pc.getMovements().data;
            movements_grid.DataSource = movements;

        }

        private void consulta_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewV_Click(object sender, EventArgs e)
        {
            MaterialMovement currentObject = (MaterialMovement)movements_grid.CurrentRow.DataBoundItem;
            if (currentObject == null)
                MessageBox.Show("Seleccione el movimiento que desea visualizar");
            currentObject = (MaterialMovement)pc.getMovement(currentObject.id).data;

            ViewWarehouseMovementM order_line = new ViewWarehouseMovementM(user, password, currentObject);
            order_line.ShowDialog();
        }

        private void buttonSearchV_Click(object sender, EventArgs e)
        {
            var movements = (List<MaterialMovement>)pc.getMovements().data;
            movements_grid.DataSource = movements;
        }

        private void buttonCleanV_Click(object sender, EventArgs e)
        {
            var movements =new List<MaterialMovement>();
            movements_grid.DataSource = movements;

        }
    }
}
