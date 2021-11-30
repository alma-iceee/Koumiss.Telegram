﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ChatPhoto
    {
        /// <summary>
        /// File identifier of small (160x160) chat photo. This file_id can be used only for photo
        /// download and only for as long as the photo is not changed.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string SmallFileId { get; set; }

        /// <summary>
        /// Unique file identifier of small (160x160) chat photo, which is supposed to be the
        /// same over time and for different bots. Can't be used to download or reuse the file.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string SmallFileUniqueId { get; set; }

        /// <summary>
        /// File identifier of big (640x640) chat photo. This file_id can be used only for photo
        /// download and only for as long as the photo is not changed.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string BigFileId { get; set; }

        /// <summary>
        /// Unique file identifier of big (640x640) chat photo, which is supposed to be the
        /// same over time and for different bots. Can't be used to download or reuse the file.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string BigFileUniqueId { get; set; }
    }
}
