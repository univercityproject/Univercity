using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Univercity.Models;
using Univercity.Models.Repository.Student;
using Univercity.Models.Rpository.Teacher;

namespace Univercity.Controllers
{
    public class TeacherController : Controller
    {
        //this is a test text......................................
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult formInsert()//فرم تکس باکس های ثبت اطلاعات شخصی اساتید
        {
            return View();
        }

        public ActionResult insert(tbl_teacher_presonal_information teacher)//اکشن  ثبت اطلاعات شخصی اساتید
        {
            Teacher_p_i_Ripository tpi = new Teacher_p_i_Ripository();
            int Result = tpi.Insertteacher(teacher);

            if (Result == 0)
            {
                //خطا
                return View("Error");
            }
            else
            {
                //درست
                return View("liteacher");

            }
            
        }






        public void insertteacher_i_p(tbl_teacher_presonal_information teacher)
        {
            Teacher_p_i_Ripository tpi = new Teacher_p_i_Ripository();
            int Result = tpi.Insertteacher(teacher);

            if (Result == 0)
            {
                //خطا
                
            }
            else
            {
                //درست
                
            }

        }
    }
}