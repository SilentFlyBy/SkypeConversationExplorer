using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkypeMainDB;
using SkypeMainDB.Interfaces;

namespace BusinessLogic
{
    public class SCERepositoryFactory : ISCERepositoryFactory
    {
        public T CreateRepository<T>() where T : class
        {
            if(typeof(IMainDbRepository).IsAssignableFrom(typeof(T))) { 

            }
            throw new NotImplementedException();
        }
    }
}
