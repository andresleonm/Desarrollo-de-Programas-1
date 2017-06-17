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
    public partial class UC_ProductMovementsType : ICheckPermissions
    {
        bool cost_flag;
        bool data_loaded;
        int cur_row;
        int operation_value;// 0 para Create, 1 para Update
        //Controller.MaterialMovementController
        public UC_ProductMovementsType()
        {
            InitializeComponent();
        }

        private void UC_ProductMovementsType_Load(object sender, EventArgs e)
        {

        }
    }
}
