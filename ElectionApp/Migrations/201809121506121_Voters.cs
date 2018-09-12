namespace ElectionApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Voters : DbMigration
    {
        public override void Up()
        {
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
                        Username = c.String(),
                        Password = c.String(),
                        AccountType = c.Int(nullable: false),
                        Photo = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Party_Id = c.Int(),
                        Position_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parties", t => t.Party_Id)
                .ForeignKey("dbo.Positions", t => t.Position_Id)
                .Index(t => t.Party_Id)
                .Index(t => t.Position_Id);
            
            CreateTable(
                "dbo.Parties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MinimumWinners = c.Int(nullable: false),
                        MaximumWinners = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Voters", "Position_Id", "dbo.Positions");
            DropForeignKey("dbo.Voters", "Party_Id", "dbo.Parties");
            DropIndex("dbo.Voters", new[] { "Position_Id" });
            DropIndex("dbo.Voters", new[] { "Party_Id" });
            DropTable("dbo.Positions");
            DropTable("dbo.Parties");
            DropTable("dbo.Voters");
        }
    }
}
