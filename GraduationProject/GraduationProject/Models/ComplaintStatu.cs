//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraduationProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ComplaintStatu
    {
        public int ID { get; set; }
        public Nullable<int> CompliantId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Complaint Complaint { get; set; }
        public virtual Status Status { get; set; }
    }
}
