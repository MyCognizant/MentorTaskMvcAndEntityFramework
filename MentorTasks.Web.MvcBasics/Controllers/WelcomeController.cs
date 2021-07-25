using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MentorTasks.Web.MvcBasics.Models;

namespace MentorTasks.Web.MvcBasics.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index(string name)
        {
            ViewData["Message"] = "Welcome to Mvc Dot Net";
            Customer customer = new Customer();
            customer.Name = name;
            return View(customer);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (customer == null)
            {
                return HttpNotFound();
            }
            
            return RedirectToAction("Index", new{name = customer.Name});
        }




    }
}