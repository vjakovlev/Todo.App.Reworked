using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.WebApp.Models
{
    public class SubTaskViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrition { get; set; }
        public SubStatus SubStatus { get; set; }
    }
}
