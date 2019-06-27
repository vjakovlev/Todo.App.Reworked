using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess
{
    public static class CacheDb
    {
        public static List<User> Users = new List<User>();
        public static List<SubTask> SubTasks = new List<SubTask>();
        public static List<ToDo> ToDos = new List<ToDo>();
        public static int ToDoId;
        public static int UserId;
        public static int SubTaskId;

        static CacheDb()
        {
            User john = new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                AverageFreeTime = 5
            };

            Users.Add(john);

            ToDo basketball = new ToDo()
            {
                Id = 1,
                Title = "Basketball Training",
                ImporanceOfTask = ImporanceOfTask.Medium,
                Status = Status.InProgress,
                TypeOfToDo = TypeOfTodo.Hobby
            };

            SubTask workout = new SubTask()
            {
                Id = 1,
                Title = "Workout",
                Descrition = "Workout before Training",
                SubStatus = SubStatus.NotDone
            };

            SubTask spa = new SubTask()
            {
                Id = 2,
                Title = "Spa",
                Descrition = "Spa after Training",
                SubStatus = SubStatus.NotDone
            };

            SubTasks.Add(workout);
            SubTasks.Add(spa);

            basketball.SubTasks.Add(workout);
            basketball.SubTasks.Add(spa);

            ToDo project = new ToDo()
            {
                Id = 2,
                Title = "Project",
                ImporanceOfTask = ImporanceOfTask.Important,
                Status = Status.NotDone,
                TypeOfToDo = TypeOfTodo.Work,
            };

            SubTask analyze = new SubTask()
            {
                Id = 3,
                Title = "Analyze",
                Descrition = "Analyze Data",
                SubStatus = SubStatus.Done
            };

            SubTask design = new SubTask()
            {
                Id = 4,
                Title = "Design",
                Descrition = "Design Engine",
                SubStatus = SubStatus.NotDone
            };

            SubTasks.Add(analyze);
            SubTasks.Add(design);

            project.SubTasks.Add(analyze);
            project.SubTasks.Add(design);


            ToDo readABook = new ToDo()
            {
                Id = 3,
                Title = "Reading Book",
                ImporanceOfTask = ImporanceOfTask.Important,
                Status = Status.Done,
                TypeOfToDo = TypeOfTodo.Personal,
            };

            SubTask goToLibrary = new SubTask()
            {
                Id = 5,
                Title = "Go to the library",
                Descrition = "Go to the library",
                SubStatus = SubStatus.Done
            };

            SubTask readTheBook = new SubTask()
            {
                Id = 6,
                Title = "ReadTheBook",
                SubStatus = SubStatus.NotDone
            };

            SubTasks.Add(goToLibrary);
            SubTasks.Add(readTheBook);

            readABook.SubTasks.Add(goToLibrary);
            readABook.SubTasks.Add(readTheBook);

            ToDos.Add(basketball);
            ToDos.Add(project);
            ToDos.Add(readABook);

            john.ToDos.Add(basketball);
            john.ToDos.Add(project);
            john.ToDos.Add(readABook);

            UserId = 1;
            ToDoId = 3;
            SubTaskId = 6;
        }
    }
}
