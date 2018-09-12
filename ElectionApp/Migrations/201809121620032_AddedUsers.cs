namespace ElectionApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUsers : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Voters", newName: "Candidates");
            CreateTable(
                "dbo.Voters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Address = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Candidates", "Username");
            DropColumn("dbo.Candidates", "Password");
            DropColumn("dbo.Candidates", "AccountType");
            DropColumn("dbo.Candidates", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Candidates", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Candidates", "AccountType", c => c.Int(nullable: false));
            AddColumn("dbo.Candidates", "Password", c => c.String());
            AddColumn("dbo.Candidates", "Username", c => c.String());
            DropTable("dbo.Voters");
            RenameTable(name: "dbo.Candidates", newName: "Voters");
        }
    }
}
