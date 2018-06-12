using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vkBot.Models
{
    [Serializable]
    public class Response
    {
        public string Type { get; set; }

        public Object Object { get; set; }

        public int Group_Id { get; set; }
    }
}