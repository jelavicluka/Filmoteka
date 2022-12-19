using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Filmoteka.Models;

namespace Filmoteka.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public membershipTypeDto MembershipType { get; set; }
        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}