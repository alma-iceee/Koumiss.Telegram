using BotAPI.Requests.Base;
using BotAPI.Responses;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace BotAPIUnitTest
{
    public static class RequestHandler
    {
        public static string _baseRequestUrl = "https://api.telegram.org/bot1866937452:AAFGY576vVGjXA_e3lAjsvzueLeaN09EVJw/";

        public static Response<T> MakeRequest<T>(IRequest request)
        {
            //var url = $"{_baseRequestUrl}/{request.MethodName}";
            var url = _baseRequestUrl + request.MethodName;

            using var httpRequest = new HttpRequestMessage(method: request.Method, requestUri: url)
            {
                Content = request.ToHttpContent()
            };

            var httpResponse = SendRequest(httpRequest);

            return JsonConvert.DeserializeObject<Response<T>>(httpResponse.Content.ReadAsStringAsync().Result);
        }

        public static HttpResponseMessage SendRequest(HttpRequestMessage httpRequest)
        {
            try
            {
                var httpClient = new HttpClient();

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
