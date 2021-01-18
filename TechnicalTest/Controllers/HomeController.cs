using TechnicalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.Logic.MemberProcessor;

namespace TechnicalTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult BecomeAMember()
        {
            ViewBag.Message = "Become a Member";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BecomeAMember(Member model)
        {
            if (ModelState.IsValid)
            {
                string uuid = Guid.NewGuid().ToString();

                // CreateEmployee() method comes from the MemberProcessor.cs
                int recordsCreated = CreateEmployee(
                    uuid,
                    model.FirstName,
                    model.LastName,
                    model.EmailAddress);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}