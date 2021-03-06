﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VirtualAdvisor2Entities : DbContext
    {
        public VirtualAdvisor2Entities()
            : base("name=VirtualAdvisor2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdvisorStudent> AdvisorStudents { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CoursePrerequisite> CoursePrerequisites { get; set; }
        public virtual DbSet<DegreePlan> DegreePlans { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<EnrollmentStatu> EnrollmentStatus { get; set; }
        public virtual DbSet<EnrollmentStatusCode> EnrollmentStatusCodes { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<GradingScale> GradingScales { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<SectionRating> SectionRatings { get; set; }
        public virtual DbSet<SectionRatingScale> SectionRatingScales { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<StaffStatu> StaffStatus { get; set; }
        public virtual DbSet<StaffStatusCode> StaffStatusCodes { get; set; }
        public virtual DbSet<StaffType> StaffTypes { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentDegreePlan> StudentDegreePlans { get; set; }
        public virtual DbSet<StudentStatu> StudentStatus { get; set; }
        public virtual DbSet<StudentStatusCode> StudentStatusCodes { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<EnrollmentGrade> EnrollmentGrades { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<CoursePreRequisite1> CoursePreRequisites1 { get; set; }
        public virtual DbSet<ProfessorCours> ProfessorCourses { get; set; }
        public virtual DbSet<StudentCourseHistory> StudentCourseHistories { get; set; }
        public virtual DbSet<StudentsGPAByTerm> StudentsGPAByTerms { get; set; }
        public virtual DbSet<StudentsGPACumulative> StudentsGPACumulatives { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    }
}
