using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.BusinessObjects.SkypeMainDB.Interfaces
{
    public interface IMessageRepository : IRepositoryBase<Messages>, IMainDbRepository
    {
        /// <summary>
        /// gets a list of messages
        /// </summary>
        /// <param name="accountname">dialog partner</param>
        /// <param name="start">start DateTime</param>
        /// <param name="end">end DateTime</param>
        /// <returns></returns>
        IEnumerable<Messages> GetByAccountNameFromTo(string accountname, DateTime start, DateTime end);
        IEnumerable<Messages> GetByAccountNameFrom(string accountname, DateTime start);
        IEnumerable<Messages> GetByAccountNameTo(string accountname, DateTime end);
        IEnumerable<Messages> GetByAccountName(string accountname);
    }
}
