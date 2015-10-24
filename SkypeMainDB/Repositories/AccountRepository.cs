using SkypeMainDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkypeMainDB.Repositories
{
    public class AccountRepository : RepositoryBase<Accounts>, IAccountRepository
    {
        public AccountRepository(mainEntities entities) : base(entities) { }
    }
}
