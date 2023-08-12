using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinesEntitis
{
    public  class Product
    {
        public Product()
        {
            DeleteStatus = false;
        }
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool DeleteStatus { get; set; }
        // Stock => موجودی
        public int Stock { get; set; }

        public double SumPrice { get; set; }
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
        public DateTime RegDate { get; set; }
    }
}
