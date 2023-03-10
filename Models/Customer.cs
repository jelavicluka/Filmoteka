using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Filmoteka.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership type")]
        public byte MembershipTypeId { get; set; }
        [Display(Name = "Date of birth")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}