using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class PollAnswer
    {
        /// <summary>
        /// Unique poll identifier.
        /// </summary>
        public string PollId { get; set; }

        /// <summary>
        /// The user, who changed the answer to the poll.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// 0-based identifiers of answer options, chosen by the user. May be empty if the
        /// user retracted their vote.
        /// </summary>
        public IEnumerable<int> OptionIds { get; set; }
    }
}
