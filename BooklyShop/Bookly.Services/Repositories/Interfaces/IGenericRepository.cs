using BooklyShop.BusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooklyShop.DataAccessLayer.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseModel
    {

        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
