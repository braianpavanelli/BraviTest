using BraviBraian.Application.Interface;
using BraviBraian.Domain.Entities;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BraviBraian.Services.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:63400", headers: "*", methods: "*")]
    public class ContactTypeController : BaseApiController
    {
        private readonly IContactTypeAppService contactTypeAppService;

        public ContactTypeController(IContactTypeAppService _contactTypeAppService)
        {
            contactTypeAppService = _contactTypeAppService;
        }

        // GET: api/ContactType
        public IEnumerable<ContactType> Get()
        {
            return contactTypeAppService.GetAll();
        }

        // GET: api/ContactType/5
        public ContactType Get(int id)
        {
            return contactTypeAppService.GetById(id);
        }

        // GET: api/ContactType/GetListByName
        [HttpGet]
        public IEnumerable<ContactType> GetListByName(string name)
        {
            var ret = contactTypeAppService.GetListByName(name);
            return ret;
        }

        // POST: api/ContactType
        public void Post([FromBody]ContactType obj)
        {
            contactTypeAppService.Update(obj);
        }

        // PUT: api/ContactType/5
        public void Put(int id, [FromBody]ContactType obj)
        {
            contactTypeAppService.Add(obj);
        }

        // DELETE: api/ContactType/5
        public void Delete(int id)
        {
            contactTypeAppService.Delete(id);
        }
    }
}
