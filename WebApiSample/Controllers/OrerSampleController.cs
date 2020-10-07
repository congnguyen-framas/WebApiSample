﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiSample.Controllers
{
    public class OrerSampleController : ApiController
    {
        // GET: api/OrerSample
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OrerSample/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OrerSample
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/OrerSample/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OrerSample/5
        public void Delete(int id)
        {
        }
    }
}
