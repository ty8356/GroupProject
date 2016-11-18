namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCompletedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "CompletedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "CompletedDate");
        }
    }
}
