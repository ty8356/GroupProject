namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditTask : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "Name", c => c.String());
        }
    }
}
