using GradProjectV5.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GradProjectV5.Models
{
    [MetadataType(typeof(DoctorData))]
    public partial class Member
    {
        

    }
    public class DoctorData
    {
        [Required(ErrorMessage="يتطلب ادخال هذا الحقل")]
        [Display(Name = "التخصص الطبي ")]
        public string Speciality { get; set; }
        [Display(Name="عدد سنوات الخبرة")]
        [Required(ErrorMessage = "يتطلب ادخال هذا الحقل")]
        public Nullable<int> YearsOfExperience { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> MemberId { get; set; }
    }
}