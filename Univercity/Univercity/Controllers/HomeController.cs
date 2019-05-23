using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Univercity.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        ///  this is a text
        /// </summary>
        /// <returns></returns>

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}