using System;
using Client;

namespace TelegramBotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "1866937452:AAFGY576vVGjXA_e3lAjsvzueLeaN09EVJw";

            var client = new TelegramBotClient(token);

            var user = client.GetMe();

            var count = 1;

            while (count == 1)
            {
                count = client.Update();
            }

            Console.WriteLine(user.Username);

            Console.WriteLine(client._ipAddress);

            Console.ReadKey();
        }
    }
}
