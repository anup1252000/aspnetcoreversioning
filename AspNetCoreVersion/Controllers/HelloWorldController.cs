using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreVersion.Controllers
{
    [Route("api/[controller]")]
    //[Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class HelloWorldController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "Hello world";
        }

        [HttpGet,MapToApiVersion("1.1")]
        public string Get11()
        {
            return "Hello world v1.1";
        }

    }
}
