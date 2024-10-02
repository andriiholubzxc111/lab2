using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMessageTest
{
    class Program
    {
        static void Main()
        {
            var message = new TextMessage
            {
                MessageText = "Hi",
                MessageDeliveryDate = DateTime.Now,
                Number = "09953912029"
            };
            var message2 = new TextMessage
            {
                MessageText = "Hello",
                MessageDeliveryDate = DateTime.Now,
                Number = "19953912029"
            };
            var blacklist = new List<string> { "09953912029" };

            IMessageSender sender = new ConsoleMessageSender();
            sender = new SaveMessageDecorator(sender);
            sender = new BlacklistCheckDecorator(sender, blacklist);

        }
    }
}
