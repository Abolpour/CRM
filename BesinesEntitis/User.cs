using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinesEntitis
{
    public  class User
    {
        public User()
        {
            DeleteStatus = false;
        }
        public int id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Picture { get; set; }
        // Active And Dative Is Users => Status => وضعیت
        public bool Status { get; set; }
        public bool DeleteStatus { get; set; }
        public DateTime RegDate { get; set; }
        public List<Activity> Activities { get; set; } = new List<Activity>();
        public List<Reminder> Reminders { get; set; } = new List<Reminder>();
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
        public UserGroup UserGroup { get; set; }
    }
}
