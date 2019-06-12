using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Univercity.Models;
using Univercity.Models.Admin;

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


        //public ActionResult insertAdmin(tbl_teacher_presonal_information teacher)
        //{
        //    AdminRepository ar = new AdminRepository();
        //    int result = ar.insertteacher(teacher);


        //    if (result == 0)
        //    {
        //        // خظا
        //    }
        //    else
        //    {
        //        //درست
        //    }
        //    return View();
        //}
        public void insertteacher_p_i(tbl_teacher_presonal_information teacher)
        {
            AdminRepository ar = new AdminRepository();
          int result=ar.insertteacher(teacher);


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