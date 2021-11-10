using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Chat
    {
        /// <summary>
        /// Unique identifier for this chat. This number may have more than 32 significant bits
        /// and some programming languages may have difficulty/silent defects in interpreting
        /// it. But it has at most 52 significant bits, so a signed 64-bit integer or
        /// double-precision float type are safe for storing this identifier.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Type of chat, can be either “private”, “group”, “supergroup” or “channel”.
        /// </summary>
        public string Type { get; set; }

#nullable enable
        /// <summary>
        /// Optional. Title, for supergroups, channels and group chats.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Optional. Username, for private chats, supergroups and channels if available.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Optional. First name of the other party in a private chat.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Optional. Last name of the other party in a private chat.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Optional. Chat photo. Returned only in getChat.
        /// </summary>
        public ChatPhoto? Photo { get; set; }

        /// <summary>
        /// Optional. Bio of the other party in a private chat. Returned only in getChat.
        /// </summary>
        public string? Bio { get; set; }

        /// <summary>
        /// Optional. Description, for groups, supergroups and channel chats. Returned only in
        /// getChat.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Optional. Primary invite link, for groups, supergroups and channel chats. Returned
        /// only in getChat.
        /// </summary>
        public string? InviteLink { get; set; }

        /// <summary>
        /// Optional. The most recent pinned message (by sending date). Returned only in
        /// getChat.
        /// </summary>
        public Message? PinnedMessage { get; set; }

        /// <summary>
        /// Optional. Default chat member permissions, for groups and supergroups. Returned
        /// only in getChat.
        /// </summary>
        public ChatPermissions? Permissions { get; set; }

        /// <summary>
        /// Optional. For supergroups, the minimum allowed delay between consecutive messages
        /// sent by each unpriviledged user; in seconds. Returned only in getChat
        /// </summary>
        public int? SlowModeDelay { get; set; }

        /// <summary>
        /// Optional. The time after which all messages sent to the chat will be automatically
        /// deleted; in seconds. Returned only in getChat.
        /// </summary>
        public int? MessageAutoDeleteTime { get; set; }

        /// <summary>
        /// Optional. For supergroups, name of group sticker set. Returned only in getChat.
        /// </summary>
        public string? StickerSetName { get; set; }

        /// <summary>
        /// Optional. True, if the bot can change the group sticker set. Returned only in
        /// getChat.
        /// </summary>
        public bool? CanSetStickerSet { get; set; }

        /// <summary>
        /// Optional. Unique identifier for the linked chat, i.e. the discussion group
        /// identifier for a channel and vice versa; for supergroups and channel chats. This
        /// identifier may be greater than 32 bits and some programming languages may have
        /// difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a
        /// signed 64 bit integer or double-precision float type are safe for storing this
        /// identifier. Returned only in getChat.
        /// </summary>
        public long? LinkedChatId { get; set; }

        /// <summary>
        /// Optional. For supergroups, the location to which the supergroup is connected.
        /// Returned only in getChat.
        public ChatLocation? Location { get; set; }
#nullable disable
    }
}
