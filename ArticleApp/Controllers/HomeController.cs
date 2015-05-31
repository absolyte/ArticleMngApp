using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArticleApp.Models;

namespace ArticleApp.Controllers
{
    public class HomeController : Controller
    {
        UserContext userDbContext = new UserContext();
        public ActionResult Index()
        {
            return View(ArticleDataStorage.Instance.GetAllArticles());
        }

        public ActionResult Users()
        {
            ViewBag.Message = "Page to manage users";
            return View(userDbContext.Users);
        }

        /*public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        */
        protected override void Dispose(bool disposing)
        {
            userDbContext.Dispose();
            base.Dispose(disposing);
        }

    }
}
