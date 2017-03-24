using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.WebHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebHookClient.Hubs;

namespace WebHookClient.WebHooks
{
    public class CustomWebHookHandler : WebHookHandler
    {
        private IHubContext contextHub;

        public CustomWebHookHandler()
        {
            this.Receiver = CustomWebHookReceiver.ReceiverName;
            this.contextHub = GlobalHost.ConnectionManager.GetHubContext<WebHooksHub>();
        }

        public override Task ExecuteAsync(string generator, WebHookHandlerContext context)
        {
            // Get data from WebHook
            CustomNotifications data = context.GetDataOrDefault<CustomNotifications>();

            contextHub.Clients.All.webHooksLog(data);

            // Get data from each notification in this WebHook
            foreach (IDictionary<string, object> notification in data.Notifications)
            {
                // Process data
            }

            return Task.FromResult(true);
        }
    }
}


