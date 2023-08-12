using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesinesEntitis;
using DataAccessLayer;
namespace BisnessLagicLayer
{
    public class ActivityBLL
    {
        ActivityDAL dal = new ActivityDAL();

        public string Create(Activity activity, User user, Customer customer, ActivityCategory activityCategory)
        {
            return dal.Create(activity, user, customer, activityCategory);
        }


        public DataTable Read()
        {
            return dal.Read();
        }


        public Activity ReadById(int id)
        {
            return dal.ReadById(id);
        }


        public string Delete(int id)
        {
            return dal.Delete(id);
        }


        public string ReadByInfo(int id)
        {
            return dal.ReadByInfo(id);
        }
    }
}


