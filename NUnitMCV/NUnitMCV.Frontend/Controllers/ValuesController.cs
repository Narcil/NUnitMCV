using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NUnitMCV.Frontend.Domain;

namespace NUnitMCV.Frontend.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly FrontendConfigurations _frontendConfigurations;

        public ValuesController(IOptions<FrontendConfigurations> frontendConfigurations)
        {
            _frontendConfigurations = frontendConfigurations.Value;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return _frontendConfigurations.FrontendValue;
        }


    }
}
