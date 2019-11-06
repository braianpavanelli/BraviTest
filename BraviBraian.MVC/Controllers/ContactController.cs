using AutoMapper;
using BraviBraian.Application.Interface;
using BraviBraian.Domain.Entities;
using BraviBraian.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace BraviBraian.MVC.Controllers
{
    public class ContactController : BaseController
    {
        private readonly IContactTypeAppService contactTypeAppService;
        private readonly IPersonAppService personAppService;

        public ContactController(IContactTypeAppService _contactTypeAppService, IPersonAppService _personAppService)
        {
            contactTypeAppService = _contactTypeAppService;
            personAppService = _personAppService;
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            //The id parameter here is used as idPerson because we don't want to edit a contact without a person
            List<ContactViewModel> contacts = new List<ContactViewModel>();
            using (var client = new HttpClient())
            {
                var uri = new Uri(UriApi + "/Contact/GetListByPerson?idPerson=" + id);
                //HTTP GET
                var responseTask = client.GetAsync(uri);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<ContactViewModel>>();
                    readTask.Wait();

                    contacts = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    ModelState.AddModelError(string.Empty, "Server error. Por favor contate o administrador.");
                }
            }
            ViewBag.Id = id;
            return View(contacts);
        }

        public ActionResult Edit(int id)
        {
            //The id parameter here is used as idPerson because we don't want to edit a contact without a person
            List<ContactViewModel> contacts = new List<ContactViewModel>();
            using (var client = new HttpClient())
            {
                var uri = new Uri(UriApi + "/Contact/GetListByPerson?idPerson=" + id);
                //HTTP GET
                var responseTask = client.GetAsync(uri);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<ContactViewModel>>();
                    readTask.Wait();

                    contacts = readTask.Result;
                    if (contacts.Count == 0)
                    {
                       return RedirectToAction("Index", "People");
                    }
                    else if (contacts.FirstOrDefault().Person == null)
                    {
                        contacts.FirstOrDefault().Person = Mapper.Map<Person, PersonViewModel>(personAppService.GetById(id));
                    }
                }
                else //web api sent error response 
                {
                    //log response status here..

                    ModelState.AddModelError(string.Empty, "Server error. Por favor contate o administrador.");
                }
            }
            ViewBag.ContactTypes = Mapper.Map<IEnumerable<ContactType>, IEnumerable<ContactTypeViewModel>>(contactTypeAppService.GetAll());
            return View(contacts);
        }

        [HttpPost]
        public ActionResult Edit(int id, List<ContactViewModel> contacts)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(UriApi + "/Contact/");
                var response = client.PutAsJsonAsync(uri, contacts);
                response.Wait();
                if (response.IsCompleted)
                {
                    return RedirectToAction("Details", new { id });
                }
                ViewBag.ContactTypes = Mapper.Map<IEnumerable<ContactType>, IEnumerable<ContactTypeViewModel>>(contactTypeAppService.GetAll());
                return View(contacts);
            }
        }
    }
}