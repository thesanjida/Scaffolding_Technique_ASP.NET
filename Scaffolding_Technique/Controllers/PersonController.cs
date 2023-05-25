using Scaffolding_Technique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scaffolding_Technique.Controllers
{
    public class PersonController : Controller
    {
        List<Person>persons=new List<Person>()
        {
            new Person () {Id=1,Name="Sanjida", Email="sanj@gmail.com", Salary=50000},
            new Person () {Id=2,Name="Sanj", Email="sa@gmail.com", Salary=60000},
        };
        // GET: Person
        [HttpGet]
        public ActionResult Index()
        {
            return View(persons);
        }
        [HttpGet]
        public ActionResult Detail()
        {
            return View(persons);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}