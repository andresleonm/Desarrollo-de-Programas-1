using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class SupplierController : DataService.DatabaseService
    {
        public SupplierController(string user, string password) : base(user, password)
        {
        }

        public Result getSuppliers()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_suppliers", parameters);
            List<Models.Supplier> suppliers = new List<Models.Supplier>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    suppliers.Add(new Models.Supplier(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3), r.getColumn(4), r.getColumn(5), r.getColumn(6)));
                }

                return new Result(suppliers, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getSupplier(int id)
        {

            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_supplier", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.Supplier supplier = new Models.Supplier(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3), r.getColumn(4), r.getColumn(5), r.getColumn(6));
                return new Result(supplier, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result insertSupplier(Models.Supplier supplier)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", supplier.Name));
            parameters.Add(new Parameter("address", supplier.Address));
            parameters.Add(new Parameter("doi", supplier.Doi));
            parameters.Add(new Parameter("phone", supplier.Phone));
            parameters.Add(new Parameter("email", supplier.Email));
            parameters.Add(new Parameter("state", supplier.State));
            GenericResult result = execute_transaction("insert_supplier", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result updateSupplier(Models.Supplier supplier)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", supplier.Id.ToString()));
            parameters.Add(new Parameter("name", supplier.Name));
            parameters.Add(new Parameter("address", supplier.Address));
            parameters.Add(new Parameter("doi", supplier.Doi));
            parameters.Add(new Parameter("phone", supplier.Phone));
            parameters.Add(new Parameter("email", supplier.Email));
            parameters.Add(new Parameter("state", supplier.State));
            GenericResult result = execute_transaction("update_supplier", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteSupplier(Models.Supplier supplier)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", supplier.Id.ToString()));
            GenericResult result = execute_transaction("delete_supplier", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getSuppliers(Models.Supplier supplier)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            if (supplier.Name != "") parameters.Add(new Parameter("name", supplier.Name));
            if (supplier.Doi != "") parameters.Add(new Parameter("doi", supplier.Doi));

            GenericResult result = execute_function("get_suppliers2", parameters);
            List<Models.Supplier> suppliers = new List<Models.Supplier>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    suppliers.Add(new Models.Supplier(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3), r.getColumn(4), r.getColumn(5), r.getColumn(6)));
                }
                return new Result(suppliers, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
