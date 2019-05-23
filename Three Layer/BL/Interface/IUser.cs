using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace BL
{
  public  interface IUser
    {
        // تابع ثبت
        int Insert(TblUser user);


        /// <summary>
        /// تابع ویرایش اطلاعات کاربر
        /// </summary>
        /// <param name="user">دریافت یک نمونه از اطلاعات کاربر</param>
        /// <returns>اگر 1 بود عملیات با موفقیت 0 ناموفق</returns>
        int Update(TblUser user);
         int ID { get; set; }

        TblUser FindUser(int ID);
        IEnumerable<TblUser> FindUsers(string name);

    }

    class studen
    {
       void get()
        {
           
        }
    }

}
