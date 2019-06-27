using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess.Repositories.CacheRepositories
{
    public class ToDoRepository : IRepository<ToDo>
    {
        public void DeleteById(int id)
        {
            ToDo todo = CacheDb.ToDos.FirstOrDefault(x => x.Id == id);

            if (todo != null) CacheDb.ToDos.Remove(todo);
        }

        public List<ToDo> GetAll()
        {
            return CacheDb.ToDos;
        }

        public ToDo GetById(int id)
        {
            return CacheDb.ToDos.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(ToDo entity)
        {
            CacheDb.ToDoId++;
            entity.Id = CacheDb.ToDoId;
            CacheDb.ToDos.Add(entity);
            return entity.Id;
        }

        public void Update(ToDo entity)
        {
            ToDo todo = CacheDb.ToDos.FirstOrDefault(x => x.Id == entity.Id);
            if (todo != null)
            {
                int index = CacheDb.ToDos.IndexOf(todo);
                CacheDb.ToDos[index] = entity;
            }
        }
    }
}
