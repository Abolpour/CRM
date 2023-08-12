using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinesEntitis
{
    public class Reminder
    {
        //Reminder => یادآوری
        public Reminder()
        {
            IsDone = false;
            DeleteStatus = false;
        }
        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public string ReminderInfo { get; set; }
        public DateTime RegDate { get; set; }
        public bool DeleteStatus { get; set; }
        public DateTime ReminderDate { get; set; }
        //IsDone => انجام شده
        public bool IsDone { get; set; }
        public User Users { get; set; } 
    }
}
