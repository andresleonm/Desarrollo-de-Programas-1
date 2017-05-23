using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Models;
//using WindowsFormsApp1.DataService;
//using WindowsFormsApp1.Controller;
namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*UsersController uc = new UsersController("ADMIN", "ADMIN");
            Models.User user =(Models.User) uc.getUser(1).data;
            user.print();
            user.id = 4;
            uc.insertUser(user);
            var users = (List<Models.User>)uc.getUsers().data;
            foreach(Models.User u in users)
            {
                u.print();
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }
    }
}
