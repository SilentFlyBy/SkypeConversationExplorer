using BusinessLogic.Interfaces;
using SkypeMainDB;
using SkypeMainDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ContactProcessor
    {
        private ISCERepositoryFactory ISCEFactory;

        public ContactProcessor()
        {
            ISCEFactory = new SCERepositoryFactory();
        }
        public IEnumerable<Contacts> getAllContacts()
        {
            return ISCEFactory.CreateRepository<IContactRepository>().GetAll(); 
        }
    }
}
