using Business.Concrete;
using Business.ValidationRules;
using DataAcces.EntityFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv=new ContactValidator();
        public ActionResult Index()
        {
            var ContactValues = cm.GetList();
            return View(ContactValues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var ContactValues=cm.GetById(id);
            return View(ContactValues);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}