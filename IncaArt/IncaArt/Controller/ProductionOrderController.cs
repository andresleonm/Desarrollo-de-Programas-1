﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class ProductionOrderController : DataService.DatabaseService
    {
        public ProductionOrderController(string user, string password) : base( user, password)
        {
        }
        public Result insertProductionOrder(ProductionOrder production_order)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("production_order_name", production_order.Description));
            parameters.Add(new Parameter("production_order_observation", production_order.Observation));
            parameters.Add(new Parameter("production_order_date", production_order.Begin.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("state", production_order.State));
            parameters.Add(new Parameter("production_order_date_end", production_order.End.ToString("MM/dd/yyyy")));          
            GenericResult result = execute_transaction("insert_production_order", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getProductionOrders()
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_production_orders", parameters);
            List<ProductionOrder> production_orders = new List<ProductionOrder>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    //PRODUCTION_ORDER_ID","PRODUCTION_ORDER_NAME","PRODUCTION_ORDER_OBSERVATION","PRODUCTION_ORDER_DATE","STATE","PRODUCTION_ORDER_DATE_END"
                    production_orders.Add(new ProductionOrder(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2),
                                                    DateTime.Parse(r.getColumn(3)), r.getColumn(4),DateTime.Parse(r.getColumn(5))));
                }
                return new Result(production_orders, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getProductionOrders(int order_Id, string description,DateTime begin, DateTime end)
        {
            List<Parameter> parameters = new List<Parameter>();
            if (order_Id != 0) parameters.Add(new Parameter("order_id", order_Id.ToString()));
            if (description!= "") parameters.Add(new Parameter("description", description));
            parameters.Add(new Parameter("begin",begin.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("end_date", end.ToString("MM/dd/yyyy")));

            GenericResult result = execute_function("get_production_orders2", parameters);
            List<ProductionOrder> production_orders = new List<ProductionOrder>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    //PRODUCTION_ORDER_ID","PRODUCTION_ORDER_NAME","PRODUCTION_ORDER_OBSERVATION","PRODUCTION_ORDER_DATE","STATE","PRODUCTION_ORDER_DATE_END"
                    production_orders.Add(new ProductionOrder(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2),
                                                    DateTime.Parse(r.getColumn(3)), r.getColumn(4), DateTime.Parse(r.getColumn(5))));
                }
                return new Result(production_orders, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getProductionOrder(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("order_id", id.ToString()));
            GenericResult result = execute_function("get_production_order", parameters);
            if (result.success)
            {
                var r = result.data[0];
                //"PRODUCTION_ORDER_ID","PRODUCTION_ORDER_NAME","PRODUCTION_ORDER_OBSERVATION","PRODUCTION_ORDER_DATE", "STATE","PRODUCTION_ORDER_DATE_END"
                ProductionOrder production_order = new ProductionOrder(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), DateTime.Parse(r.getColumn(3)),
                                        r.getColumn(4), DateTime.Parse(r.getColumn(5)));
                return new Result(production_order, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateProductionOrder(ProductionOrder production_order)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("production_order_id",production_order.Id.ToString()));
            parameters.Add(new Parameter("production_order_name", production_order.Description));
            parameters.Add(new Parameter("production_order_observation", production_order.Observation));
            parameters.Add(new Parameter("production_order_date", production_order.Begin.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("state", production_order.State));
            parameters.Add(new Parameter("production_order_date_end", production_order.End.ToString("MM/dd/yyyy")));

            GenericResult result = execute_transaction("update_production_order", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
