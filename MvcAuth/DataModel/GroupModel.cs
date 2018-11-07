using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DataModel
{
    public class GroupModel
    {
        [Key]
        public string Id { get; set; }

        public string userID { get; set; }

        public string GroupName { get; set; }

    }

    public class GroupDB : DbContext
    {
      
        public DbSet<GroupModel> GroupModel { get; set; }
    }
}
