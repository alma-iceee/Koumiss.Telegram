using System.Net.Http;

namespace BotAPI.Requests.Base
{
    public interface IRequest
    {
        public string MethodName { get; set; }
        public HttpMethod Method { get; set; }
#nullable enable
        HttpContent? ToHttpContent();
#nullable disable
    }
}
