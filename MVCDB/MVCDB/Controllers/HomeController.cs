using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCDB.Models;
namespace MVCDB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        uniEntities db = new Models.uniEntities();
        public ActionResult Index()
        {
        
            return View();
        }



        public ActionResult ShowStudent()
        {
            List<TblStudent> li = db.TblStudents.ToList();
            return View(li);
        }




        public ActionResult Insert(TblStudent st)
        {
            if(ModelState.IsValid)
            {
                /// صحیح
                /// 
                db.TblStudents.Add(st);
                int Result = db.SaveChanges();
                if (Result == 0)
                    return HttpNotFound();
            }
            {
                /// حالت غلط
                /// 

            }
            
           

            return View(st);
        }

        public ActionResult Delete(int id)
        {
            TblStudent st = db.TblStudents.Where(c => c.ID == id).SingleOrDefault();
            db.TblStudents.Remove(st);
            int Result = db.SaveChanges();
            if (Result == 0)
                ViewBag.Message = "failed"; 
            else
                ViewBag.Message = "ok";
            
            return RedirectToAction("ShowStudent");
        }


  public ActionResult Edit(int id)
        {
            int _id = id;
            TblStudent st = db.TblStudents.Where(c => c.ID == id).SingleOrDefault();
            return View(st);
        }

    }
}