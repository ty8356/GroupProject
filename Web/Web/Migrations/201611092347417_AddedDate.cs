namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Date");
        }
    }
}
