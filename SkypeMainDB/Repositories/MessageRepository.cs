using SkypeMainDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkypeMainDB.Repositories
{
    public class MessageRepository : RepositoryBase<Messages>, IMessageRepository
    {
        public MessageRepository(mainDbEntities entities) : base(entities) { }
        public IEnumerable<Messages> GetByAccountName(string accountname)
        {
            return (from Messages messages in entities.Messages
                    where messages.dialog_partner == accountname || messages.author == accountname
                    select messages).OrderBy(t => t.timestamp).ToArray().ToList<Messages>();
        }

        public IEnumerable<Messages> GetByAccountNameFrom(string accountname, DateTime start)
        {
            long timestamp = Utils.DateTimeToTimestamp(start);
            return (from Messages messages in entities.Messages
                    where (messages.dialog_partner == accountname || messages.author == accountname) && messages.timestamp.Value > timestamp
                    select messages).ToArray().ToList<Messages>();
        }
        public IEnumerable<Messages> GetByAccountNameTo(string accountname, DateTime end)
        {
            long timestamp = Utils.DateTimeToTimestamp(end);
            return (from Messages messages in entities.Messages
                    where (messages.dialog_partner == accountname || messages.author == accountname) && messages.timestamp.Value < timestamp
                    select messages).ToArray().ToList<Messages>();
        }

        public IEnumerable<Messages> GetByAccountNameFromTo(string accountname, DateTime start, DateTime end)
        {
            long timestampstart = Utils.DateTimeToTimestamp(start);
            long timestampend = Utils.DateTimeToTimestamp(end);
            return (from Messages messages in entities.Messages
                    where (messages.dialog_partner == accountname || messages.author == accountname) && messages.timestamp.Value > timestampstart && messages.timestamp.Value < timestampend
                    select messages).ToArray().ToList<Messages>();

        }
    }
}
