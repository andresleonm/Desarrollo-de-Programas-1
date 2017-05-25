using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
    public class Result
    {
        public object data;
        public bool success;
        public string message;

        public Result(object data, bool success, string message)
        {
            this.data = data;
            this.success = success;
            this.message = message;
        }
    }
}
