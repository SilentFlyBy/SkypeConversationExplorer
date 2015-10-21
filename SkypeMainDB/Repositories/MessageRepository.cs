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
        public MessageRepository(mainEntities entities) : base(entities) { }
        public IEnumerable<Messages> GetByAccountName(string accountname)
        {
            return (from Messages messages in entities.Messages
                    where messages.dialog_partner == accountname
                    select messages).OrderBy(t => t.timestamp).ToArray().ToList<Messages>();
        }
        public IEnumerable<Messages> GetByAccountName(string accountname, DateTime start, DateTime end)
        {
            if (start != null && end != null)
            {
                return (from Messages messages in entities.Messages
                        where messages.dialog_partner == accountname && Utils.TimestampToDateTime(messages.timestamp.Value) > start && Utils.TimestampToDateTime(messages.timestamp.Value) < end
                        select messages).ToArray().ToList<Messages>();
            }
            else if (start != null)
            {
                return (from Messages messages in entities.Messages
                        where messages.dialog_partner == accountname && Utils.TimestampToDateTime(messages.timestamp.Value) > start
                        select messages).ToArray().ToList<Messages>();
            }
            else if (end != null)
            {
                return (from Messages messages in entities.Messages
                        where messages.dialog_partner == accountname && Utils.TimestampToDateTime(messages.timestamp.Value) < end
                        select messages).ToArray().ToList<Messages>();
            }
            else
            {
                return (from Messages messages in entities.Messages
                        where messages.dialog_partner == accountname
                        select messages).ToArray().ToList<Messages>();
            }
        }
    }
}
