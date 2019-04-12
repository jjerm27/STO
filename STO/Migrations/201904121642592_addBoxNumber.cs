namespace STO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBoxNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Boxes", "BoxNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Boxes", "BoxNumber");
        }
    }
}
