using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMessageTest
{
    public class BlacklistCheckDecorator : MessageSenderDecorator
    {
        private List<string> _blacklist;
        public BlacklistCheckDecorator(IMessageSender wrappedSender, List<string> blacklist) : base (wrappedSender)
        {
            _blacklist = blacklist;
        }
        public override void Send(TextMessage message)
        {
            if (_blacklist.Contains(message.Number))
            {
                throw new Exception($"number: {message.Number} is blocked");
            }
            _wrappedSender.Send(message);
        }
    }
}
