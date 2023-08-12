using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesinesEntitis;
namespace DataAccessLayer
{
    public class DashbordDAL
    {
        DB db=new DB();

        public string UserReminderCount(User u)
        {
            User q=db.Users.Include("Reminders").Where(i=>i.id == u.id).FirstOrDefault();
            return q.Reminders.Count().ToString();
        }


        public string CustomersCount()
        {
            return db.Customers.Count().ToString();
        }


        public string SellsCount()
        {
            int sum=0;
            foreach (var item in db.Invoices)
            {
                if(item.RegDate.Date == DateTime.Today)
                {
                    sum=sum+1;
                }
            }
            return sum.ToString();
        }



        public List<Reminder> GetUserReminder(User user)
        {
            return db.Reminders.Include("Users").Where(i=>i.Users.id== user.id).ToList();
        }
    }
}
