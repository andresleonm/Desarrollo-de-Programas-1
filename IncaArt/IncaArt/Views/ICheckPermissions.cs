using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class ICheckPermissions : MetroFramework.Controls.MetroUserControl
    {
        public ICheckPermissions()
        {
            InitializeComponent();
        }

        public virtual void CheckPermissions(User u)
        {

        }
    }
}
