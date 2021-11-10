using BotAPI.Requests.Base;
using System.Net.Http;

namespace BotAPI.Requests
{
    public class GetMeRequest : RequestBase
    {
        public GetMeRequest() : base("getMe", HttpMethod.Get) { }
    }
}
