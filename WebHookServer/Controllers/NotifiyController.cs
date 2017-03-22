using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
namespace WebHookServer.Controllers
{
    [Authorize]
    public class NotifiyController : Controller
    {
        [HttpPost]
        public async Task<ActionResult> Submit()
        {
            // Create an event with action 'event1' and additional data
            await this.NotifyAsync("event1", new { P1 = "p1" });
            JsonConvert.SerializeObject(new { P1 = "p1" });
            return new EmptyResult();
        }
    }
}
