using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMessageTest
{
    public class ConsoleMessageSender : IMessageSender
    {
        public void Send(TextMessage message)
        {
            Console.WriteLine("Надсилання повідомлення для {0}: {1}", message.Number, message.MessageText);
        }
    }
}
