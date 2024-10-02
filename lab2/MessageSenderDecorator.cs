using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMessageTest
{
    public abstract class MessageSenderDecorator: IMessageSender
    {
        protected IMessageSender _wrappedSender;

        public MessageSenderDecorator(IMessageSender wrappedSender)
        {
            _wrappedSender = wrappedSender;
        }
        public abstract void Send(TextMessage message);
    }
}
