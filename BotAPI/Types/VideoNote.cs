using BotAPI.Types.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class VideoNote : FileBase
    {
        /// <summary>
        /// Video width and height (diameter of the video message) as defined by sender.
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Duration of the video  in seconds as defined by sender.
        /// </summary>
        public int Duration { get; set; }
#nullable enable
        /// <summary>
        /// Optional. Optional. Video thumbnail.
        /// </summary>
        public PhotoSize? Thumb { get; set; }
#nullable disable
    }
}
