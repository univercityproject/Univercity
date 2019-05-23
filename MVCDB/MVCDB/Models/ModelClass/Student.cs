using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDB.Models.ModelClass
{
    public class Student
    {

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا نام را وارد نمایید")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا فامیل را وارد نمایید")]
        [StringLength(60, ErrorMessage = "تعداد کاراکتر ها بین 6 تا 20", MinimumLength = 6)]
        public string Family { get; set; }

        [Display(Name = "سن")]
        [Required(ErrorMessage = "لطفا سن را وارد نمایید")]
        [Range(20, 27, ErrorMessage = "رده سنی باید بین 20 تا 27 سال باشد")]
        public Nullable<int> Age { get; set; }

        [Display(Name = "ایمیل")]
        public string Email { get; set; }



    }
}