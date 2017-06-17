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
        MaterialsController mc;
        MaterialMovementDetailController mdc;
        bool flg = true;
        public void fillMaterials()
        {
            mc = new MaterialsController(user, password);
            mdc = new MaterialMovementDetailController(user, password);
            List<Models.Material> materials = (List<Models.Material>)mc.getMaterials().data;
            Models.Material m = new Material();
            m.Name = "Todos";
            m.Id = 0;
            materials.Add(m);
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
            fillMaterials();
        }

        private void ProductMovementLine_Load(object sender, EventArgs e)
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
            List<MaterialWarehouseM> warehouses = (List<MaterialWarehouseM>)mdc.getWarehouses(material).data;
            if (!flg)
                grid_materials.DataSource = new List<MaterialWarehouseM>();
            else flg = false;
            if (warehouses == null)
                warehouses = new List<MaterialWarehouseM>();


            grid_materials.DataSource = warehouses;
            AdjustColumnOrder();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                List<MaterialWarehouseM> warehouses = (List<MaterialWarehouseM>)grid_materials.DataSource;
                int i = 0;
                foreach (MaterialWarehouseM warehouse in warehouses)
                {
                    if (warehouse.selected)
                    {
                        lines.Add(new Models.MaterialMovementLine(user, password, warehouse, i + 1));
                    }
                    i++;
                }

                this.Close();
            }
            catch
            {
                this.Close();
            }
        }
    }
}
