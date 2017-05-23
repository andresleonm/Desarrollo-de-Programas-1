using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataService
{
    public class Row
    {
        public List<string > columns = new List<string>(); 

        public Row(List<string> columns)
        {
            this.columns = columns;
        }
        public void add(string col)
        {
            columns.Add(col);
        }
        public string getColumn(int col)
        {
            return columns[col];
        }
    }
}
