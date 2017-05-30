using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class SupplierController: DataService.DatabaseService
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
                    suppliers.Add(new Models.Supplier(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3), r.getColumn(4), r.getColumn(5), r.getColumn(6),
                                                    Int32.Parse(r.getColumn(7)), r.getColumn(8)));
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
                Models.Supplier supplier = new Models.Supplier(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3), r.getColumn(4), r.getColumn(5), r.getColumn(6),
                                                    Int32.Parse(r.getColumn(7)), r.getColumn(8));
                return new Result(supplier, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
