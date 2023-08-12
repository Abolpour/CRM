using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesinesEntitis;
namespace DataAccessLayer
{
    public class InvoiceDAL
    {
        DB db = new DB();

        public string Create(Invoice invoice, Customer customer, List<Product> products)
        {
            try
            {
                invoice.Customer = db.Customers.Find(customer.id);
                foreach (var item in products.ToList())
                {
                    invoice.Products.Add(db.Products.Find(item.id));
                }
                Random random = new Random();
                string numberrandom = random.Next(1000000).ToString();
                var q = db.Invoices.Where(x => x.InvoiceNumber == numberrandom);
                while (q.Count() > 0)
                {
                    numberrandom = random.Next(1000000).ToString();
                }
                invoice.InvoiceNumber = numberrandom;
                db.Invoices.Add(invoice);
                db.SaveChanges();
                return "ثبت فاکتور با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return "ثبت فاکتور با مشکلی موتجه شد" + e.Message;
            }
        }


        public string Done(int id)
        {
            try
            {
                var q = db.Invoices.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.IsCheckOut = true;
                    q.CkeckOutDate = DateTime.Now;
                    db.SaveChanges();
                    return "تسویه حساب انجام شد";
                }
                else
                {
                    return "ستون مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "تسویه حساب شخص  با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }


        public string ReadInvoiceNumIsReport()
        {
            var q = db.Invoices.OrderByDescending(i => i.id).FirstOrDefault();
            return q.InvoiceNumber;
        }


        public string CountInvoices()
        {
            return db.Invoices.Count().ToString();
        }


        public DataTable Read()
        {
            SqlCommand command = new SqlCommand("ReadInvoices");
            string connectionStringText = @"Data Source=.\SQL2017;Integrated Security =true;Initial Catalog=Project_CRM";
            SqlConnection connection = new SqlConnection(connectionStringText);
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            var sqldataadpter = new SqlDataAdapter();
            sqldataadpter.SelectCommand = command;
            var dataset = new DataSet();
            sqldataadpter.Fill(dataset);
            return dataset.Tables[0];
        }


        public string Delete(int id)
        {
            try
            {
                var q = db.Invoices.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    db.Invoices.Remove(q);
                    db.SaveChanges();
                    return "حذف با موفیقت انجام شد";
                }
                else
                {
                    return "فاکتور مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "حذف اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }


        public Invoice ReadById(int id)
        {
            return db.Invoices.Find(id);
        }

        public string Update(Invoice i, int id)
        {
            try
            {
                Invoice invoice = ReadById(id);
                invoice.Products = i.Products;
                db.SaveChanges();
                return "ویرایش با موفیقت انجام شد";
            }
            catch (Exception e)
            {
                return "ویرایش اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }
    }
}
