using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace asp_core_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _logger.LogDebug("api/values called....");
            _logger.LogInformation("api/values called....");
            _logger.LogError("api/values called....");
            for (int i = 0; i < 5000; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    Math.Acos(Math.PI / 2);
                }
                Thread.Sleep(5);
            }
            return new string[] { "value1", "value2", System.Environment.MachineName };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            _logger.LogInformation("api/id called....");
            _logger.LogDebug("api/id called....");
            _logger.LogCritical("api/id called....");
            for (int i = 0; i < id; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Math.Acos(Math.PI / 2);
                }
            }
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
