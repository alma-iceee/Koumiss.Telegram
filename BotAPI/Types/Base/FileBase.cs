using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types.Base
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class FileBase
    {
        /// <summary>
        /// Identifier for this file, which can be used to download or reuse the file.
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// Unique identifier for this file, which is supposed to be the same over time and for
        /// different bots. Can't be used to download or reuse the file.
        /// </summary>
        public string FileUniqueId { get; set; }
#nullable enable
        /// <summary>
        /// Optional. File size in bytes.
        /// </summary>
        public int? FileSize { get; set; }
#nullable disable
    }
}
