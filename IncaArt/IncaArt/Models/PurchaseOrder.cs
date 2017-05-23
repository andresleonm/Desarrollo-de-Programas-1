using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PurchaseOrder
    {
        List<PurchaseOrderLine> lines;
        Currency currency;
        Supplier supplier;
        Double amount;
        string state;
        DateTime due_date;
        DateTime creation_date;


    }
}
