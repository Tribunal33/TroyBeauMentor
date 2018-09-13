using _3DProject.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace _3DProject.Web.API
{
    public class PersonController : ApiController
    {
        private readonly IStuffRepository<IPerson> _personRepo;

        public PersonController(IStuffRepository<IPerson> personRepo)
        {
            _personRepo = personRepo;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(string key)
        {
            return _personRepo.Get(key)?.Value.ToString();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int key, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int key)
        {
        }
    }
}