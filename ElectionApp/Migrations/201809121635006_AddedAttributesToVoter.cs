namespace ElectionApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAttributesToVoter : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Voters", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Voters", "MiddleName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Voters", "LastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Voters", "Address", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Voters", "Photo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Voters", "Photo", c => c.String());
            AlterColumn("dbo.Voters", "Address", c => c.String());
            AlterColumn("dbo.Voters", "LastName", c => c.String());
            AlterColumn("dbo.Voters", "MiddleName", c => c.String());
            AlterColumn("dbo.Voters", "FirstName", c => c.String());
        }
    }
}
