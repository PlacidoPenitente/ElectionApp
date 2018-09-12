namespace ElectionApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Candidates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ballot_Id = c.Int(),
                        Candidate_Id = c.Int(),
                        Position_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ballots", t => t.Ballot_Id)
                .ForeignKey("dbo.Voters", t => t.Candidate_Id)
                .ForeignKey("dbo.Positions", t => t.Position_Id)
                .Index(t => t.Ballot_Id)
                .Index(t => t.Candidate_Id)
                .Index(t => t.Position_Id);
            
            CreateTable(
                "dbo.Ballots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Voter_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Voters", t => t.Voter_Id)
                .Index(t => t.Voter_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Votes", "Position_Id", "dbo.Positions");
            DropForeignKey("dbo.Votes", "Candidate_Id", "dbo.Voters");
            DropForeignKey("dbo.Votes", "Ballot_Id", "dbo.Ballots");
            DropForeignKey("dbo.Ballots", "Voter_Id", "dbo.Voters");
            DropIndex("dbo.Ballots", new[] { "Voter_Id" });
            DropIndex("dbo.Votes", new[] { "Position_Id" });
            DropIndex("dbo.Votes", new[] { "Candidate_Id" });
            DropIndex("dbo.Votes", new[] { "Ballot_Id" });
            DropTable("dbo.Ballots");
            DropTable("dbo.Votes");
        }
    }
}
