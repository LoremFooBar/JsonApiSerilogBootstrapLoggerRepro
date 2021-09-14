using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using JsonApiSerilogBootstrapLoggerRepro.Model;
using Microsoft.Extensions.Logging;

namespace JsonApiSerilogBootstrapLoggerRepro.Controllers
{
    public class ContactsController : JsonApiController<Contact>
    {
        public ContactsController(IJsonApiOptions options, ILoggerFactory loggerFactory,
            IResourceService<Contact, int> resourceService) : base(options, loggerFactory, resourceService)
        {
        }
    }
}
