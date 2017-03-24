using Microsoft.AspNet.Identity;
using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebHookServer.WebHooksFilters;

namespace WebHookServer.Controllers
{
    public class WebHooksController : Controller
    {
      
        [Authorize]
        public async Task<ActionResult> Register()
        {
            ViewBag.Message = "WebHooks Register";

            DemoFilterProvider prov = new DemoFilterProvider();
            Collection<WebHookFilter> list = await prov.GetFiltersAsync();

            return View(list);
        }

        // GET: WebHooks
        [Authorize]
        public async Task<ActionResult> Index()
        {
            ViewBag.Message = "WebHooks List";

            Collection<WebHook> list = new Collection<WebHook>();

            DemoFilterProvider prov = new DemoFilterProvider();
            Collection<WebHookFilter> filters = await prov.GetFiltersAsync();

            ViewBag.Filters = filters;
            return View(list);
        }

        [Authorize]
        public async Task<ActionResult> Test()
        {
            ViewBag.Message = "WebHooks Test";
            DemoFilterProvider prov = new DemoFilterProvider();
            Collection<WebHookFilter> filters = await prov.GetFiltersAsync();

            ViewBag.Filters = filters;

            return View();
        }


        [Authorize]
        public async Task<ActionResult> ClientList()
        {
            ViewBag.Message = "WebHooks AJAX List";

            DemoFilterProvider prov = new DemoFilterProvider();
            Collection<WebHookFilter> list = await prov.GetFiltersAsync();

            return View(list);
        }

    }
}