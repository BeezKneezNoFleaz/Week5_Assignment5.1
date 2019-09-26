using DataAnnotationsExtensions;
using Lucene.Net.Support;
using SendGrid.Helpers.Mail;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using UrlAttribute = System.ComponentModel.DataAnnotations.UrlAttribute;

namespace CIS174_TestCoreApp.Models
{
    public class CreatePersonViewModel
    {

        [Required]
        [DisplayName("First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        [StringLength(25)]
        public string MiddleName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [StringLength(25)]
        public string LastName { get; set; }

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Confirm Email")]
        [EqualTo("Email")]
        public string ConfirmEmail { get; set; }

        [Required]
        [MinLength(7)]
        [Url]
        public string Website { get; set; }

        //couldn't quite get this one to work correctly. any tips in grading comments would be greatly appericated.
        [ReadOnly(true)]
        [DisplayName("DMACC")]
        public string School { get; set; }

        
    }
}
