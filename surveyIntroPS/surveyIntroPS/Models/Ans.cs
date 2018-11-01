using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace surveyIntroPS.Models
{
    public class Ans
    {
        [Key]
        public int ID { get; set; }
       
        public Que QueoID { get; set; }
        public int ans { get; set; }

    }
}