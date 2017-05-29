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
        public UC_WarehouseMovementP(string user, string password)
        { 
            InitializeComponent();
            this.user = user;
            this.password = password;
            pc = new ProductMovementController(user, password);
            fillTypeMovements();        
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

        private void populate_document_combo_box(int clase)
        {
            List<Document> documents=(List<Document>)pc.getDocuments(clase).data;
            this.types_movements.DataSource = documents;
            this.types_movements.DisplayMember = "name";
            this.types_movements.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void combobox_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mov = (ProductMovementType)this.types_movements.SelectedItem;
            List<int> checkValues = new List<int> { 0, 1, 2 };
            documents_list.Items.Clear();
            if (checkValues.Contains(mov.clase))
            {
                this.buttonAddRow.Visible = false;
                this.documents_list.Visible = true;
                this.document_input.Visible = true;
                populate_document_combo_box(mov.clase);
            }else            
            {
                this.buttonAddRow.Visible = true;
                this.documents_list.Visible = false;
                this.document_input.Visible = false;
            }

            grid_movement_lines.Rows.Clear();

        }
    }
}
