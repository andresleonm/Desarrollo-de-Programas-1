using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataService
{
    public class GenericResult
    {
        public List<Row> data;
        public bool success;
        public string  message;
        public string singleValue;

        public GenericResult(List<Row> data,bool success,string message,string singleValue)
        {
            this.data = data;
            this.success = success;
            this.message = message;
            this.singleValue = singleValue;
        }
    }
}
