using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class PollOption
    {
        /// <summary>
        /// Option text, 1-100 characters.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Number of users that voted for this option.
        /// </summary>
        public int VoterCount { get; set; }
    }
}
