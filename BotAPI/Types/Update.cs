using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Update
    {
        public int Id { get; set; }
        public Message? Message { get; set; }
        public Message? EditedMessage { get; set; }
        public Message? ChannelPost { get; set; }
        public Message? EditedChannelPost { get; set; }
    }
}
