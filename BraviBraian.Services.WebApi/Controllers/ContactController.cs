using BraviBraian.Application.Interface;
using BraviBraian.Domain.Entities;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BraviBraian.Services.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ContactController : BaseApiController
    {
        private readonly IContactAppService contactAppService;

        public ContactController(IContactAppService _contactAppService)
        {
            contactAppService = _contactAppService;
        }

        // GET: api/Contact
        public IEnumerable<Contact> Get()
        {
            return contactAppService.GetAll();
        }

        // GET: api/Contact/5
        public Contact Get(int id)
        {
            return contactAppService.GetById(id);
        }

        // GET: api/Contact/GetListByDescription
        [HttpGet]
        public IEnumerable<Contact> GetListByDescription(string description)
        {
            var ret = contactAppService.GetListByDescription(description);
            return ret;
        }

        // GET: api/Contact/GetListByPerson
        [HttpGet]
        public IEnumerable<Contact> GetListByPerson(int idPerson)
        {
            var ret = contactAppService.GetListByPerson(idPerson);
            return ret;
        }

        // GET: api/Contact/GetListByType
        [HttpGet]
        public IEnumerable<Contact> GetListByType(int idContactType)
        {
            var ret = contactAppService.GetListByType(idContactType);
            return ret;
        }

        // POST: api/Contact
        public void Post([FromBody]Contact obj)
        {
            contactAppService.Add(obj);
            
        }

        // PUT: api/Contact/5
        [HttpPut]
        public void PutByApi(int idContact, [FromBody]Contact obj)
        {
            contactAppService.UpdateByApi(obj);
        }

        // PUT: api/Contact/5
        public void Put([FromBody]Contact obj)
        {
            contactAppService.UpdateByApi(obj);
        }

        // PUT: api/Contact/5
        //public void Put([FromBody]Contact[] objArray)
        //{
        //    contactAppService.UpdateCollection(objArray);
        //}

        // DELETE: api/Contact/5
        public void Delete([FromBody]Contact obj)
        {
            contactAppService.Delete(obj.Id);
        }
    }
}
