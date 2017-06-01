using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class UC_SimulationConfig : UserControl
    {
        CheckBox ckBox;
        public UC_SimulationConfig()
        {
            InitializeComponent();
        }

        private void UC_SimulationConfig_Load(object sender, EventArgs e)
        {
            metroGrid1.Columns[1].Width = 30;
            metroGrid1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            Rectangle rect = metroGrid1.GetCellDisplayRectangle(1, -1, true);
            
            rect.X = metroGrid1.GetCellDisplayRectangle(1, -1, true).Right + 8;
            rect.Y = rect.Location.Y;
            rect.Width = rect.Size.Width;
            rect.Height = rect.Size.Height;

            ckBox = new CheckBox();            
            ckBox.Size = new Size(15, 15);
            ckBox.Location = rect.Location;
            ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);

            metroGrid1.Controls.Add(ckBox);            
        }

        private void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow r in metroGrid1.Rows)
            {
                r.Cells[1].Value = ckBox.Checked;
            }

        }
    }
}
