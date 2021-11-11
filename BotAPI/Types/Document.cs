using BotAPI.Types.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Document : FileBase
    {
#nullable enable
        /// <summary>
        /// Optional. Document thumbnail as defined by sender.
        /// </summary>
        public PhotoSize? Thumb { get; set; }

        /// <summary>
        /// Optional. Original filename as defined by sender.
        /// </summary>
        public string? FileName { get; set; }

        /// <summary>
        /// Optional. MIME type of the file as defined by sender.
        /// </summary>
        public string? MimeType { get; set; }
#nullable disable
    }
}
