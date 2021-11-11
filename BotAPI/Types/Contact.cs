using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Contact
    {
        /// <summary>
        /// Contact's phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Contact's first name.
        /// </summary>
        public string FirstName { get; set; }
#nullable enable
        /// <summary>
        /// Optional. Contact's last name.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Optional. Contact's user identifier in Telegram. This number may have more than 32
        /// significant bits and some programming languages may have difficulty/silent defects
        /// in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or
        /// double-precision float type are safe for storing this identifier.
        /// </summary>
        public string? UserId { get; set; }

        /// <summary>
        /// Optional. Additional data about the contact in the form of a vCard.
        /// </summary>
        public string? Vcard { get; set; }
#nullable disable
    }
}
