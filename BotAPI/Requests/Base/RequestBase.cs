using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using System.Text;

namespace BotAPI.Requests.Base
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class RequestBase : IRequest
    {
        public string MethodName { get; set; }
        public HttpMethod Method { get; set; }

        public RequestBase(string methodName, HttpMethod method)
        {
            MethodName = methodName;
            Method = method;
        }
#nullable enable
        public HttpContent? ToHttpContent()
        {
            return new StringContent(content: JsonConvert.SerializeObject(this), encoding: Encoding.UTF8, mediaType: "application/json");
        }
#nullable disable
    }
}
