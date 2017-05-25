using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controller
{
    public class ProfileController: DatabaseService
    {
        public ProfileController(string user, string password):base(user, password)
        {
                
        }

        public Result getProfileById(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_profile_by_id", parameters);

            if (result.success)
            {
                if (result.data.Count < 1)
                {
                    return new Result(null, false, "El perfil no fue encontrado");
                }
                else
                {
                    Row row = result.data[0];
                    Result func_result = getProfileFunctionalities(id);

                    if (func_result.success)
                    {
                        List<Functionality> functionalities = (List<Functionality>)func_result.data;
                        Profile profile = new Profile(Int32.Parse(row.getColumn(0)), row.getColumn(1), functionalities);

                        return new Result(profile, true, "");
                    }
                    else
                    {
                        return new Result(null, false, "getProfileFunctionalities " + func_result.message);
                    }
                    
                }
            }

            return new Result(null, result.success, result.message);
        }

        public Result getProfileFunctionalities(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_profile_functionalities", parameters);

            if (result.success)
            {
                List<Functionality> functionalities = new List<Functionality>();

                foreach (Row row in result.data)
                {
                    functionalities.Add(new Functionality(Int32.Parse(row.getColumn(0)), row.getColumn(1), row.getColumn(2)));
                }

                return new Result(functionalities, true, "");
            }
            else
            {
                return new Result(null, false, result.message);
            }
        }
    }
}
