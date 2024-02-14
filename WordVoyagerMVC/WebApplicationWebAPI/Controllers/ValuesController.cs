using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        /// <summary>
        /// GET API with no request body
        /// </summary>
        /// <returns>Array of Strings</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// GET API with id in request body
        /// </summary>
        /// <param name="id"></param>
        /// <returns>"value" string</returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
