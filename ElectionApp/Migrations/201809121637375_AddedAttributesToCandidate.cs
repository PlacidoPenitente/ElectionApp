namespace ElectionApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAttributesToCandidate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Candidates", "Position_Id", "dbo.Positions");
            DropIndex("dbo.Candidates", new[] { "Position_Id" });
            AlterColumn("dbo.Candidates", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Candidates", "MiddleName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Candidates", "LastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Candidates", "Address", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Candidates", "Position_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Candidates", "Position_Id");
            AddForeignKey("dbo.Candidates", "Position_Id", "dbo.Positions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Candidates", "Position_Id", "dbo.Positions");
            DropIndex("dbo.Candidates", new[] { "Position_Id" });
            AlterColumn("dbo.Candidates", "Position_Id", c => c.Int());
            AlterColumn("dbo.Candidates", "Address", c => c.String());
            AlterColumn("dbo.Candidates", "LastName", c => c.String());
            AlterColumn("dbo.Candidates", "MiddleName", c => c.String());
            AlterColumn("dbo.Candidates", "FirstName", c => c.String());
            CreateIndex("dbo.Candidates", "Position_Id");
            AddForeignKey("dbo.Candidates", "Position_Id", "dbo.Positions", "Id");
        }
    }
}
