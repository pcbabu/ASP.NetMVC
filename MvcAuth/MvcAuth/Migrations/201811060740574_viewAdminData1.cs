namespace MvcAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class viewAdminData1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.viewAdminDatas", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.viewAdminDatas", new[] { "ApplicationUser_Id" });
            DropTable("dbo.viewAdminDatas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.viewAdminDatas",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.viewAdminDatas", "ApplicationUser_Id");
            AddForeignKey("dbo.viewAdminDatas", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
