﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinesEntitis
{
    public class Customer
    {
        public Customer()
        {
            DeleteStatus = false;
        }
        public int id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool DeleteStatus { get; set; }
        public DateTime RegDate { get; set; }
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
        public List<Activity> Activities { get; set; } = new List<Activity>();
    }
}
