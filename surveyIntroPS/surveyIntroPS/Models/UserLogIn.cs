using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace surveyIntroPS.Models
{
    public class UserLogIn
    {
        [Key]
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        //protected virtual string PasswordStored
        //{
        //    get;
        //    set;
        //}


        //[NotMapped]
        //public string Password
        //{
        //    get { return Decrypt(PasswordStored); }
        //    set { PasswordStored = Encrypt(value); }
        //}
    }
}