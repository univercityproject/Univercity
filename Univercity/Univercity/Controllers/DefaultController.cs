using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Univercity.Controllers
{
    public class DefaultController : Controller
    {

        // add text
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}