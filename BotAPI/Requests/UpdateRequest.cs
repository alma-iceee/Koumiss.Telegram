using BotAPI.Requests.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BotAPI.Requests
{
    public class UpdateRequest : RequestBase
    {
        public UpdateRequest() : base("getUpdates", HttpMethod.Get) { }
    }
}
