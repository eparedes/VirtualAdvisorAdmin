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
    
    public partial class EnrollmentStatusCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EnrollmentStatusCode()
        {
            this.EnrollmentStatus = new HashSet<EnrollmentStatu>();
        }
    
        public string EnrollmentStatusCodeId { get; set; }
        public string EnrollmentStatusDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnrollmentStatu> EnrollmentStatus { get; set; }
    }
}
