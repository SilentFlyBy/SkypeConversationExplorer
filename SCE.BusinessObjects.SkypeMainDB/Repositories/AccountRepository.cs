using SCE.BusinessObjects.SkypeMainDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.BusinessObjects.SkypeMainDB.Repositories
{
    public class AccountRepository : RepositoryBase<Accounts>, IAccountRepository
    {
        public AccountRepository(mainDbEntities entities) : base(entities) { }
    }
}
