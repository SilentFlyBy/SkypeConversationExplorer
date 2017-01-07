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
