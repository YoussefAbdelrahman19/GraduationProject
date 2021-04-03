using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GradProjectV5.Models
{
    [MetadataType(typeof(MemberData))]
    public partial class Member
    {

    }
    public class MemberData
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Address { get; set; }
        public Nullable<int> GenderId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}