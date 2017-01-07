using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.BusinessObjects.SkypeMainDB.Interfaces
{
    public interface IRepositoryBase<T>
    {
        T GetByID(int id);
        IEnumerable<T> GetAll();

        void Add(T entity);
        void Add(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);

        void SaveChanges();
    }
}
