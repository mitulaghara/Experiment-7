using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using P7_3052_Models;

namespace P7_3052.Controllers
{
    public class FeedBackController : Controller
    {
 
        static List<P7_3052_Models.FeedBack> feedbackList = new List<FeedBack>();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FeedBack feedback)
        {
            feedbackList.Add(feedback);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}