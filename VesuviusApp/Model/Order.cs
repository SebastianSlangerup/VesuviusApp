﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesuviusApp.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int Price_total { get; set; }
        public DateTime Order_date { get; set; }
        public int Customer_count { get; set; }
        public string Order_state { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
    }
}

