using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain;
using System.Linq;

namespace ToDoApp.DataAccess.Repositories.CacheRepositories
{
    public class SubTaskRepository : IRepository<SubTask>
    {

        public void DeleteById(int id)
        {
            SubTask subtask = CacheDb.SubTasks.FirstOrDefault(x => x.Id == id);

            if (subtask != null) CacheDb.SubTasks.Remove(subtask);
        }

        public List<SubTask> GetAll()
        {
            return CacheDb.SubTasks;
        }

        public SubTask GetById(int id)
        {
            return CacheDb.SubTasks.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(SubTask entity)
        {
            CacheDb.SubTaskId++;
            entity.Id = CacheDb.SubTaskId;
            CacheDb.SubTasks.Add(entity);
            return entity.Id;
        }

        public void Update(SubTask entity)
        {
            SubTask subtask = CacheDb.SubTasks.FirstOrDefault(x => x.Id == entity.Id);
            if (subtask != null)
            {
                int index = CacheDb.SubTasks.IndexOf(subtask);
                CacheDb.SubTasks[index] = entity;
            }
        }
    }
}
