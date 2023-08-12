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
    public class ActivityDAL
    {
        DB db =new DB();


        public string Create(Activity activity,User user,Customer customer,ActivityCategory activityCategory)
        {
            try
            {
                activity.User = db.Users.Find(user.id);
                activity.Customer=db.Customers.Find(customer.id);
                activity.ActivityCategory=db.ActivityCategories.Find(activityCategory.Id);
                db.Activities.Add(activity);
                db.SaveChanges();
                return "ثبت اطلاعات با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی مواجه شد" + e.Message;
            }
        }


        public DataTable Read()
        {
            SqlCommand command = new SqlCommand("ReadAll");
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


        public Activity ReadById(int id)
        {
            return db.Activities.Where(i=>i.id==id).FirstOrDefault();
        }
        

        public string Delete(int id)
        {
            try
            {
                var q = db.Activities.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.DeleteStatus = true;
                    db.Activities.Remove(q);
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


        public string ReadByInfo(int id)
        {
            return db.Activities.FirstOrDefault(i=>i.id == id).Info;
        }
    }
}
