using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
namespace BotAPI.Responses
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Response<T> : IResponse<T>
    {
        public bool Ok { get; set; }
        public T Result { get; set; }
    }
}
