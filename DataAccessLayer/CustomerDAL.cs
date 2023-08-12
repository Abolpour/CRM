using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesinesEntitis;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class CustomerDAL
    {
        DB db = new DB();

        public string Create(Customer c)
        {
            try
            {
                db.Customers.Add(c);
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
            string Query = "SELECT id As [ردیف], Name AS [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ وساعت] FROM  dbo.Customers WHERE  (DeleteStatus = 0)";
            string connectionStringText = @"Data Source=.\SQL2017;Integrated Security =true;Initial Catalog=Project_CRM";
            SqlConnection connection =new SqlConnection(connectionStringText);
            var sqlAdapter=new SqlDataAdapter(Query,connection);
            var commandbuilder=new SqlCommandBuilder(sqlAdapter);
            var dataset=new DataSet();
            sqlAdapter.Fill(dataset);
            return dataset.Tables[0];
        }

       
        public bool Exist(Customer c)
        {
            #region TAHERI
            //var q = db.Customers.Where(i => i.Phone == c.Phone);
            //if (q.Count() == 0)
            //{
            //    return true;
            //}
            //return false;
            #endregion
              return db.Customers.Any(i => i.Phone == c.Phone);
        }


        public Customer ReadById(int id)
        {
            return db.Customers.Find(id);
        }


        public string Update(Customer c,int id)
        { 
            try
            {
                Customer customer = ReadById(id);
                customer.Name = c.Name;
                customer.Phone = c.Phone;
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
            try
            {
                var q = db.Customers.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    db.Customers.Remove(q);
                    q.DeleteStatus = true;
                    db.SaveChanges();
                    return "حذف با موفیقت انجام شد";
                }
                else
                {
                    return "مشتری مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "حذف اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }


        public DataTable Serch(string Filter,int index)
        {
            SqlCommand command = new SqlCommand();
            if(index == 0)
            {
                command.CommandText = "SerchCustomer";
            }
            else if(index == 1)
            {
                command.CommandText = "SerchCustomerName";
            }
            else if(index == 2)
            {
                command.CommandText = "SerchCustomerPhone";
            }
            string connectionStringText =@"Data Source=.\SQL2017;Integrated Security =true;Initial Catalog=Project_CRM";
            SqlConnection connection = new SqlConnection(connectionStringText);
            
            command.Parameters.AddWithValue("@Serch",Filter);
            command.Connection = connection;
            command.CommandType= CommandType.StoredProcedure;
            var sqldataadpter = new SqlDataAdapter();
            sqldataadpter.SelectCommand = command;
            var dataset=new DataSet();
            sqldataadpter.Fill(dataset);
            return dataset.Tables[0];
        }


        public List<string> ReadPhoneNumbers()
        {
            return db.Customers.Select(i => i.Phone).ToList();
        }


        public Customer ReadByName(string phone)
        {
            return db.Customers.Where(u => u.Phone == phone).FirstOrDefault();
        }

    }
}
