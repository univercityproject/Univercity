//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Univercity.Models.Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_student_specification_edu
    {
        public string code_student { get; set; }
        public string year_entering { get; set; }
        public Nullable<int> major_student { get; set; }
        public Nullable<int> group_lesson { get; set; }
        public Nullable<int> status_student { get; set; }
        public Nullable<bool> status_select_project { get; set; }
        public Nullable<bool> status_extended_project { get; set; }
    }
}