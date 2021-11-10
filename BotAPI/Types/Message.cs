﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Message
    {
        /// <summary>
        /// Unique message identifier inside this chat.
        /// </summary>
        public int MessageId { get; set; }
#nullable enable
        /// <summary>
        /// Optional. Sender, empty for messages sent to channels.
        /// </summary>
        public User? From { get; set; }

        /// <summary>
        /// Optional. Sender of the message, sent on behalf of a chat. The channel itself for
        /// channel messages. The supergroup itself for messages from anonymous group
        /// administrators. The linked channel for messages automatically forwarded to the
        /// discussion group.
        /// </summary>
        public Chat? SenderChat { get; set; }
#nullable disable
        /// <summary>
        /// Date the message was sent in Unix time.
        /// </summary>
        public int Date { get; set; }

        /// <summary>
        /// Conversation the message belongs to.
        /// </summary>
        public Chat Chat { get; set; }
#nullable enable
        /// <summary>
        /// Optional. For forwarded messages, sender of the original message.
        /// </summary>
        public User? ForwardFrom { get; set; }

        /// <summary>
        /// Optional. For messages forwarded from channels or from anonymous administrators,
        /// information about the original sender chat.
        /// </summary>
        public Chat? ForwardFromChat { get; set; }

        /// <summary>
        /// Optional. For messages forwarded from channels, identifier of the original message
        /// in the channel.
        /// </summary>
        public int? ForwardFromMessageId { get; set; }

        /// <summary>
        /// Optional. For messages forwarded from channels, signature of the post author if
        /// present.
        /// </summary>
        public string? ForwardSignature { get; set; }

        /// <summary>
        /// Optional. Sender's name for messages forwarded from users who disallow adding a
        /// link to their account in forwarded messages.
        /// </summary>
        public string? ForwardSenderName { get; set; }

        /// <summary>
        /// Optional. For forwarded messages, date the original message was sent in Unix time.
        /// </summary>
        public int? ForwardDate { get; set; }

        /// <summary>
        /// Optional. For replies, the original message. Note that the Message object in this
        /// field will not contain further reply_to_message fields even if it itself is a reply.
        /// </summary>
        public long ReplyToMessage { get; set; }

        /// <summary>
        /// Optional. Bot through which the message was sent.
        /// </summary>
        public User? ViaBot { get; set; }

        /// <summary>
        /// Optional. Date the message was last edited in Unix time.
        /// </summary>
        public int EditDate { get; set; }

        /// <summary>
        /// Optional. The unique identifier of a media message group this message belongs to.
        /// </summary>
        public string? MediaGroupId { get; set; }

        /// <summary>
        /// Optional. Signature of the post author for messages in channels, or the custom
        /// title of an anonymous group administrator.
        /// </summary>
        public string? AuthorSignature { get; set; }

        /// <summary>
        /// Optional. For text messages, the actual UTF-8 text of the message, 0-4096
        /// characters.
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Optional. For text messages, special entities like usernames, URLs, bot commands,
        /// etc. that appear in the text.
        /// </summary>
        public IEnumerable<MessageEntity>? Entities { get; set; }

        /// <summary>
        /// Optional. Message is an animation, information about the animation. For backward
        /// compatibility, when this field is set, the document field will also be set.
        /// </summary>
        public Animation? Animation { get; set; }

        /// <summary>
        /// Optional. Message is an audio file, information about the file.
        /// </summary>
        public Audio? Audio { get; set; }

        /// <summary>
        /// Optional. Message is a general file, information about the file.
        /// </summary>
        public Document? Document { get; set; }

        /// <summary>
        /// Optional. Message is a photo, available sizes of the photo.
        /// </summary>
        public IEnumerable<Photo>? Photo { get; set; }

        /// <summary>
        /// Optional. Message is a sticker, information about the sticker.
        /// </summary>
        public Sticker? Sticker { get; set; }

        /// <summary>
        /// Optional. Message is a video, information about the video.
        /// </summary>
        public Video? Video { get; set; }

        /// <summary>
        /// Optional. Message is a video note, information about the video message.
        /// </summary>
        public VideoNote? VideoNote { get; set; }

        /// <summary>
        /// Optional. Message is a voice message, information about the file.
        /// </summary>
        public Voice? Voice { get; set; }

        /// <summary>
        /// Optional. Caption for the animation, audio, document, photo, video or
        /// voice, 0-1024 characters.
        /// </summary>
        public string? Caption { get; set; }

        /// <summary>
        /// Optional. For messages with a caption, special entities like usernames,
        /// URLs, bot commands, etc. that appear in the caption.
        /// </summary>
        public IEnumerable<MessageEntity>? CaptionEntities { get; set; }

        /// <summary>
        /// Optional. Message is a shared contact, information about the contact.
        /// </summary>
        public Contact? Contact { get; set; }

        /// <summary>
        /// Optional. Message is a dice with random value.
        /// </summary>
        public Dice? Dice { get; set; }

        /// <summary>
        /// Optional. Message is a game, information about the game.
        /// </summary>
        public Game? Game { get; set; }

        /// <summary>
        /// Optional. Message is a native poll, information about the poll.
        /// </summary>
        public Poll? Poll { get; set; }

        /// <summary>
        /// Optional. Message is a venue, information about the venue. For backward
        /// compatibility, when this field is set, the location field will also be set.
        /// </summary>
        public Venue? Venue { get; set; }

        /// <summary>
        /// Optional. Message is a shared location, information about the location.
        /// </summary>
        public Location? Location { get; set; }

        /// <summary>
        /// Optional. New members that were added to the group or supergroup and information
        /// about them (the bot itself may be one of these members).
        /// </summary>
        public IEnumerable<User>? NewChatMembers { get; set; }

        /// <summary>
        /// Optional. A member was removed from the group, information about them (this
        /// member may be the bot itself).
        /// </summary>
        public User? LeftChatMember { get; set; }

        /// <summary>
        /// Optional. A chat title was changed to this value.
        /// </summary>
        public string? NewChatTitle { get; set; }

        /// <summary>
        /// Optional. A chat photo was change to this value.
        /// </summary>
        public IEnumerable<PhotoSize>? NewChatPhoto { get; set; }

        /// <summary>
        /// Optional. Service message: the chat photo was deleted.
        /// </summary>
        public bool? DeleteChatPhoto { get; set; }

        /// <summary>
        /// Optional. Service message: the group has been created.
        /// </summary>
        public bool? GroupChatCreated { get; set; }

        /// <summary>
        /// Optional. Service message: the supergroup has been created. This field can't be
        /// received in a message coming through updates, because bot can't be a member of a
        /// supergroup when it is created. It can only be found in reply_to_message if someone
        /// replies to a very first message in a directly created supergroup.
        /// </summary>
        public bool? SupergroupChatCreated { get; set; }

        /// <summary>
        /// Optional. Service message: the channel has been created. This field can't be
        /// received in a message coming through updates, because bot can't be a member of a
        /// channel when it is created. It can only be found in reply_to_message if someone
        /// replies to a very first message in a channel.
        /// </summary>
        public bool? ChannelChatCreated { get; set; }

        /// <summary>
        /// Optional. Service message: auto-delete timer settings changed in the chat.
        /// </summary>
        public MessageAutoDeleteTimerChanged? MessageAutoDeleteTimerChanged { get; set; }

        /// <summary>
        /// Optional. The group has been migrated to a supergroup with the specified identifier.
        /// This number may have more than 32 significant bits and some programming languages
        /// may have difficulty/silent defects in interpreting it. But it has at most 52
        /// significant bits, so a signed 64-bit integer or double-precision float type are
        /// safe for storing this identifier.
        /// </summary>
        public long? MigrateToChatId { get; set; }

        /// <summary>
        /// Optional. The supergroup has been migrated from a group with the specified
        /// identifier. This number may have more than 32 significant bits and some
        /// programming languages may have difficulty/silent defects in interpreting it. But it
        /// has at most 52 significant bits, so a signed 64-bit integer or double-precision
        /// float type are safe for storing this identifier.
        /// </summary>
        public long? MigrateFromChatId { get; set; }

        /// <summary>
        /// Optional. Specified message was pinned. Note that the Message object in this field
        /// will not contain further reply_to_message fields even if it is itself a reply.
        /// </summary>
        public Message? PinnedMessage { get; set; }

        /// <summary>
        /// Optional. Message is an invoice for a payment, information about the invoice.
        /// </summary>
        public Invoice? Invoice { get; set; }

        /// <summary>
        /// Optional. Message is a service message about a successful payment, information about
        /// the payment.
        /// </summary>
        public SuccessfulPayment? SuccessfulPayment { get; set; }

        /// <summary>
        /// Optional. The domain name of the website on which the user has logged in.
        /// </summary>
        public string? ConnectedWebsite { get; set; }

        /// <summary>
        /// Optional. Telegram Passport data.
        /// </summary>
        public PassportData? PassportData { get; set; }

        /// <summary>
        /// Optional. Service message. A user in the chat triggered another user's proximity
        /// alert while sharing Live Location.
        /// </summary>
        public ProximityAlertTriggered? ProximityAlertTriggered { get; set; }

        /// <summary>
        /// Optional. Service message: voice chat scheduled.
        /// </summary>
        public VoiceChatScheduled? VoiceChatScheduled { get; set; }

        /// <summary>
        /// Optional. Service message: voice chat started.
        /// </summary>
        public VoiceChatStarted? VoiceChatStarted { get; set; }

        /// <summary>
        /// Optional. Service message: voice chat ended.
        /// </summary>
        public VoiceChatEnded? VoiceChatEnded { get; set; }

        /// <summary>
        /// Optional. Service message: new participants invited to a voice chat.
        /// </summary>
        public VoiceChatParticipantsInvited? VoiceChatParticipantsInvited { get; set; }

        /// <summary>
        /// Optional. Inline keyboard attached to the message. login_url buttons are
        /// represented as ordinary url buttons.
        /// </summary>
        public InlineKeyboardMarkup? ReplyMarkup { get; set; }
#nullable disable
    }
}
