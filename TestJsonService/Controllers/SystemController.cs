using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestJsonService.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class SystemController : ControllerBase {

        public SystemController() { }

        [HttpGet]
        public IActionResult GetStatus() {
            return new OkObjectResult("Status: Test Service is running fine.");
        }
    }
}