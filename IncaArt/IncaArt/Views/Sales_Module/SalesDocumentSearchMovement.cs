﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controller;


namespace WindowsFormsApp1.Views.Sales_Module
{
    public partial class SalesDocumentSearchMovement : Form
    {
        private char type_document;
        public List<ProductMovement> prodMovementList;
        private ProductMovementController pc;

        public SalesDocumentSearchMovement(ref List<ProductMovement> prodMovement,char type_doc, string user, string password)
        {
            InitializeComponent();
            this.prodMovementList = prodMovement;
            this.type_document = type_doc;
            pc = new ProductMovementController(user, password);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var movements = (List<ProductMovement>)pc.getMovements(type_document).data;
            if (movements == null)
                movements = new List<ProductMovement>();
            grid_Movements.DataSource = movements;
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            var movements = new List<ProductMovement>();
            grid_Movements.DataSource = movements;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int selectedRowCount = grid_Movements.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount <= 0)
            {
                MessageBox.Show(this, "Primero debe seleccionar una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedRowCount > 1)
            {
                MessageBox.Show(this, "Solo debe seleccionar una fila para poder ver el detalle", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedRowCount == 1)
            {
                ProductMovement movement_found = (ProductMovement)grid_Movements.CurrentRow.DataBoundItem;
                prodMovementList.Add(movement_found);
                this.Close();
            }
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}