using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        //Entity Framework will recognise this convention and treat this ID as the foreign key
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } //since it's byte - implicitly required; It's not if it's nullable byte

        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
    }
}