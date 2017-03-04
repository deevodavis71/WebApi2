using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi2_1.Data;
using Microsoft.Extensions.Logging;
using WebApi2_1.Data.Model;

namespace WebApi2_1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ILogger _logger;
        private readonly CustomerContext _customerContext;

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get(ILogger<ValuesController> logger, CustomerContext context)
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            _logger.LogDebug("Called Get()");

            //var context = new OrderContext();
            _customerContext.Customers.Add(new Customer { Firstname = "Steve", Surname = "Davis" });
            _customerContext.SaveChanges();

            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
