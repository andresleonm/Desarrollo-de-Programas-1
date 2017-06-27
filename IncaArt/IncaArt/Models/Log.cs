using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Log
    {
        string username;
        string action;
        DateTime date;
        string target;
        string targetId;
        string targetData;

        public Log(string username, string action, DateTime date, string target, string targetId, string targetData)
        {
            this.Username = username;
            this.Action = action;
            this.Date = date;
            this.Target = target;
            this.TargetId = targetId;
            this.TargetData = targetData;
        }

        public string Username { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public string Target { get; set; }
        public string TargetId { get; set; }
        public string TargetData { get; set; }
    }
}
