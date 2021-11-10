using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    public class MessageId
    {
        /// <summary>
        /// Unique message identifier.
        /// </summary>
        [JsonProperty(PropertyName = "message_id")]
        public int Id { get; set; }
    }
}
