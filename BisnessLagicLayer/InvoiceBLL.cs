using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BesinesEntitis;
using System.Data;

namespace BisnessLagicLayer
{
    public class InvoiceBLL
    {
        InvoiceDAL dal = new InvoiceDAL();

        public string Create(Invoice invoice, Customer customer, List<Product> products)
        {
            return dal.Create(invoice, customer, products);
        }


        public string ReadInvoiceNumIsReport()
        {
            return dal.ReadInvoiceNumIsReport();
        }


        public string CountInvoices()
        {
            return dal.CountInvoices();
        }


        public DataTable Read()
        {
            return dal.Read();
        }


        public string Delete(int id)
        {
            return dal.Delete(id);
        }


        public string Done(int id)
        {
            return dal.Done(id);
        }


        public Invoice ReadById(int id)
        {
            return dal.ReadById(id);
        }

        public string Update(Invoice i, int id)
        {
            return dal.Update(i, id);
        }
    }
}
