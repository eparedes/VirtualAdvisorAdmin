//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualAdvisorDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CoursePrerequisite
    {
        public int CoursePrerequisiteId { get; set; }
        public int CourseId { get; set; }
        public int RequiredCourseId { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Course Course1 { get; set; }
    }
}
