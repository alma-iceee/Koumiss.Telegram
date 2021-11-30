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

        /// <summary>
        /// Send a new Message.
        /// </summary>
        /// <param name="chatId">Chat Id.</param>
        /// <param name="text">Message text.</param>
        public static Message SendMessage(this TelegramBotClient client, long chatId, string text)
        {
            return client.MakeRequest<Message>(new SendMessageRequest() { ChatId = chatId.ToString(), Text = text }).Result;
        }



        public static List<Update> Update(this TelegramBotClient client)
        {
            return client.MakeRequest<List<Update>>(new UpdateRequest()).Result;
        }
    }
}
