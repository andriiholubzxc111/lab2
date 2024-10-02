using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMessageTest
{
    public class SaveMessageDecorator : MessageSenderDecorator
    {
        public SaveMessageDecorator(IMessageSender wrappedSender) : base(wrappedSender) { }

        public override void Send(TextMessage message)
        {
            File.AppendAllText("messages.txt", $"{message.MessageDeliveryDate}: {message.MessageText} для {message.Number}");
            _wrappedSender.Send(message);
        }
    }
}
