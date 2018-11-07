namespace MvcAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class viewAdminData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.viewAdminDatas",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.viewAdminDatas", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.viewAdminDatas", new[] { "ApplicationUser_Id" });
            DropTable("dbo.viewAdminDatas");
        }
    }
}
