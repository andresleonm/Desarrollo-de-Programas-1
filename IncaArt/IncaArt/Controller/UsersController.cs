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

        ProfileController profile_controller;

        //todos los controladores deben de hereder de DatabaseService de esta manera
        public UsersController(string user,string password):base(user, password)
        {
            this.profile_controller = new ProfileController(user, password);
        }

        public Result getUserByNickname(string nickname)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("nickname", nickname));
            GenericResult result = execute_function("get_user_by_nickname", parameters);

            if (result.success)
            {
                if (result.data.Count < 1)
                {
                    return new Result(null, false, "El usuario no fue encontrado");
                }
                else
                {
                    Row row = result.data[0];
                    Profile profile = new Profile(Int32.Parse(row.getColumn(1)), row.getColumn(12), profile_controller.getFunctionalitiesFromJSON(row.getColumn(13)));
                    User user = new User(Int32.Parse(row.getColumn(0)), profile, row.getColumn(2), row.getColumn(3), row.getColumn(4), row.getColumn(5), row.getColumn(6), row.getColumn(7)[0], row.getColumn(8), row.getColumn(9), row.getColumn(10), row.getColumn(11), false);

                    return new Result(user, true, "");
                    
                }
            }

            return new Result(null, result.success, result.message);
        }

        public Result getUsers()
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_users", parameters);

            if (result.success)
            {
                List<User> users = new List<User>();

                foreach (Row row in result.data)
                {
                    users.Add(new User(Int32.Parse(row.getColumn(0)), new Profile(0, row.getColumn(1)), row.getColumn(2), row.getColumn(3), row.getColumn(4), row.getColumn(5), row.getColumn(6), row.getColumn(7)[0], row.getColumn(8), row.getColumn(9), row.getColumn(10), row.getColumn(11), false));
                }

                return new Result(users, true, "");
            }

            return new Result(null, false, result.message);
        }

        public Result insertUser(User user)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", user.Name));
            parameters.Add(new Parameter("middlename", user.Middlename));
            parameters.Add(new Parameter("password", user.Password));
            parameters.Add(new Parameter("lastname", user.Lastname));
            parameters.Add(new Parameter("phone", user.Phone));
            parameters.Add(new Parameter("email", user.Email));
            parameters.Add(new Parameter("address", user.Address));
            parameters.Add(new Parameter("gender", user.Gender.ToString()));
            parameters.Add(new Parameter("profile", user.Profile.Id.ToString()));
            parameters.Add(new Parameter("nickname", user.Nickname));
            parameters.Add(new Parameter("state", user.State));

            GenericResult result = execute_transaction("insert_user", parameters);

            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }

            return new Result(null, result.success, result.message);
        }

        public Result updateUser(User user)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", user.Id.ToString()));
            parameters.Add(new Parameter("name", user.Name));
            parameters.Add(new Parameter("middlename", user.Middlename));
            parameters.Add(new Parameter("password", user.Password));
            parameters.Add(new Parameter("lastname", user.Lastname));
            parameters.Add(new Parameter("phone", user.Phone));
            parameters.Add(new Parameter("email", user.Email));
            parameters.Add(new Parameter("address", user.Address));
            parameters.Add(new Parameter("gender", user.Gender.ToString()));
            parameters.Add(new Parameter("profile", user.Profile.Id.ToString()));
            parameters.Add(new Parameter("nickname", user.Nickname));
            parameters.Add(new Parameter("status", user.State));

            GenericResult result = execute_transaction("update_user", parameters);

            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }

            return new Result(null, result.success, result.message);
        }

        public Result deleteUser(User user)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", user.Id.ToString()));

            GenericResult result = execute_transaction("delete_user", parameters);

            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }

            return new Result(null, result.success, result.message);
        }
             
    }
}
