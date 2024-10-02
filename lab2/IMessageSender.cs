using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMessageTest
{
    public interface IMessageSender
    {
        void Send(TextMessage message);
    }
}
