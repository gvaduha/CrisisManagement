﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackEnd.Controllers
{
    public class MailBoxController : ApiController
    {
        // GET: api/MailBox
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MailBox/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MailBox
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MailBox/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MailBox/5
        public void Delete(int id)
        {
        }
    }
}
