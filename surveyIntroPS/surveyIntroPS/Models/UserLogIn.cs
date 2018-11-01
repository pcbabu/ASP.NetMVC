using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace surveyIntroPS.Models
{
    public partial class UserLogIn
    {
        [Key]
        [Index(IsUnique = true)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        
        
        [StringLength(15, MinimumLength = 8)]
        [DataType(DataType.Password)]       
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}