using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.WebApp.Models
{
    public class AddTaskViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [Display(Name = "Importance Of Task")]
        public ImporanceOfTask ImporanceOfTask { get; set; }
        [Display(Name = "Type Of Task")]
        public TypeOfTodo TypeOfTodo { get; set; }
        public List<SubTaskViewModel> SubTasks { get; set; }

    }
}
