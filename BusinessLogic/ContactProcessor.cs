using SCE.BusinessObjects.SkypeMainDB;
using SCE.BusinessObjects.SkypeMainDB.Interfaces;
using SCE.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Core
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
