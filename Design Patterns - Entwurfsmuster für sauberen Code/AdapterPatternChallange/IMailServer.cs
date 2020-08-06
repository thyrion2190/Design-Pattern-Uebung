using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternChallange
{
    public interface IMailServer
    {
        void ConnectedAndSendEmail(string emailAddress, string content, string receiverName);
    }
}
