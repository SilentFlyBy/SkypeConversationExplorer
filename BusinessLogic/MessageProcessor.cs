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
    public class MessageProcessor
    {
        public IEnumerable<Messages> Messages { get; set; }

        ISCERepositoryFactory Factory;
        public MessageProcessor()
        {
            Factory = new SCERepositoryFactory();
        }
        public MessageProcessor(List<Messages> messages)
        {
            Factory = new SCERepositoryFactory();
            Messages = messages;
        }

        public void retrieveMessages(string dialogpartner)
        {
            Messages = Factory.CreateRepository<IMessageRepository>().GetByAccountName(dialogpartner);
        }
    }
}
