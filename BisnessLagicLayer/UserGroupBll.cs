using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesinesEntitis;
using DataAccessLayer;
namespace BisnessLagicLayer
{
    public class UserGroupBll
    {
        UserGroupDAL dal = new UserGroupDAL();

        public string Create(UserGroup userGroup)
        {
            return dal.Create(userGroup);
        }

        public bool ReadByTitle(string Title)
        {
            return dal.ReadByTitle(Title);
        }


        public List<string> ListReadUGTitle()
        {
            return dal.ListReadUGTitle();
        }


        public UserGroup ReadBySingelTitle(string title)
        {
            return dal.ReadBySingelTitle(title);
        }


    }
}
