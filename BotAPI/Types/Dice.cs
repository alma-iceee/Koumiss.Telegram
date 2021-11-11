using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BotAPI.Types
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Dice
    {
        /// <summary>
        /// Emoji on which the dice throw animation is based.
        /// </summary>
        public string Emoji { get; set; }

        /// <summary>
        /// Value of the dice, 1-6 for “🎲”, “🎯” and “🎳” base emoji, 1-5 for “🏀” and
        /// “⚽” base emoji, 1-64 for “🎰” base emoji.
        /// </summary>
        public int Value { get; set; }
    }
}
