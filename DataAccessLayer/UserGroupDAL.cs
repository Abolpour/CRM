using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesinesEntitis;

namespace DataAccessLayer
{
    public class UserGroupDAL
    {
        DB db = new DB();
        public string Create(UserGroup userGroup)
        {
            try
            {
                db.UserGroups.Add(userGroup);
                db.SaveChanges();
                return "ثبت گروه کاربری ب موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return "در ثبت گروه کاربری مشکلی به وجو آمد" + e.Message;
            }
        }
        public bool ReadByTitle(string Title)
        {
            return !db.UserGroups.Any(x => x.Title == Title);
        }

        public List<string> ListReadUGTitle()
        {
            return db.UserGroups.Select(x => x.Title).ToList();
        }


        public UserGroup ReadBySingelTitle(string title)
        {
            return db.UserGroups.Where(x => x.Title == title).SingleOrDefault();
        }



    }
}
