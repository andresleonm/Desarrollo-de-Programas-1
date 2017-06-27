using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        public string ParseData()
        {
            JObject[] rawObject = JsonConvert.DeserializeObject<JObject[]>(TargetData);
            JObject raw = rawObject[0];
            string result = "";

            foreach (JProperty prop in raw.Properties())
            {
                result += "- " + prop.Name + " = " + prop.Value + "\n";
            }

            return result;
        }

        public string Username { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public string Target { get; set; }
        public string TargetId { get; set; }
        public string TargetData { get; set; }
    }
}
