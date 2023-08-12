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
    public class UserDAL
    {
        DB db = new DB();


        public string Create(User user, UserGroup userGroup)
        {

            try
            {
                if (!Exsit(user))
                {
                    user.UserGroup = db.UserGroups.Find(userGroup.id);
                    db.Users.Add(user);
                    db.SaveChanges();
                    return "ثبت اطلاعات ب موفقیت انجام شد";
                }
                else
                {
                    return "نام کاربری وارد شده تکراری است";
                }
            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }


        public bool Exsit(User user)
        {
            return db.Users.Any(i => i.UserName == user.UserName);
        }


        public User ReadById(int UserId)
        {
            return db.Users.Where(i => i.id == UserId).FirstOrDefault();
            //return db.Users.Find(UserId);
        }


        public DataTable Read()
        {
            string Query = "SELECT id AS ردیف, Name AS [نام و نام خانوادگی], UserName AS [نام کاربری], RegDate AS [تاریخ ثبت] FROM dbo.Users";
            string connectionStringText = @"Data Source=.\SQL2017;Integrated Security =true;Initial Catalog=Project_CRM";
            SqlConnection connection = new SqlConnection(connectionStringText);
            var sqlAdapter = new SqlDataAdapter(Query, connection);
            var dataset = new DataSet();
            sqlAdapter.Fill(dataset);
            return dataset.Tables[0];
        }


        public string Update(User user, int UserId)
        {
            try
            {
                User user1 = ReadById(UserId);
                user1.Name = user.Name;
                user1.UserName = user.UserName;
                user1.Password = user.Password;
                user1.Picture = user.Picture;
                db.SaveChanges();
                return "اطلاعات با موفقیت ویرایش شد";
            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }


        public string Delete(int id)
        {
            try
            {
                User u = ReadById(id);
                u.DeleteStatus = true;
                db.Users.Remove(u);
                db.SaveChanges();
                return "مشتری مورد نظر حذف شد";
            }
            catch (Exception e)
            {
                return "حذف اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
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
        }



        public User ReadByName(string Name)
        {
            return db.Users.Where(u => u.UserName == Name).SingleOrDefault();
        }



        public List<string> ReadUserNamesList()
        {
            return db.Users.Select(i => i.UserName).ToList();
        }


        public bool IsRegister()
        {
            return db.Users.Count() > 0;
            //return db.Users.Any(i => i.id > 0);
        }



        public User Login(string UserName, string Password)
        {
            return db.Users.Include("UserGroup").Where(i => i.UserName == UserName && i.Password == Password).SingleOrDefault();
        }


        public bool Access(User user, string Section, int number)
        {
            //Accecc Rols In Enter Software
            UserGroup ug = db.UserGroups.Include("UserAccessRoles").Where(i => i.id == user.UserGroup.id).FirstOrDefault();
            UserAccessRole role = ug.UserAccessRoles.Where(x => x.Section == Section).FirstOrDefault();
            if (number == 1)
            {
                return role.CanEnter;
            }
            else if (number == 2)
            {
                return role.CanCreate;
            }
            else if (number == 3)
            {
                return role.CanUpdate;
            }
            else
            {
                return role.CanDelete;
            }
        }


        public List<User> ReadInvoicesList()
        {
            return db.Users.Include("Invoices").Where(i => i.DeleteStatus == false).ToList();
        }
    }
}
