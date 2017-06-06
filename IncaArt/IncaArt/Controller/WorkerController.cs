using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class WorkerController : DataService.DatabaseService
    {
        public WorkerController(string user, string password) : base(user, password)
        {
        }

        public Result getWokers()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_workers", parameters);
            List<Models.Worker> workers = new List<Models.Worker>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    //"WORKER_ID",      0
                    //"SHIFT_ID",       1
                    //"NAME",           2
                    //"PATERNAL_NAME",  3
                    //"MATERNAL_NAME",  4
                    //"DOI"             5
                    workers.Add(new Models.Worker(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2), r.getColumn(3), r.getColumn(4), r.getColumn(5)));
                }
                return new Result(workers, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getWokers(Models.Worker worker)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            if (worker.Name != "") parameters.Add(new Parameter("name", worker.Name));
            if (worker.Doi != "") parameters.Add(new Parameter("doi", worker.Doi));
            if (worker.Paternal_name != "") parameters.Add(new Parameter("paternal_name", worker.Paternal_name));
            if (worker.Maternal_name != "") parameters.Add(new Parameter("maternal_name", worker.Maternal_name));
            if (worker.Shift_id != 0) parameters.Add(new Parameter("shift_id", worker.Shift_id.ToString()));
            GenericResult result = execute_function("get_workers2", parameters);
            List<Models.Worker> workers = new List<Models.Worker>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    //"WORKER_ID",      0
                    //"SHIFT_ID",       1
                    //"NAME",           2
                    //"PATERNAL_NAME",  3
                    //"MATERNAL_NAME",  4
                    //"DOI"             5
                    workers.Add(new Models.Worker(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2), r.getColumn(3), r.getColumn(4), r.getColumn(5)));
                }
                return new Result(workers, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getWorker(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_worker", parameters);
            if (result.success)
            {
                //"WORKER_ID",      0
                //"NAME",           1    
                //"PATERNAL_NAME",  2
                //"MATERNAL_NAME",  3
                //"DOI",            4
                //"BIRTHDAY",       5   
                //"GENDER",         6
                //"TELEPHONE",      7
                //"PHONE",          8
                //"EMAIL",          9
                //"ADDRESS",        10
                //"SHIFT_ID",       11
                //"SALARY"          12
                var r = result.data[0];
                Models.Worker worker = new Models.Worker(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(11)), r.getColumn(1), r.getColumn(2), r.getColumn(3), r.getColumn(4), DateTime.Parse(r.getColumn(5)), char.Parse(r.getColumn(6)), r.getColumn(7), r.getColumn(8), r.getColumn(9), r.getColumn(10), double.Parse(r.getColumn(12)));
                worker.Currency_id = Int32.Parse(r.getColumn(13));
                return new Result(worker, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertWorker(Models.Worker worker)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", worker.Name.ToString()));
            parameters.Add(new Parameter("paternal_name", worker.Paternal_name.ToString()));
            parameters.Add(new Parameter("maternal_name", worker.Maternal_name.ToString()));
            parameters.Add(new Parameter("doi", worker.Doi.ToString()));
            parameters.Add(new Parameter("birthday", worker.Birthday.ToString()));
            parameters.Add(new Parameter("gender", worker.Gender.ToString()));
            parameters.Add(new Parameter("telephone", worker.Telephone.ToString()));
            parameters.Add(new Parameter("phone", worker.Phone.ToString()));
            parameters.Add(new Parameter("email", worker.Email.ToString()));
            parameters.Add(new Parameter("address", worker.Address.ToString()));
            parameters.Add(new Parameter("shift_id", worker.Shift_id.ToString()));
            parameters.Add(new Parameter("salary", worker.Salary.ToString()));
            parameters.Add(new Parameter("currency_id", worker.Currency_id.ToString()));
            GenericResult result = execute_transaction("insert_worker", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateWorker(Models.Worker worker)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", worker.Id.ToString()));
            parameters.Add(new Parameter("name", worker.Name.ToString()));
            parameters.Add(new Parameter("paternal_name", worker.Paternal_name.ToString()));
            parameters.Add(new Parameter("maternal_name", worker.Maternal_name.ToString()));
            parameters.Add(new Parameter("doi", worker.Doi.ToString()));
            parameters.Add(new Parameter("birthday", worker.Birthday.ToString()));
            parameters.Add(new Parameter("gender", worker.Gender.ToString()));
            parameters.Add(new Parameter("telephone", worker.Telephone.ToString()));
            parameters.Add(new Parameter("phone", worker.Phone.ToString()));
            parameters.Add(new Parameter("email", worker.Email.ToString()));
            parameters.Add(new Parameter("address", worker.Address.ToString()));
            parameters.Add(new Parameter("shift_id", worker.Shift_id.ToString()));
            parameters.Add(new Parameter("salary", worker.Salary.ToString()));
            parameters.Add(new Parameter("currency_id", worker.Currency_id.ToString()));
            GenericResult result = execute_transaction("update_worker", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteWorker(Models.Worker worker)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", worker.Id.ToString()));
            GenericResult result = execute_transaction("delete_worker", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
