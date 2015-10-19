using SkypeMainDB.Interfaces;
using SkypeMainDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkypeMainDB
{
    public interface IMainDbRepositoryFactory
    {
        T CreateRepository<T>() where T : IMainDbRepository;
    }
    public class MainDbRepositoryFactory : IMainDbRepositoryFactory
    {
        private readonly mainEntities container;
        private readonly Dictionary<Type, IMainDbRepository> createdRepositories = new Dictionary<Type, IMainDbRepository>();
        private readonly Dictionary<Type, Type> supportedRepositoryTypes = new Dictionary<Type, Type>();

        public MainDbRepositoryFactory()
        {
            container = new mainEntities();
            supportedRepositoryTypes.Add(typeof(IMessagesRepository), typeof(MessageRepository));
        }
        public T CreateRepository<T>() where T : IMainDbRepository
        {
            if (!supportedRepositoryTypes.ContainsKey(typeof(T)))
                throw new ArgumentException(string.Format("Unsupported repository type ({0}) passed as a generic parameter", typeof(T)));

            if (createdRepositories.ContainsKey(typeof(T)))
                return (T)createdRepositories[typeof(T)];

            createdRepositories.Add(typeof(T), (T)Activator.CreateInstance(supportedRepositoryTypes[typeof(T)], container));

            return (T)createdRepositories[typeof(T)];
        }
    }
}
