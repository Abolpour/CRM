using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesinesEntitis;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ReminderDAL
    {
        DB db = new DB();

        public string Create(Reminder r,User u)
        {
            try
            {
                r.Users=db.Users.Find(u.id);
                db.Reminders.Add(r);
                db.SaveChanges();
                return "ثبت اطلاعات ب موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }


        public DataTable Read()
        {
            SqlCommand command = new SqlCommand("R");
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


        public Reminder ReadByID(int id)
        {
            return db.Reminders.Find(id);
        }

        
        public DataTable Serch(string Filter)
        {
            SqlCommand command = new SqlCommand("SearchReminder");
            string connectionStringText = "Data Source=.;Integrated Security =true;Initial Catalog=Project_CRM";
            command.Parameters.AddWithValue("@Search",Filter);
            SqlConnection connection = new SqlConnection(connectionStringText);
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            var sqldataadpter = new SqlDataAdapter();
            sqldataadpter.SelectCommand = command;
            var dataset = new DataSet();
            sqldataadpter.Fill(dataset);
            return dataset.Tables[0];
        }


        public string Update(Reminder r, int id)
        {
            try
            {
                Reminder reminder = ReadByID(id);
                reminder.ReminderDate= r.ReminderDate;
                reminder.ReminderInfo= r.ReminderInfo;
                reminder.Title= r.Title;
                db.SaveChanges();
                return "ویرایش با موفیقت انجام شد";
            }
            catch (Exception e)
            {
                return "ویرایش اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
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
                var q = db.Reminders.Where(i => i.id== id).FirstOrDefault();
                if (q != null)
                {
                    q.DeleteStatus = true;
                    db.SaveChanges();
                    return "حذف با موفیقت انجام شد";
                }
                else
                {
                    return "یادآور مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "حذف اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }


        public string Done(int id)
        {
            try
            {
                var q = db.Reminders.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.IsDone = true;
                    db.SaveChanges();
                    return "حذف با موفیقت انجام شد";
                }
                else
                {
                    return "یادآور مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "حذف اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }

    }
}
