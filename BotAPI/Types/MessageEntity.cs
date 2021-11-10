namespace BotAPI.Types
{
    public class MessageEntity
    {
        /// <summary>
        /// Type of the entity. Can be “mention” (@username), “hashtag” (#hashtag), “cashtag”
        /// ($USD), “bot_command” (/start@jobs_bot), “url” (https://telegram.org), “email”
        /// (do-not-reply@telegram.org), “phone_number” (+1-212-555-0123), “bold” (bold text),
        /// “italic” (italic text), “underline” (underlined text), “strikethrough”
        /// (strikethrough text), “code” (monowidth string), “pre” (monowidth block),
        /// “text_link” (for clickable text URLs), “text_mention” (for users without usernames).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Offset in UTF-16 code units to the start of the entity.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Length of the entity in UTF-16 code units.
        /// </summary>
        public int Length { get; set; }
#nullable enable
        /// <summary>
        /// Optional. For “text_link” only, url that will be opened after user taps on the text.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// Optional. For “text_mention” only, the mentioned user.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Optional. For “pre” only, the programming language of the entity text.
        /// </summary>
        public string? Language { get; set; }
#nullable disable
    }
}
