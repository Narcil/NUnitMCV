using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NUnitMCV.Backend.Domain;

namespace NUnitMCV.Backend.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly BackendConfigurations _backendConfigurations;

        public ValuesController(IOptions<BackendConfigurations> backendConfigurations)
        {
            _backendConfigurations = backendConfigurations.Value;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return _backendConfigurations.BackendValue;
        }


    }
}
