using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AverageFreeTime { get; set; }
        public List<ToDo> ToDos { get; set; } = new List<ToDo>();
    }
}
