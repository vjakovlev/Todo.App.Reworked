using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Domain;
using ToDoApp.Services.Services;
using ToDoApp.WebApp.Models;

namespace ToDoApp.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IToDoService _todoService;
        private IUserService _userService;
        public HomeController(IToDoService todoService, IUserService userService)
        {
            _todoService = todoService;
            _userService = userService;
        }
        public IActionResult Index()
        {        
            User user = _userService.GetUserById(1);
            UserStatisticViewModel model = new UserStatisticViewModel()
            {
                 FirstName = user.FirstName,
                 LastName = user.LastName,
                 AverageFreeTime = user.AverageFreeTime
            };
            return View(model);
        }
    }
}
