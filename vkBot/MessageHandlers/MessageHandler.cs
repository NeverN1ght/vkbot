using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using vkBot.Models;
using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace vkBot.MessageHandlers
{
    public class MessageHandler
    {
        private readonly Models.Object _message;
        private readonly VkApi api = new VkApi();
        

        public MessageHandler(Models.Object message)
        {
            _message = message;
            api.Authorize(new ApiAuthParams
            {
                AccessToken = "04d112136aa78135884c9e42cc97c5306b33b8d678fd53fb21375f44961b9ee2d4489b87447b6e1763cd9"
            });
            Answer(_message);
        }

        private void Answer(Models.Object message)
        {
            api.Messages.Send(new MessagesSendParams {
                Message = $"Вы написали: {message.Body}",
                UserId = message.User_Id
            });

            
        }
    }
}