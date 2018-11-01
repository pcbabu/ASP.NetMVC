using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace surveyIntroPS.Models
{
    public class QueInfo
    {
        [Key]
        public int ID { get; set; }
        
        public virtual UserLogIn UserLogIn { get; set; }
        public string QueName { get; set; }

    }
}