using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinesEntitis
{
    public class ActivityCategory
    {
        public ActivityCategory()
        {
            DeleteStatus = false;
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool DeleteStatus { get; set; }
        public List<Activity> Activitys { get; set; } = new List<Activity>();
    }
}
