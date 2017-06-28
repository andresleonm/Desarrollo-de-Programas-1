using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class SalesDocumentController : DataService.DatabaseService
    {
        public SalesDocumentController(string user, string password) : base( user, password)
        {
        }

        public Result getSalesDocumentsforRefund(int idDocument = 0, int idClient = 0, string iniDate = "", string endDate = "")
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_sales_documentsR", parameters);
            List<SalesDocument> sales_documents = new List<SalesDocument>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    SalesDocumentLineController sdlc = new SalesDocumentLineController(user, password);
                    //var detail = (List<SalesDocumentLine>)sdlc.getSalesDocumentLines(Int32.Parse(r.getColumn(0))).data;
                    sales_documents.Add(new SalesDocument(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                        r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                        r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                        r.getColumn(9), DateTime.Parse(r.getColumn(10)), Double.Parse(r.getColumn(11)),
                                                        Double.Parse(r.getColumn(12)), r.getColumn(13), Int32.Parse(r.getColumn(14)),
                                                        Char.Parse(r.getColumn(15)), r.getColumn(16), null));
                }
                return new Result(sales_documents, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getSalesDocuments(int idDocument = 0, int idClient = 0, string iniDate = "", string endDate = "")
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_sales_documents", parameters);
            List<SalesDocument> sales_documents = new List<SalesDocument>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    SalesDocumentLineController sdlc = new SalesDocumentLineController(user, password);
                    //var detail = (List<SalesDocumentLine>)sdlc.getSalesDocumentLines(Int32.Parse(r.getColumn(0))).data;
                    sales_documents.Add(new SalesDocument(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                        r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                        r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                        r.getColumn(9), DateTime.Parse(r.getColumn(10)), Double.Parse(r.getColumn(11)), 
                                                        Double.Parse(r.getColumn(12)), r.getColumn(13), Int32.Parse(r.getColumn(14)), 
                                                        Char.Parse(r.getColumn(15)), r.getColumn(16), null));
                }
                return new Result(sales_documents, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getSalesDocument(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_sales_document", parameters);
            if (result.success)
            {
                var r = result.data[0];
                SalesDocumentLineController sdlc = new SalesDocumentLineController(user, password);
                var detail = (List<SalesDocumentLine>)sdlc.getSalesDocumentLines(Int32.Parse(r.getColumn(0))).data;

                SalesDocument sales_document = new SalesDocument(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                                r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                                r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                                r.getColumn(9), DateTime.Parse(r.getColumn(10)), Double.Parse(r.getColumn(11)),
                                                                Double.Parse(r.getColumn(12)), r.getColumn(13), Int32.Parse(r.getColumn(14)),
                                                                Char.Parse(r.getColumn(15)), r.getColumn(16), detail);
                return new Result(sales_document, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getSalesDocuments_by_filter(SalesDocument sales_document, DateTime init, DateTime end,Boolean equals)
        {
            List<Parameter> parameters = new List<Parameter>();
            if (sales_document.Id != -1) parameters.Add(new Parameter("id", sales_document.Id.ToString()));
            if (sales_document.Customer_name != "") parameters.Add(new Parameter("customer_name", sales_document.Customer_name));
            if (init != null) parameters.Add(new Parameter("finit", init.ToString("MM/dd/yyyy")));
            if (!equals)
            {
                if (end != null) parameters.Add(new Parameter("fend", end.ToString("MM/dd/yyyy")));
            }
            if (sales_document.Type_document_id.CompareTo('S') != 0) parameters.Add(new Parameter("type", sales_document.Type_document_id.ToString()));
            GenericResult result = execute_function("get_sales_documents_by_filter", parameters);
            List<SalesDocument> sales_documents = new List<SalesDocument>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    SalesDocumentLineController sdlc = new SalesDocumentLineController(user, password);
                    var detail = (List<SalesDocumentLine>)sdlc.getSalesDocumentLines(Int32.Parse(r.getColumn(0))).data;
                    sales_documents.Add(new SalesDocument(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                        r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                        r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                        r.getColumn(9), DateTime.Parse(r.getColumn(10)), Double.Parse(r.getColumn(11)),
                                                        Double.Parse(r.getColumn(12)), r.getColumn(13), Int32.Parse(r.getColumn(14)),
                                                        Char.Parse(r.getColumn(15)), r.getColumn(16), detail));
                }
                return new Result(sales_documents, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertSalesDocument(SalesDocument sales_document)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("order_id", sales_document.Order_id.ToString()));
            parameters.Add(new Parameter("type_document_id", sales_document.Type_document_id.ToString()));
            parameters.Add(new Parameter("currency_id", sales_document.Currency_id.ToString()));
            parameters.Add(new Parameter("customer_id", sales_document.Customer_id.ToString()));
            parameters.Add(new Parameter("customer_name", sales_document.Customer_name));
            parameters.Add(new Parameter("customer_address", sales_document.Customer_address));
            parameters.Add(new Parameter("customer_phone", sales_document.Customer_phone));
            parameters.Add(new Parameter("amount", sales_document.Amount.ToString()));
            parameters.Add(new Parameter("porc_igv", sales_document.Porc_igv.ToString()));
            parameters.Add(new Parameter("state", "Registrado"));
            parameters.Add(new Parameter("customer_doi", sales_document.Customer_doi));
            parameters.Add(new Parameter("date", sales_document.Issue_date.ToString("MM/dd/yyyy hh:mm:ss")));
            parameters.Add(new Parameter("observation", sales_document.Observation));
            parameters.Add(new Parameter("movement_id", sales_document.Movement_id.ToString()));
            parameters.Add(new Parameter("external_number", sales_document.External_number.ToString()));
            GenericResult result = execute_transaction("insert_sales_document", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
                                                           