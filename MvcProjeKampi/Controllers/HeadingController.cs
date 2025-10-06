using Business.Concrete;
using DataAcces.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm= new CategoryManager(new  EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headingValues = hm.GetList();
            return View(headingValues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();

            List<SelectListItem> valueWriter =(from x in wm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text=x.WriterName + " " + x.WriterSurName,
                                                   Value=x.WriterID.ToString()
                                               }).ToList();
            ViewBag.vlc=valueCategory;
            ViewBag.vlw =valueWriter;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(heading);
            return RedirectToAction("Index");
        }
        public ActionResult ContentByHeading()
        {
            return View();
        }
    }
}