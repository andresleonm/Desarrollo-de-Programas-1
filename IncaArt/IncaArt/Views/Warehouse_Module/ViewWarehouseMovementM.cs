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
    public partial class ViewWarehouseMovementM : Form
    {
        string user;
        string password;
        MaterialMovementController pc;
        PurchaseOrderController soc;
        Models.MaterialMovement pm;

        
        public ViewWarehouseMovementM(string user, string password,Models.MaterialMovement movement)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
            pc = new MaterialMovementController(user, password);
            soc = new PurchaseOrderController(user, password);
            fillTypeMovements();
            clearGrid();
            pm = movement;
            this.grid_movement_lines.DataSource=pm.detail;
            this.textbox_observation.Text = pm.Observacion;
            this.fecha.Text = pm.Fecha;
            this.movementid.Text = movement.id.ToString();
            if (movement.State == "Anulado")
            {
                this.btn_Anular.Visible = false;
            }
            types_movements.SelectedIndex = types_movements.FindString(pm.Tipo.name);
            document.Text = pm.TipoDocumentoOrigen + " - "+pm.NroDocumentoOrigen.ToString();
            var mov = movement.Tipo;
            List<int> checkValues = new List<int> { 0, 1, 2 };            
            
            if (checkValues.Contains(mov.clase))
            {

                this.document.Visible = true;
                this.document_input.Visible = true;
                grid_movement_lines.Columns["documentQuantity"].Visible = false;
            }
            else
            {

                grid_movement_lines.Columns["documentQuantity"].Visible = false;
                this.document.Visible = false;
                this.document_input.Visible = false;
            }
            document.Text = pm.TipoDocumentoOrigen + " - " + pm.NroDocumentoOrigen.ToString();
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
      

        

        private void clearGrid()
        {
            List<Models.MaterialMovementLine> emptyStudentDetail = new List<Models.MaterialMovementLine>();
            grid_movement_lines.DataSource = emptyStudentDetail;
        }
        

        private void populateDetail(PurchaseOrder order)
        {
            clearGrid();
            var lines = order.Lines;
            var movs_lines = new List<Models.MaterialMovementLine>();
            int i = 1;
            foreach (PurchaseOrderLine line in lines)
            {
                movs_lines.Add(new Models.MaterialMovementLine(line, i,user,password));
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
            else if (clase == 2)
                return "ORDEN_DE_PRODUCCION";
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
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = pc.cancelMovement(Int32.Parse(movementid.Text));
            if (result.success)
            {
                MessageBox.Show("El documento fue anulado satisfactoriamente");
            }
            else
                MessageBox.Show(result.message);
            this.Close();
        }
    }
}
