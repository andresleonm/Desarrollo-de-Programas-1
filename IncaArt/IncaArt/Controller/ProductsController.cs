using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class ProductsController : DataService.DatabaseService
    {
        //todos los controladores deben de hereder de DatabaseService de esta manera
        public ProductsController(string user, string password) : base(user, password)
        {
        }

        public Result getProducts()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_products", parameters);
            List<Models.Product> products = new List<Models.Product>();
            if (result.success)
            {
                Models.Product product;
                foreach (Row r in result.data)
                {
                    //"PRODUCT_ID",         0
                    //"UNIT_OF_MEASURE_ID", 1
                    //"PRODUCT_NAME",       2
                    //"STOCK_MIN",          3
                    //"STOCK_MAX"           4
                    //"AVERAGE_PRICE",      5
                    //products.Add(new Models.Product(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)),double.Parse(r.getColumn(5))));
                    product = new Models.Product();
                    product.Id = Int32.Parse(r.getColumn(0));
                    product.Unit_id = Int32.Parse(r.getColumn(1));
                    product.Name = r.getColumn(2);
                    product.Stock_min = Int32.Parse(r.getColumn(3));
                    product.Stock_max = Int32.Parse(r.getColumn(4));
                    product.Average_cost = double.Parse(r.getColumn(5));
                    product.Product_type = r.getColumn(6);
                    products.Add(product);
                }
                return new Result(products, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getProducts(Models.Product product)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            if (product.Name != "") parameters.Add(new Parameter("name", product.Name));
            if (product.Unit_id != 0) parameters.Add(new Parameter("unit_id", product.Unit_id.ToString()));
            if (product.Product_type!= "Seleccionar") parameters.Add(new Parameter("product_type", product.Product_type.ToString()));
            GenericResult result = execute_function("get_products2", parameters);
            List<Models.Product> products = new List<Models.Product>();
            if (result.success)
            {
                Models.Product item;
                foreach (Row r in result.data)
                {
                    //"PRODUCT_ID",         0
                    //"UNIT_OF_MEASURE_ID", 1
                    //"PRODUCT_NAME",       2
                    //"STOCK_MIN",          3
                    //"STOCK_MAX"           4
                    //"AVERAGE_PRICE",      5
                    //products.Add(new Models.Product(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)), double.Parse(r.getColumn(5))));
                    item = new Models.Product();
                    item.Id = Int32.Parse(r.getColumn(0));
                    item.Unit_id = Int32.Parse(r.getColumn(1));
                    item.Name = r.getColumn(2);
                    item.Stock_min = Int32.Parse(r.getColumn(3));
                    item.Stock_max = Int32.Parse(r.getColumn(4));
                    item.Average_cost = double.Parse(r.getColumn(5));
                    item.Product_type = r.getColumn(6);
                    products.Add(item);
                }
                return new Result(products, true, "");
            }
            return new Result(null, result.success, result.message);
        }
        //Only get the products which have minimum one warehouse
        public Result getProducts_withWarehouses()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_products3", parameters);
            List<Models.Product> products = new List<Models.Product>();
            if (result.success)
            {
                Models.Product product;
                foreach (Row r in result.data)
                {
                    //"PRODUCT_ID",         0
                    //"UNIT_OF_MEASURE_ID", 1
                    //"PRODUCT_NAME",       2
                    //"STOCK_MIN",          3
                    //"STOCK_MAX"           4
                    //"AVERAGE_PRICE",      5
                    //products.Add(new Models.Product(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)),double.Parse(r.getColumn(5))));
                    product = new Models.Product();
                    product.Id = Int32.Parse(r.getColumn(0));
                    product.Unit_id = Int32.Parse(r.getColumn(1));
                    product.Name = r.getColumn(2);
                    product.Stock_min = Int32.Parse(r.getColumn(3));
                    product.Stock_max = Int32.Parse(r.getColumn(4));
                    product.Average_cost = double.Parse(r.getColumn(5));
                    product.Product_type = r.getColumn(6);
                    products.Add(product);
                }
                return new Result(products, true, "");
            }
            return new Result(null, result.success, result.message);
        }
        public Result getProduct(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_product", parameters);
            if (result.success)
            {
                //PRODUCT_ID,           0
                //"UNIT_OF_MEASURE_ID", 1
                //"PRODUCT_NAME",       2
                //"STOCK_MIN",          3
                //"STOCK_MAX",          4
                //"AVERAGE_PRICE",      5
                //"AVERAGE_COST"        6
                var r = result.data[0];
                Models.Product product = new Models.Product(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)), double.Parse(r.getColumn(5)));
                product.Currency_id = Int32.Parse(r.getColumn(7));
                product.Product_type = r.getColumn(8);
                return new Result(product, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertProduct(Models.Product product)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", product.Name.ToString()));
            parameters.Add(new Parameter("unit_id", product.Unit_id.ToString()));
            parameters.Add(new Parameter("stock_min", product.Stock_min.ToString()));
            parameters.Add(new Parameter("stock_max", product.Stock_max.ToString()));
            parameters.Add(new Parameter("price", product.Unit_price.ToString()));
            parameters.Add(new Parameter("currency_id", product.Currency_id.ToString()));
            parameters.Add(new Parameter("product_type", product.Product_type.ToString()));
            GenericResult result = execute_transaction("insert_product", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateProduct(Models.Product product)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", product.Id.ToString()));
            parameters.Add(new Parameter("name", product.Name.ToString()));
            parameters.Add(new Parameter("unit_id", product.Unit_id.ToString()));
            parameters.Add(new Parameter("stock_min", product.Stock_min.ToString()));
            parameters.Add(new Parameter("stock_max", product.Stock_max.ToString()));
            parameters.Add(new Parameter("price", product.Unit_price.ToString()));
            parameters.Add(new Parameter("currency_id", product.Currency_id.ToString()));
            parameters.Add(new Parameter("product_type", product.Product_type.ToString()));
            GenericResult result = execute_transaction("update_product", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteProduct(Models.Product product)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", product.Id.ToString()));
            GenericResult result = execute_transaction("delete_product", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
