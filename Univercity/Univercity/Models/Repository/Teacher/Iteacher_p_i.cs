using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univercity.Models;

namespace Univercity
{
   public interface Iteacher_p_i
    {

        string code_national_teacher { get; set; }

        tbl_teacher_presonal_information FindTeacher(string code_national_teacher);
        List<tbl_teacher_presonal_information> FindTeachers(string code_national_teacher);
        int Insertteacher(tbl_teacher_presonal_information _teacher_p_i);
        int Updateteacher(tbl_teacher_presonal_information _teacher_p_i);
        int Deleteteacher(tbl_teacher_presonal_information _teacher_p_i);

        int insertlistteacher(IEnumerable<tbl_teacher_presonal_information> liteacher);
        int removelistteacher(IEnumerable<tbl_teacher_presonal_information> liteacher);
    }
}
