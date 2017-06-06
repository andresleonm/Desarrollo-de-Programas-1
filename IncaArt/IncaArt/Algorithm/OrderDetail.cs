using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Algorithm
{
    class OrderDetail
    {

        public List<OrderDetailLine> lines { get; set; }

        public OrderDetail()
        {
            lines = new List<OrderDetailLine>();
        }

        public OrderDetail(List<OrderDetailLine> lines)
        {
            this.lines = lines;
        }

    }
}
