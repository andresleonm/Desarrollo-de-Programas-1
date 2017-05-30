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
    public partial class ViewWarehouseMovementP : Form
    {
        string user;
        string password;
        ProductMovementController pc;
        SalesOrderController soc;
        bool flgBegin = true;
        int claseAnt = -1;
        string idAnt;
        Models.ProductMovement pm;

        
        public ViewWarehouseMovementP(string user, string password,Models.ProductMovement movement)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
            pc = new ProductMovementController(user, password);
            soc = new SalesOrderController(user, password);
            fillTypeMovements();
            clearGrid();
            pm = movement;            
        }
        public void fillTypeMovements()
        {
            ProductMovementController pc = new ProductMovementController(user, password);
            List<ProductMovementType> movs = (List<ProductMovementType>)pc.getMovementTypes().data;
            this.types_movements.DataSource = movs;
            this.types_movements.DisplayMember = "name";

            // make it readonly
            this.types_movements.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void cleanAll()
        {

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

                this.documents_list.Visible = true;
                this.document_input.Visible = true;
                grid_movement_lines.Columns["documentQuantity"].Visible = true;
                populate_document_combo_box(mov.clase);
                flgBegin = true;
            }
            else
            {

                grid_movement_lines.Columns["documentQuantity"].Visible = false;
                this.documents_list.Visible = false;
                this.document_input.Visible = false;
            }

            claseAnt = mov.clase;

        }

        private void populateDetail(SalesOrder order)
        {
            clearGrid();
            var lines = order.Lines;
            var movs_lines = new List<Models.ProductMovementLine>();
            int i = 1;
            foreach (SalesOrderLine line in lines)
            {
                movs_lines.Add(new Models.ProductMovementLine(line, i,user,password));
                i++;
            }
            this.grid_movement_lines.DataSource = movs_lines;
        }

        private void documents_list_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            }
            else if (clase == 2)
                return "ORDEN_DE_PRODUCCION";
            return "";
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            List<Models.ProductMovementLine> lines = new List<Models.ProductMovementLine>();
            ProductMovementLine order_line = new ProductMovementLine(ref lines, user, password);
            order_line.ShowDialog();

            List<Models.ProductMovementLine> current = (List<Models.ProductMovementLine>)this.grid_movement_lines.DataSource;
            current = current.Concat(lines).ToList();
            this.grid_movement_lines.DataSource = current;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }


    }
}