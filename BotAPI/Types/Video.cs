using BotAPI.Types.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Video : FileBase
    {
        /// <summary>
        /// Video width as defined by sender.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Video height as defined by sender.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Duration of the video  in seconds as defined by sender.
        /// </summary>
        public int Duration { get; set; }
#nullable enable
        /// <summary>
        /// Optional. Optional. Video thumbnail.
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
