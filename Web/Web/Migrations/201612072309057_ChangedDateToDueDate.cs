namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDateToDueDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "DueDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Tasks", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Tasks", "DueDate");
        }
    }
}
