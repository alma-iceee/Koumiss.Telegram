using BotAPI.Types.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Voice : FileBase
    {
        /// <summary>
        /// Duration of the audio   in seconds as defined by sender.
        /// </summary>
        public int Duration { get; set; }
#nullable enable
        /// <summary>
        /// Optional. MIME type of the file as defined by sender.
        /// </summary>
        public string? MimeType { get; set; }
#nullable disable
    }
}
