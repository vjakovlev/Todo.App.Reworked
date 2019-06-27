using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain;

namespace ToDoApp.Services.Services
{
    public interface IToDoService
    {
        List<ToDo> GetAllToDos();
        List<SubTask> GetAllSubTasks();
        void AddToDo(ToDo todo);
        void AddSubTask(SubTask subtask);
        ToDo GetToDoById(int id);
        SubTask GetSubTaskById(int id);
        void UpdateTask(ToDo todo);
    }
}
