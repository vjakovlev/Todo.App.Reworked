using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.Domain;

namespace ToDoApp.Services.Services
{
    public class ToDoService : IToDoService
    {
        private IRepository<ToDo> _toDoRepository;
        private IRepository<SubTask> _subtaskRepository;

        public ToDoService(IRepository<ToDo> toDoRepository, IRepository<SubTask> subtaskRepository)
        {
            _toDoRepository = toDoRepository;
            _subtaskRepository = subtaskRepository;
        }

        public void AddSubTask(SubTask subtask)
        {
             _subtaskRepository.Insert(subtask);
        }

        public void AddToDo(ToDo todo)
        {
            _toDoRepository.Insert(todo);
        }

        public List<SubTask> GetAllSubTasks()
        {
            return _subtaskRepository.GetAll();
        }

        public List<ToDo> GetAllToDos()
        {
            return _toDoRepository.GetAll();
        }

        public SubTask GetSubTaskById(int id)
        {
            return _subtaskRepository.GetById(id);
        }

        public ToDo GetToDoById(int id)
        {
            return _toDoRepository.GetById(id);
        }

        public void UpdateTask(ToDo todo)
        {
             _toDoRepository.Update(todo);
        }
    }
}
