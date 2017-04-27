﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Order
    {
        internal OrderDetail order_detail { get ; set ; }
        internal DateTime date { get; set; }

        public Order(OrderDetail order_detail,DateTime date)
        {
            this.order_detail = order_detail;
            this.date = date;
        }

    }
}
