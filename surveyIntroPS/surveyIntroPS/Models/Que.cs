using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace surveyIntroPS.Models
{
    public class Que
    {
        [Key]
        public int ID { get; set; }
       
        public QueInfo QueInfoID { get; set; }

        public string Ques { get; set; }
        public string Op1 { get; set; }
        public string Op2 { get; set; }
        public string Op3 { get; set; }
        public string Op4 { get; set; }
        public int Ans { get; set; }
    }
}