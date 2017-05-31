using System;
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

namespace WindowsFormsApp1.Views.Warehouse_Module
{
    public partial class MaterialMovementLine : Form
    {
        List<Models.MaterialMovementLine> lines;
        string user;
        string password;
        MaterialsController pc;
        MaterialMovementDetailController dc;
        bool flg = true;
        public void fillmaterials()
        {
            pc = new MaterialsController(user, password);
            dc = new MaterialMovementDetailController(user, password);
            List<Models.Material> materials = (List<Models.Material>)pc.getMaterials().data;
            Models.Material p = new Material();
            p.Name = "Todos";
            p.Id = 0;
            materials.Add(p);
            this.materials.DataSource = materials;
            this.materials.DisplayMember = "name";
            this.materials.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public MaterialMovementLine(ref List<Models.MaterialMovementLine> lines,string user,string password)
        {
            InitializeComponent();
            this.lines = lines;
            this.user = user;
            this.password = password;
            fillmaterials();
        }

        private void materialMovementLine_Load(object sender, EventArgs e)
        {

        }
        private void AdjustColumnOrder()
        {
            
            grid_materials.Columns["material"].DisplayIndex = 0;
            grid_materials.Columns["unit"].DisplayIndex = 1;
            grid_materials.Columns["warehouse"].DisplayIndex = 2;
            grid_materials.Columns["stockF"].DisplayIndex = 3;
            grid_materials.Columns["stockL"].DisplayIndex = 4;
            grid_materials.Columns["capacity"].DisplayIndex = 5;
            grid_materials.Columns["quantity"].DisplayIndex = 6;
            grid_materials.Columns["select"].DisplayIndex = 7;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var material = ((Material)this.materials.SelectedItem).Id;
            List<MaterialWarehouseM> warehouses = (List<MaterialWarehouseM>)dc.getWarehouses(material).data;
            if (!flg)
                grid_materials.DataSource = new List<MaterialWarehouseM>();
            else flg = false;
            grid_materials.DataSource = warehouses;
            AdjustColumnOrder();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            List<MaterialWarehouseM> warehouses = (List<MaterialWarehouseM>)grid_materials.DataSource;
            int i = 0;
            foreach (MaterialWarehouseM warehouse in warehouses)
            {                
                if (warehouse.selected)
                {
                    lines.Add(new Models.MaterialMovementLine(user,password,warehouse, i + 1));
                }
                i++;
            }
            this.Close();

        }
    }
}
