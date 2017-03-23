using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebHookServer.Models;

namespace WebHookServer.Controllers
{
    [Authorize]
    [RoutePrefix("api/notifyapi")]
    public class NotifyApiController : ApiController
    {
        [HttpPost]
        [Route("SendWebHook")]
        public async Task<IHttpActionResult> SendWebHook(WebHookEventModel eventData)
        {
            if (eventData.Users.Count == 0 || eventData.Users.Contains("")) {
                //Send payload to subriber
                await this.NotifyAsync(eventData.EventName, JsonConvert.DeserializeObject(eventData.JsonData));
            }
            else
            {
                if (eventData.Users.Contains("All")) {
                    //Send payload to all subribers
                    await this.NotifyAllAsync(eventData.EventName, JsonConvert.DeserializeObject(eventData.JsonData));
                }
                else
                {
                    //Send payload to all selected users
                    await this.NotifyAllAsync(eventData.EventName, JsonConvert.DeserializeObject(eventData.JsonData)
                                                                 ,(WebHook,user)=>  eventData.Users.Contains(user));
                }
            }
            return Ok(true);
        }
    }
}
