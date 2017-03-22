using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHookServer.Models
{
    public class WebHookEventModel
    {
        public WebHookEventModel()
        {
            Users = new List<string>();
        }
        public string EventName { get; set; }

        public string JsonData { get; set; }

        public List<string> Users { get; set; }
    }
}