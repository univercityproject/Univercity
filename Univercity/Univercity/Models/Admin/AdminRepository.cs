using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Univercity.Models;

namespace Univercity
{
    public class AdminRepository : IAdmin
    {
        univercityEntities2 db = new univercityEntities2();
        private tbl_teacher_presonal_information _teacher_p_i;

        public string code_national_teacher
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

        public int Deleteteacher(tbl_teacher_presonal_information _teacher_p_i)
        {
            db.tbl_teacher_presonal_information.Remove(_teacher_p_i);
            return db.SaveChanges();
        }

        public tbl_teacher_presonal_information FindTeacher(string code_national_teacher)
        {
            tbl_teacher_presonal_information teacher = db.tbl_teacher_presonal_information.Where(c => c.code_national_teacher == code_national_teacher).SingleOrDefault();
            return teacher;

        }

        public List<tbl_teacher_presonal_information> FindTeachers(string code_national_teacher)
        {
            List<tbl_teacher_presonal_information> teachers = db.tbl_teacher_presonal_information.Where(c => c.code_national_teacher == code_national_teacher).ToList();
            return teachers;
        }

        public int insertlistteacher(IEnumerable<tbl_teacher_presonal_information> liteacher)
        {
            db.tbl_teacher_presonal_information.AddRange(liteacher);
            return db.SaveChanges();
        }

        public int Insertteacher(tbl_teacher_presonal_information _teacher_p_i)
        {
            db.tbl_teacher_presonal_information.Add(_teacher_p_i);
            return db.SaveChanges();
            
        }

        public int removelistteacher(IEnumerable<tbl_teacher_presonal_information> liteacher)
        {
            db.tbl_teacher_presonal_information.RemoveRange(liteacher);
            return db.SaveChanges();
        }

        public int Updateteacher(tbl_teacher_presonal_information _teacher_p_i)
        {
            db.Entry(_teacher_p_i).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}