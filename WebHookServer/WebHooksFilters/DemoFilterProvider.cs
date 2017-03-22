using Microsoft.AspNet.WebHooks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebHookServer.WebHooksFilters
{
    public class DemoFilterProvider : IWebHookFilterProvider
    {
        private readonly Collection<WebHookFilter> filters = new Collection<WebHookFilter>
    {
        new WebHookFilter { Name = "notifica", Description = "Notifica"},
        new WebHookFilter { Name = "errore", Description = "Errore"},
        new WebHookFilter { Name = "inizioElaborazione", Description = "Inizio Elaborazione"},
        new WebHookFilter { Name = "fineElaborazione", Description = "Fine Elaborazione"},
    };

        public Task<Collection<WebHookFilter>> GetFiltersAsync()
        {
            return Task.FromResult(this.filters);
        }
    }
}