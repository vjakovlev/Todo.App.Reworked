using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.WebApp.Models
{
    public class TaskDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrition { get; set; }
        public ImporanceOfTask ImporanceOfTask { get; set; }
        public Status Status { get; set; }
        public TypeOfTodo TypeOfTodo { get; set; }
        public List<SubTaskViewModel> SubTasks { get; set; } = new List<SubTaskViewModel>();
    }
}
