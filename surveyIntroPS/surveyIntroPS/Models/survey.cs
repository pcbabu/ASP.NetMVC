using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace surveyIntroPS.Models
{
    public class Survey : DbContext
    {
        public DbSet<Ans> Anss { get; set; }
        public DbSet<Que> Ques { get; set; }
        public DbSet<QueInfo> QueInfos { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<UserLogIn> UserLogIns { get; set; }

    }
}