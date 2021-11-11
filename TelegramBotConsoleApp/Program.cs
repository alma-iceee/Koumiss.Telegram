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

            var update = client.Update();

            for (int i = 0; i < 10; i++)
                client.SendMessage(update[update.Count - 1].Message.Chat.Id, "HelloWorld");

            Console.WriteLine(user.Username);


            Console.ReadKey();
        }
    }
}
