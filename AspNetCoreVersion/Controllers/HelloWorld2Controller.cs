using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreVersion.Controllers
{
    [Route("api/HelloWorld")]
    //[Route("api/v{version:apiversion}/HelloWorld")]
    [ApiController]
    [ApiVersion("2.0")]
    public class HelloWorld2Controller : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "Hello World 2";
        }
    }
}
