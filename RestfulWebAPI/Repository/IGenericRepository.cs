using RestfulWebAPI.Models;
using System.Collections.Generic;

namespace RestfulWebAPI.Repository
{
    public interface IGenericRepository<T> where T : class, new() 
    {
        //  CRUD  CREATE UPDATE READ DELETE

        T Add(T entity);

        T Delete(T entity);

        T GetById(int id);

        List<T> GetAll();

        T UpdateById(T entity, int id);

    }
}
