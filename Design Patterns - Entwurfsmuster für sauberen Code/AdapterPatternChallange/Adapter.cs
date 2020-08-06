using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternChallange
{
    public class Adapter : IMailServer
    {
        private GoogleMailServer mailServer;

        public Adapter(GoogleMailServer mailServer)
        {
            this.mailServer = mailServer;
        }
        public void ConnectedAndSendEmail(string emailAddress, string content, string receiverName)
        {
            mailServer.BuildConnection();
            Console.WriteLine("The E-Mail was encrypted");
            mailServer.SendEmail(emailAddress, content);
            Console.WriteLine("Name of the receiver: " + receiverName);
        }
    }
}
