using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class SalesOrder
    {
        List<SalesOrderLine> lines;
        Currency currency;
        double amount;
        string state;
        DateTime issue_date;
        DateTime delivery_date;
        int id;
    }
}
