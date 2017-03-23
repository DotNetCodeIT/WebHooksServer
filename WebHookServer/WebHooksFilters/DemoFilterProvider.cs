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
        new WebHookFilter { Name = "Notifica", Description = "Notifica"},
        new WebHookFilter { Name = "Errore", Description = "Errore"},
        new WebHookFilter { Name = "InizioElaborazione", Description = "Inizio Elaborazione"},
        new WebHookFilter { Name = "FineElaborazione", Description = "Fine Elaborazione"},
    };

        public Task<Collection<WebHookFilter>> GetFiltersAsync()
        {
            return Task.FromResult(this.filters);
        }
    }
}