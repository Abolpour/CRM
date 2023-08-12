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
    public  class ProductDAL
    {
        DB db=new DB();

        public string Create(Product p)
        {
            try
            {
                db.Products.Add(p);
                db.SaveChanges();
                return "ثبت اطلاعات مشتری با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;

            }
        }


        public DataTable Read()
        {
            string Query = "SELECT id AS ردیف, Name AS [نام محصول], Price AS [قیمت محصول], Stock AS موجودی FROM  dbo.Products WHERE (DeleteStatus = 0)";
            string connectionStringText = @"Data Source=.\SQL2017;Integrated Security =true;Initial Catalog=Project_CRM";
            SqlConnection connection = new SqlConnection(connectionStringText);
            var sqlAdapter = new SqlDataAdapter(Query, connection);
            var dataset = new DataSet();
            sqlAdapter.Fill(dataset);
            return dataset.Tables[0];
        }


        public bool Exist(Product p)
        {
            #region TAHERI
            //var q = db.Products.Where(i => i.Phone == c.Phone);
            //if (q.Count() == 0)
            //{
            //    return true;
            //}
            //return false;
            #endregion
            return db.Products.Any(i => i.Name == p.Name);
        }


        public Product ReadById(int id)
        {
            return db.Products.Find(id);
        }


        public string Update(Product p, int id)
        {
            try
            {
                Product product  = ReadById(id);
                product.Name = p.Name;
                product.Price = p.Price;
                product.Stock= p.Stock;
                db.SaveChanges();
                return "ویرایش با موفیقت انجام شد";
            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
            #region TAHERI
            //try
            //{
            //    var q = db.Customers.Where(i => i.CustomerId == id).FirstOrDefault();
            //    if (q != null)
            //    {
            //        q.Name = c.Name;
            //        q.Phone = c.Phone;
            //        db.SaveChanges();
            //        return "ویرایش با موفیقت انجام شد";
            //    }
            //    else
            //    {
            //        return "کاربر مورد نظر یافت نشد";
            //    }
            //}
            //catch (Exception e)
            //{

            //    return "ویرایش اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            //}
            #endregion
        }


        public string Delete(int id)
        {
            #region TAHERI
            //try
            //{
            //    var q = db.Customers.Where(i => i.CustomerId == id).FirstOrDefault();
            //    if (q != null)
            //    {
            //        q.DeleteStatus = true;
            //        db.SaveChanges();
            //        return "حذف با موفیقت انجام شد";
            //    }
            //    else
            //    {
            //        return "کاربر مورد نظر یافت نشد";
            //    }
            //}
            //catch (Exception e)
            //{

            //    return "حذف اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            //}
            #endregion
            /*
              ما در اینجا قرار نیست شخصی را کامل پاک بکنیم
              یک متغیر داریم اگر (ترو) بود برای ما هست
              اگر(فالز) بشه به جدول دیگه ای انتقال پیدا می کنه
             */
            Product p = ReadById(id);
            db.Products.Remove(p);
            p.DeleteStatus = true;
            db.SaveChanges();
            return "مشتری مورد نظر حذف شد";

        }



        public DataTable Serch(string Filter)
        {
            SqlCommand command = new SqlCommand("SerchProduct");
            string connectionStringText =@"Data Source=.\SQL2017;Integrated Security =true;Initial Catalog=Project_CRM";
            SqlConnection connection = new SqlConnection(connectionStringText);
            command.Parameters.AddWithValue("@Serch", Filter);
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            var sqldataadpter = new SqlDataAdapter();
            sqldataadpter.SelectCommand = command;
            var dataset = new DataSet();
            sqldataadpter.Fill(dataset);
            return dataset.Tables[0];
        }



        public List<string> ReadByName()
        {
            return db.Products.Where(i=>i.Stock != 0).Select(p => p.Name).ToList();
        }



        public Product ReadByNameList(string product)
        {
            return db.Products.Where(i=>i.Name==product).SingleOrDefault();
        }


        public string ProductsCount()
        {
            return db.Products.Count().ToString();
        }
    }
}
