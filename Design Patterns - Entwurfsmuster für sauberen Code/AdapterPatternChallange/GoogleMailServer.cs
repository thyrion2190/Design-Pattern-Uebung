using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternChallange
{
    public class GoogleMailServer
    {
        public GoogleMailServer()
        {

        }

        public void BuildConnection()
        {
            Console.WriteLine("Connection was builded");
        }

        public void SendEmail(string receiverEmail, string content)
        {
            Console.WriteLine("The Email was send to " + receiverEmail);
            Console.WriteLine("The content of the Email was: " + content);
        }
    }
}
