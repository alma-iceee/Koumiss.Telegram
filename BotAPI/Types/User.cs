using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class User
    {
        /// <summary>
        /// Unique identifier for this user or bot. This number may have more than 32
        /// significant bits and some programming languages may have difficulty/silent defects
        /// in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or
        /// double-precision float type are safe for storing this identifier.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// True, if this user is a bot.
        /// </summary>
        public bool IsBot { get; set; }

        /// <summary>
        /// User's or bot's first name.
        /// </summary>
        public string FirstName { get; set; }
#nullable enable
        /// <summary>
        /// Optional. User's or bot's last name.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Optional. User's or bot's username.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Optional. IETF language tag of the user's language.
        /// </summary>
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Optional. True, if the bot can be invited to groups. Returned only in getMe.
        /// </summary>
        public bool? CanJoinGroups { get; set; }

        /// <summary>
        /// Optional. True, if privacy mode is disabled for the bot. Returned only in getMe.
        /// </summary>
        public bool? CanReadAllGroupMessages { get; set; }

        /// <summary>
        /// Optional. True, if the bot supports inline queries. Returned only in getMe.
        /// </summary>
        public bool? SupportsInlineQueries { get; set; }
#nullable disable
    }
}
