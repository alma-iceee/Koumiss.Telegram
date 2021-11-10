using BotAPI.Requests;
using BotAPI.Types;
using System.Collections.Generic;

namespace Client
{
    public static class TelegramBotClientExtensions
    {
        public static User GetMe(this TelegramBotClient client)
        {
            return client.MakeRequest<User>(new GetMeRequest()).Result;
        }
        public static int Update(this TelegramBotClient client)
        {
            var result = client.MakeRequest<List<Update>>(new UpdateRequest()).Result;
            return result.Count;
        }
    }
}
