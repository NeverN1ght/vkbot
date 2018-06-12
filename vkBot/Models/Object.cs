using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vkBot.Models
{
    [Serializable]
    public class Object
    {
        public int Id { get; set; }

        public int User_Id { get; set; }

        public int Date { get; set; }

        public int Read_State { get; set; }

        public int Out { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        //public object Geo { get; set; }

        //public object[] Attachments { get; set; }

        //public object[] FwdMessages { get; set; }

        //public int Emoji { get; set; }

        //public int Important { get; set; }

        //public int Deleted { get; set; }

        //public int RandomId { get; set; }
    }
}