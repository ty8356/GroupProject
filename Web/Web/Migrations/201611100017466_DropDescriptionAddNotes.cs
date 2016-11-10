namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropDescriptionAddNotes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Notes", c => c.String());
            DropColumn("dbo.Tasks", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Description", c => c.String());
            DropColumn("dbo.Tasks", "Notes");
        }
    }
}
