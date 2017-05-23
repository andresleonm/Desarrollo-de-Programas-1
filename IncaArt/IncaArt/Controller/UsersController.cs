using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;
namespace WindowsFormsApp1.Controller
{
    public class UsersController: DataService.DatabaseService
    {
        //todos los controladores deben de hereder de DatabaseService de esta manera
        public UsersController(string user,string password):base( user, password)
        {
        }

        public Result getUsers()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_users", parameters);
            List<User> users = new List<User>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    users.Add(new User(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3)));
                }
                return new Result(users, true, "");
            }
            return new Result(null,result.success,result.message);
        }

        public Result getUser(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_user", parameters);            
            if (result.success)
            {
                var r = result.data[0];
                User user = new User(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3)
                                        ,r.getColumn(4), r.getColumn(5), r.getColumn(6), r.getColumn(7)[0], r.getColumn(8));
                return new Result(user, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertUser(User user)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", user.Id.ToString()));
            parameters.Add(new Parameter("name", user.Name));
            parameters.Add(new Parameter("middlename", user.Maternal_last_name));
            parameters.Add(new Parameter("password", user.Password));
            parameters.Add(new Parameter("lastname", user.Paternal_last_name));
            parameters.Add(new Parameter("phone", user.Phone));
            parameters.Add(new Parameter("email", user.Email));
            parameters.Add(new Parameter("address", user.Address));
            parameters.Add(new Parameter("gender", user.Gender.ToString()));
            parameters.Add(new Parameter("profile", user.Profile));
            GenericResult result = execute_transaction("insert_user", parameters);
            if (result.success)
            {               
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
