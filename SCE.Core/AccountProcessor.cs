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
    public class AccountProcessor
    {
        private ISCERepositoryFactory ISCEFactory;

        public AccountProcessor()
        {
            ISCEFactory = new SCERepositoryFactory();
        }
        public IEnumerable<Accounts> getAllAccounts()
        {
            return ISCEFactory.CreateRepository<IAccountRepository>().GetAll();
        }
    }
}
