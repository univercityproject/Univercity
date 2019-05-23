using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BL
{
   public static class UserRepositroy : IUser
    {
         static OfficeEntities db = new OfficeEntities();
        public static int ID
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public static TblUser FindUser(int id)
        {

            TblUser _user = db.TblUsers.Where(c => c.ID == id).SingleOrDefault();
            return _user;
        }

        public static IEnumerable<TblUser> FindUsers(string name)
        {
            throw new NotImplementedException();
        }

        // کد ثبت کاربر
        public static int Insert(TblUser user)
        {

            db.TblUsers.Add(user);
            return db.SaveChanges();
        }


        /// <summary>
        /// تابع ویرایش اطلاعات کاربر
        /// </summary>
        /// <param name="user">دریافت یک نمونه از اطلاعات کاربر</param>
        /// <returns>اگر 1 بود عملیات با موفقیت 0 ناموفق</returns>
        public static int Update(TblUser user)
        {

            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
