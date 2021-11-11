using BotAPI.Responses;
using BotAPI.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net;

namespace Client
{
    public class TelegramBotClient
    {
        public const string BaseTelegramUrl = "https://api.telegram.org";

        public string _baseRequestUrl;
        public HttpClient _httpClient;
        public IPAddress _ipAddress;

        public TelegramBotClient(string token)
        {
            _baseRequestUrl = $"{BaseTelegramUrl}/bot{token}";
            _httpClient = new HttpClient();
            var ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            _ipAddress = ipHostInfo.AddressList[0];
        }

        public Response<T> MakeRequest<T>(IRequest request)
        {
            var url = $"{_baseRequestUrl}/{request.MethodName}";

            var content = request.ToHttpContent();

            var json = content.ReadAsStringAsync().Result;

            using var httpRequest = new HttpRequestMessage(method: request.Method, requestUri: url)
            {
                Content = request.ToHttpContent()
            };

            var httpResponse = SendRequest(_httpClient, httpRequest);

            return JsonConvert.DeserializeObject<Response<T>>(httpResponse.Content.ReadAsStringAsync().Result);
        }

        public HttpResponseMessage SendRequest(HttpClient httpClient, HttpRequestMessage httpRequest)
        {
            try
            {
                return httpClient.Send(request: httpRequest);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
