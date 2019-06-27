using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        int Insert(T entity);
        void Update(T entity);
        void DeleteById(int id);
    }
}
