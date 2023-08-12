using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BesinesEntitis;
using System.Data;

namespace BisnessLagicLayer
{
    public class CustomerBLL
    {
        CustomerDAL dal=new CustomerDAL();

        public string Create(Customer c)
        {
            if(dal.Exist(c)==false)
            {
                return dal.Create(c);
            }
            return "کاربر تکراری است";
        }


       public DataTable Read()
        {
           return dal.Read();
        }


        public DataTable Serch(string Filter,int index)
        {
            return dal.Serch(Filter,index);
        }


        public Customer ReadByid(int id)
        {
            return dal.ReadById(id);
        }


        public string Update(Customer customer,int id)
        {
            return dal.Update(customer,id);
        }


        public string Delete(int id)
        {
            return dal.Delete(id);
        }


        public List<string> ReadPhoneNumbers()
        {
            return dal.ReadPhoneNumbers();
        }


        public Customer ReadByName(string Name)
        {
            return dal.ReadByName(Name);
        }

    }
}
