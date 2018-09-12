namespace ElectionApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidates", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.Voters", "Gender", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Voters", "Gender");
            DropColumn("dbo.Candidates", "Gender");
        }
    }
}
