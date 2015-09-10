using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackEnd.Controllers
{
    public class VictimsController : ApiController
    {
        // GET api/victims
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/victims/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/victims
        public void Post([FromBody]string value)
        {
        }

        // PUT api/victims/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/victims/5
        public void Delete(int id)
        {
        }
    }
}
