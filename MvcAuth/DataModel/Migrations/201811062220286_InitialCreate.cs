namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroupModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        userID = c.String(),
                        GroupName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GroupModels");
        }
    }
}
