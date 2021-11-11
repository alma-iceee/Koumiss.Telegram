using BotAPI.Requests.Base;
using BotAPI.Types;
using BotAPI.Types.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Net.Http;

namespace BotAPI.Requests
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SendMessageRequest : RequestBase
    {
        /// <summary>
        /// Unique identifier for the target chat or username of the target channel (in the
        /// format @channelusername).
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// Text of the message to be sent, 1-4096 characters after entities parsing.
        /// </summary>
        public string Text { get; set; }
#nullable enable
        /// <summary>
        /// Mode for parsing entities in the message text. See formatting options for more
        /// details..
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? ParseMode { get; set; }

        /// <summary>
        /// A JSON-serialized list of special entities that appear in message text, which can
        /// be specified instead of parse_mode.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity>? Entities { get; set; }

        /// <summary>
        /// Disables link previews for links in this message.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? DisableWebPagePreview { get; set; }

        /// <summary>
        /// Sends the message silently. Users will receive a notification with no sound.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? DisableNotification { get; set; }

        /// <summary>
        /// If the message is a reply, ID of the original message.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ReplyToMessageId { get; set; }

        /// <summary>
        /// Pass True, if the message should be sent even if the specified replied-to
        /// message is not found.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? AllowSendingWithoutReply { get; set; }

        /// <summary>
        /// Additional interface options. A JSON-serialized object for an inline keyboard,
        /// custom reply keyboard, instructions to remove reply keyboard or to force a reply
        /// from the user.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IReplyMarkup? ReplyMarkup { get; set; }
#nullable disable

        public SendMessageRequest() : base("sendMessage", HttpMethod.Post) { }
    }
}
