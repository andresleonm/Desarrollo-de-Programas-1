using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class OrderDetail
    {
        internal List<OrderDetailLine> lines { get; set; }

        public OrderDetail(List<OrderDetailLine> lines)
        {
            this.lines = lines;
        }
    }
}
