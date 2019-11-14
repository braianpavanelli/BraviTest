using BraviBraian.Application.Interface;
using BraviBraian.Domain.Entities;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BraviBraian.Services.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PeopleController : BaseApiController
    {
        private readonly IPersonAppService personAppService;

        public PeopleController(IPersonAppService _personAppService)
        {
            personAppService = _personAppService;
        }
        // GET: api/PeopleApi
        public IEnumerable<Person> Get()
        {
            var ret = personAppService.GetAll();
            return ret;
        }

        // GET: api/PeopleApi/5
        public Person Get(int id)
        {
            return personAppService.GetById(id);
        }

        // GET: api/PeopleApi/GetListByName
        [HttpGet]
        public IEnumerable<Person> GetListByName(string name)
        {
            var ret = personAppService.GetListByName(name);
            return ret;
        }

        // POST: api/PeopleApi
        [HttpPost]
        public void Post([FromBody]Person obj)
        {
            personAppService.Add(obj);
        }

        // PUT: api/PeopleApi/5
        [HttpPut]
        public void Put([FromBody]Person obj)
        {
            personAppService.UpdateByApi(obj);
        }

        // DELETE: api/PeopleApi/5
        [HttpDelete]
        public void Delete([FromBody]Person obj)
        {
            personAppService.Delete(obj.Id);
        }

    }
}
