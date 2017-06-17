using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.MovementsType_Module
{
    public partial class UC_MaterialMovementsType : ICheckPermissions
    {
        bool name_flag;
        bool class_flag;
        bool data_loaded;
        int cur_row;
        int operation_value;// 0 para Create, 1 para Update
        List<Models.MaterialMovementType> movement_type_list;
        Controller.MaterialMovementTypeController movementTypeController;
        Controller.Result result;
        public UC_MaterialMovementsType()
        {
            InitializeComponent();
        }

        private void UC_MaterialMovementsType_Load(object sender, EventArgs e)
        {
            data_loaded = false;
        }

        private void UC_MaterialMovementsType_VisibleChanged(object sender, EventArgs e)
        {
            if (!data_loaded)
            {
                data_loaded = true;
                string user = "dp1admin";
                string password = "dp1admin";
                movementTypeController = new Controller.MaterialMovementTypeController(user, password);
                //Set_Flag_All(false);
                operation_value = 0;
            }
            Load_Data();
            Load_DataGridView();
        }

        private void Load_Data()
        {
            result = movementTypeController.getMaterialMovementTypes(null);
            if (result.success)
            {
                movement_type_list = (List<Models.MaterialMovementType>)result.data;
            }
            else
            {
                MessageBox.Show(result.message, "Error al listar Tipos de Movimiento de Material", MessageBoxButtons.OK);
            }
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < movement_type_list.Count(); i++)
            {
                Models.UnitOfMeasure unit = new Models.UnitOfMeasure();
                result = unitController.getUnit(material_list[i].Unit_id);
                if (result.success)
                {
                    unit = (Models.UnitOfMeasure)result.data;
                    String[] row = new String[6];
                    row[0] = material_list[i].Id.ToString();
                    row[1] = i.ToString();
                    row[2] = material_list[i].Name;
                    row[3] = unit.Name;
                    row[4] = material_list[i].Stock_min.ToString();
                    row[5] = material_list[i].Stock_max.ToString();
                    this.metroGrid1.Rows.Add(row);
                }
                else
                {
                    MessageBox.Show(result.message, "Error al buscar unit", MessageBoxButtons.OK);
                }
            }
        }
    }
}
