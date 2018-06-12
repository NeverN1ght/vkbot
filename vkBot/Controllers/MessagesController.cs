using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using vkBot.MessageHandlers;
using vkBot.Models;

namespace vkBot.Controllers
{
    public class MessagesController : ApiController
    {
        // POST: api/Messages
        [HttpPost]
        public HttpResponseMessage Post([FromBody]Response response)
        {
            var result = Request.CreateResponse(HttpStatusCode.OK);

            if (response.Type == "confirmation")
            {
                result.Content = new StringContent("c14859f5");
                return result;
            }
            else if (response.Type == "message_new")
            {
                var mh = new MessageHandler(response.Object);
                result.Content = new StringContent("ok");
                return result;
            }           
            result.Content = new StringContent("ok");
            return result;
        }
    }
}
