using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BesinesEntitis;
namespace BisnessLagicLayer
{
    public class DashbordBLL
    {
        DashbordDAL dal = new DashbordDAL();
        public string UserReminderCount(User u)
        {
            return dal.UserReminderCount(u);
        }

        public string CustomersCount()
        {
            return dal.CustomersCount();
        }


        public string SellsCount()
        {
            return dal.SellsCount();
        }


        public List<Reminder> GetUserReminder(User user)
        {
            return dal.GetUserReminder(user);
        }
    }
}
