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
    public class ReminderBLL
    {
        ReminderDAL dal=new ReminderDAL();

        public string Create(Reminder r , User u)
        {
            return dal.Create(r,u);
        }


        public DataTable Read()
        {
            return dal.Read();
        }


        public Reminder ReadById(int id)
        {
            return dal.ReadByID(id);
        }


        public DataTable Serch(string Filter)
        {
            return dal.Serch(Filter);
        }


        public string Update(Reminder r,int id)
        {
            return dal.Update(r,id);
        }


        public string Delete(int id)
        {
            return dal.Delete(id);
        }


        public string Done(int id)
        {
            return dal.Done(id);
        }

    }
}
