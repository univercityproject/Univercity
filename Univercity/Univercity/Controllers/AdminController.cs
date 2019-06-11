using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Univercity.Models;

namespace Univercity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ForminsertAdmin()
        {
            return View();
        }


        public ActionResult insertAdmin(tbl_teacher_presonal_information teacher)
        {
            return View();
        }
        public void insertteacher_i_p(tbl_teacher_presonal_information teacher)
        {
            AdminRepository ar = new AdminRepository();
          int result=ar.Insertteacher(teacher);


            if(result==0)
            {
                // خظا
            }
            else
            {
                //درست
            }
        }
    }
}