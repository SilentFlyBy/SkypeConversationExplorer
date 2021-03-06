﻿using SCE.BusinessObjects.SkypeMainDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.BusinessObjects.SkypeMainDB.Repositories
{
    public class ContactRepository : RepositoryBase<Contacts>, IContactRepository
    {
        public ContactRepository(mainDbEntities entities) : base(entities)
        {
        }
    }
}
