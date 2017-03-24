using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebHookClient.Hubs
{
    public class WebHooksHub : Hub
    {
        public void WebHooksLog(string data)
        {
            Clients.All.webHooksLog(data);
        }
    }
}