using System.Collections.Generic;
using System.Web.Http;

namespace _3DProject.Web.API
{
    public class StuffController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(string key)
        {
            return $"{key}";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(string key, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(string key)
        {
        }
    }
}