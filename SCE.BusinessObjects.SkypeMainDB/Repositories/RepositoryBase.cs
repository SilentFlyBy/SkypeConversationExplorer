using SCE.BusinessObjects.SkypeMainDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.BusinessObjects.SkypeMainDB.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected mainDbEntities entities = null;

        public RepositoryBase(mainDbEntities entities)
        {
            this.entities = entities;
        }

        public virtual T GetByID(int ID)
        {
            return this.entities.Set<T>().Find(ID);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return (from T item in this.entities.Set<T>() select item).ToList();
        }

        public virtual void Add(T entity)
        {
            this.entities.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            this.entities.Set<T>().Remove(entity);
        }

        public virtual void SaveChanges()
        {
            try
            {
                this.entities.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }

        }


        public virtual void Add(IEnumerable<T> entities)
        {
            foreach (T item in entities)
            {
                this.entities.Set<T>().Add(item);
            }
        }

        public virtual void Delete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
