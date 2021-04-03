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
    
    public partial class Status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Status()
        {
            this.BeneficierMedicineRequests = new HashSet<BeneficierMedicineRequest>();
            this.BMedicineRequestStatus = new HashSet<BMedicineRequestStatu>();
            this.ComplaintStatus = new HashSet<ComplaintStatu>();
            this.PharmacyMedicineRequests = new HashSet<PharmacyMedicineRequest>();
            this.PhMedicineRequestStatus = new HashSet<PhMedicineRequestStatu>();
        }
    
        public int ID { get; set; }
        public string StatusName { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BeneficierMedicineRequest> BeneficierMedicineRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BMedicineRequestStatu> BMedicineRequestStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComplaintStatu> ComplaintStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PharmacyMedicineRequest> PharmacyMedicineRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhMedicineRequestStatu> PhMedicineRequestStatus { get; set; }
    }
}
