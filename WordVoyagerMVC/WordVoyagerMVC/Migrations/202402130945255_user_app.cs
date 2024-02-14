namespace WordVoyagerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_app : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TagModels",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        TagName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.TagId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TagModels");
        }
    }
}
