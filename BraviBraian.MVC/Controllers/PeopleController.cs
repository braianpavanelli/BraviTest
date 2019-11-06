using AutoMapper;
using BraviBraian.Application.Interface;
using BraviBraian.Domain.Entities;
using BraviBraian.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;

namespace BraviBraian.MVC.Controllers
{
    public class PeopleController : BaseController
    {
        private readonly IPersonAppService personAppService;

        public PeopleController(IPersonAppService _personAppService)
        {
            personAppService = _personAppService;
        }

        // GET: People
        public ActionResult Index()
        {
            IEnumerable<PersonViewModel> people = null;

            //people = Mapper.Map<IEnumerable<Person>, IEnumerable<PersonViewModel>>(personAppService.GetAll());

            using (var client = new HttpClient())
            {
                var uri = new Uri(UriApi + "/People");
                //HTTP GET
                var responseTask = client.GetAsync(uri);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<PersonViewModel>>();
                    readTask.Wait();

                    people = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    people = Enumerable.Empty<PersonViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Por favor contate o administrador.");
                }
            }
            return View(people);
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            PersonViewModel person = new PersonViewModel();

            using (var client = new HttpClient())
            {
                var uri = new Uri(UriApi + "/People/" + id);
                //HTTP GET
                var responseTask = client.GetAsync(uri);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<PersonViewModel>();
                    readTask.Wait();

                    person = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    ModelState.AddModelError(string.Empty, "Server error. Por favor contate o administrador.");
                }
            }
            return View(person);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View(new PersonViewModel());
        }


        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View();
        }

    }
}
