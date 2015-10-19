using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkypeMainDB.Interfaces
{
    public interface IMessageRepository : IRepositoryBase<Messages>, IMainDbRepository
    {
        IEnumerable<Messages> GetByAccountName(string accountname, DateTime start, DateTime end);
    }
}
