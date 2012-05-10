using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication4.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            //TestHub.Notify("");
            return View();
        }

        [HttpPost]
        public PartialViewResult Notify()
        {
            TestHub.Notify("");
         
            return null;
        }
    }
}
