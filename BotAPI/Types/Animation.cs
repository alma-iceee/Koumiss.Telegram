using BotAPI.Types.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Animation : FileBase
    {
        /// <summary>
        /// Photo width.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Photo height.
        /// </summary>
        public int Height { get; set; }
    }
}
