using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkypeMainDB;
using SCE.BusinessObjects.SkypeMainDB;
using SCE.BusinessObjects.SkypeMainDB.Interfaces;
using SCE.Core.Interfaces;

namespace SCE.Core
{
    public class SCERepositoryFactory : ISCERepositoryFactory
    {
        private IMainDbRepositoryFactory MainDbFactory;
        public SCERepositoryFactory()
        {
            MainDbFactory = new MainDbRepositoryFactory();
        }
        public T CreateRepository<T>() where T : class
        {
            if(typeof(IMainDbRepository).IsAssignableFrom(typeof(T))) {
                return (T)typeof(MainDbRepositoryFactory).GetMethod("CreateRepository").MakeGenericMethod(typeof(T)).Invoke(MainDbFactory, null);
            }
            throw new ArgumentException("Repository type not supported");
        }
    }
}
