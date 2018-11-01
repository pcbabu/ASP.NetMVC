using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace surveyIntroPS.Models
{
    public class PersonalInfo
    {
        [Key]
        public int ID { get; set; }

        [Required]
       
        public virtual UserLogIn UserLogIn { get; set; }
       
        
        
        public string Address { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public long PhoneNo { get; set; }


    }
}