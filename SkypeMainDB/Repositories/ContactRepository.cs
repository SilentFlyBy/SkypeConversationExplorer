using SkypeMainDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkypeMainDB.Repositories
{
    public class ContactRepository : RepositoryBase<Contacts>, IContactRepository
    {
        public ContactRepository(mainEntities entities) : base(entities) { }
    }
}
