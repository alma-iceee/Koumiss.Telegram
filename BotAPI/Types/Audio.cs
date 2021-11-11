using BotAPI.Types.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Audio : FileBase
    {
        /// <summary>
        /// Duration of the audio in seconds as defined by sender.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public int Duration { get; set; }
#nullable enable
        /// <summary>
        /// Optional. Performer of the audio as defined by sender or by audio tags.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Performer { get; set; }

        /// <summary>
        /// Optional. Title of the audio as defined by sender or by audio tags.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Title { get; set; }

        /// <summary>
        /// Optional. Original filename as defined by sender.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? FileName { get; set; }

        /// <summary>
        /// Optional. MIME type of the file as defined by sender.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? MimeType { get; set; }

        /// <summary>
        /// Optional. Thumbnail of the album cover to which the music file belongs.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize? Thumb { get; set; }
#nullable disable
    }
}
