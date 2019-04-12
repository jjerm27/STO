namespace STO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeUserPhotoStatus : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Photo", c => c.String());
            DropColumn("dbo.AspNetUsers", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Status", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Photo", c => c.String(nullable: false));
        }
    }
}
