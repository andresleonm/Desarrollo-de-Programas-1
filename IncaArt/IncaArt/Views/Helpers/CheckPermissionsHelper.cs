using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views.Helpers
{
    class CheckPermissionsHelper
    {
        public static void Check(Control control, User user)
        {
            foreach (Control o in control.Controls)
            {
                if (o is ICheckPermissions)
                {
                    ICheckPermissions checker = (ICheckPermissions)o;
                    checker.CheckPermissions(user);
                }
                else if (o is MetroFramework.Controls.MetroPanel)
                {
                    Check(o, user);
                }
            }
        }
    }
}
