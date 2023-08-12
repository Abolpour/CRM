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
    public class ProductBLL
    {
        ProductDAL dal = new ProductDAL();


        public string Create(Product p)
        {
            if (dal.Exist(p) == false)
            {
                return dal.Create(p);
            }
            return "کاربر تکراری است";
        }


        public DataTable Read()
        {
            return dal.Read();
        }


        public Product ReadByid(int id)
        {
            return dal.ReadById(id);
        }


        public string Update(Product product, int id)
        {
            return dal.Update(product, id);
        }


        public string Delete(int id)
        {
            return dal.Delete(id);
        }



        public DataTable Serch(string Filter)
        {
            return dal.Serch(Filter);
        }


        public List<string> ReadByName()
        {
            return dal.ReadByName();
        }


        public Product ReadByNameList(string product)
        {
            return dal.ReadByNameList(product);
        }


        public string ProductsCount()
        {
            return dal.ProductsCount();
        }
    }
}
