using System;

namespace AdapterPatternChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            GoogleMailServer mailServer = new GoogleMailServer();
            mailServer.BuildConnection();
            mailServer.SendEmail("Mustermann@gmail.com", "Hello this is a E-Mail");

            Console.WriteLine();

            Adapter adapter = new Adapter(mailServer);
            adapter.ConnectedAndSendEmail("Mustermann@test.de", "This was a Test E-Mail for test only", "Mr. Mustermann");
            Console.ReadLine();
        }
    }
}
