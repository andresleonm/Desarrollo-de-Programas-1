﻿using System;
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
            AdjustColumnOrder();
            fillTypeMovements();
            clearGrid();
            AdjustColumnOrder();
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
            grid_movement_lines.Columns["quantity"].DisplayIndex = 4;
            grid_movement_lines.Columns["documentQuantity"].DisplayIndex = 5;
            grid_movement_lines.Columns["action"].DisplayIndex = 6;
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
                this.action.Visible = false;
                grid_movement_lines.Columns["documentQuantity"].Visible = true;
                populate_document_combo_box(mov.clase);
                flgBegin = true;
            }else            
            {
                this.buttonAddRow.Visible = true;
                grid_movement_lines.Columns["documentQuantity"].Visible = false;
                this.documents_list.Visible = false;
                this.document_input.Visible = false;
                this.action.Visible = true;
            }

            claseAnt = mov.clase;

        }

        private void  populateDetail(SalesOrder order)
        {
            clearGrid();
            var lines = order.Lines;
            var movs_lines = new List<Models.ProductMovementLine>();
            int i = 1;
            foreach(SalesOrderLine line in lines)
            {
                movs_lines.Add(new Models.ProductMovementLine(line, i,user,password));
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
                var clase = ((ProductMovementType)this.types_movements.SelectedItem).clase;
                List<int> checkValues = new List<int> { 3,4 };
                if (doc==null || (clase == claseAnt && idAnt == doc.id) || checkValues.Contains(clase)) return;
                
                if (clase == 0)
                {
                    var Order = (Models.SalesOrder)soc.getSalesOrder(Int32.Parse(doc.id)).data;
                    populateDetail(Order);
                }
                else
                {
                    //

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
            List <Models.ProductMovementLine> detail= (List<Models.ProductMovementLine>) this.grid_movement_lines.DataSource;
            if (detail==null || detail.Count == 0 || allIsZero(detail))
            {
                MessageBox.Show("Seleccione por lo menos una linea con cantidad diferente de 0");
                return;
            }

            if (!allGreatherThanZero(detail))
            {
                MessageBox.Show("Las cantidades deben ser mayores a 0");
                return;
            }
            Models.ProductMovement movement= new Models.ProductMovement();
            movement.detail = detail;
            var doc = (Document)this.documents_list.SelectedItem;
            var tipo = ((ProductMovementType)this.types_movements.SelectedItem);
            movement.Tipo = tipo;
            movement.Fecha = date.Value.ToString("MM/dd/yyyy");
            movement.Observacion = textbox_observation.Text.ToString();
            movement.TipoDocumentoOrigen = getTipo(tipo.clase);
            if (doc!=null)
                movement.NroDocumentoOrigen = doc.id;
            
            Result r =pc.insertMovement(movement);
            if (r.success)
            {
                MessageBox.Show("Se creo el movimiento Nro - " + r.data.ToString());
            }else
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
            ProductMovement currentObject = (ProductMovement)movements_grid.CurrentRow.DataBoundItem;
            if (currentObject == null)
                MessageBox.Show("Seleccione el movimiento que desea visualizar");
            currentObject = (ProductMovement)pc.getMovement(currentObject.id).data;
            ViewWarehouseMovementP order_line = new ViewWarehouseMovementP(user, password, currentObject);
            order_line.ShowDialog();
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
    }
}
