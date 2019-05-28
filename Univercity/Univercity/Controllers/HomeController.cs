using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Univercity.Models;
using Univercity.Models.Repository.Student;

namespace Univercity.Controllers
{
    public class HomeController : Controller
    {
        //bonjakhiiiiiiiiiiiiiiiiiiiiiiiiii
        


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }


        public ActionResult Print()
        {

            TempData["name"] = "Hello Word.......";
            return View("Index");
        }




        public ActionResult FormInsert() /// فرم تکس باکس های ثبت اطلاعات شهر
        {
            return View();
        }



        public ActionResult Insert(tbl_show_city city) // اکشن ثبت شهر
        {
            CityRepository ci = new CityRepository();
            int Result = ci.InsertCity(city);
        
            if (Result == 0)
            {
                // خطا
               
            }
            else
            {
                // درست 1

                
            }

           return View("listcity");
        }


        public void InsertCity(tbl_show_city city)
        {
            CityRepository ci = new CityRepository();
          int Result=  ci.InsertCity(city);

            if (Result == 0)
            {
                // خطا

            }
            else
            {
                // درست 1
            }

        }


    }
}