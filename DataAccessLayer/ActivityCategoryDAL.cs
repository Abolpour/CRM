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
    public class ActivityCategoryDAL
    {
        DB db = new DB();



        public string Create(ActivityCategory a)
        {
            try
            {
                db.ActivityCategories.Add(a);
                db.SaveChanges();
                return "دسته بندی با موفقیت ثبت شد";
            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;

            }
        }



        public DataTable Read()
        {
            string Query = "SELECT  Id AS ردیف, CategoryName AS [نام دسته بندی] FROM   dbo.ActivityCategories WHERE  (DeleteStatus = 0)";
            string connectionStringText = @"Data Source=.\SQL2017;Integrated Security =true;Initial Catalog=Project_CRM";
            SqlConnection connection = new SqlConnection(connectionStringText);
            var sqlAdapter = new SqlDataAdapter(Query, connection);
            var commandbuilder = new SqlCommandBuilder(sqlAdapter);
            var dataset = new DataSet();
            sqlAdapter.Fill(dataset);
            return dataset.Tables[0];
        }



        public ActivityCategory ReadById(int id)
        {
            return db.ActivityCategories.Find(id);
        }



        public string Delete(int id)
        {
            try
            {
                var q = db.ActivityCategories.Where(i => i.Id == id).FirstOrDefault();
                if (q != null)
                {
                    q.DeleteStatus = true;
                    db.SaveChanges();
                    return "حذف با موفیقت انجام شد";
                }
                else
                {
                    return "دسته بندی مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "حذف اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }



        public string Update(ActivityCategory activity,int id)
        {
            try
            {
                var q = db.ActivityCategories.Where(i => i.Id == id).FirstOrDefault();
                if (q != null)
                {
                    q.CategoryName= activity.CategoryName;
                    db.SaveChanges();
                    return "ویرایش با موفیقت انجام شد";
                }
                else
                {
                    return "دسته بندی مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "ویرایش اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }



        public List<string> ActivityCategoryReadUserNamesList()
        {
            return db.ActivityCategories.Select(i => i.CategoryName).ToList();
        }


        public ActivityCategory ReadByName(string Name)
        {
            return db.ActivityCategories.Where(u => u.CategoryName == Name).SingleOrDefault();
        }

    }
}
