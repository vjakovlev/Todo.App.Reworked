using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.WebApp.Models
{
    public class UserStatisticViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AverageFreeTime { get; set; }
        public List<ToDoViewModel> ToDos { get; set; } = new List<ToDoViewModel>();
    }
}
