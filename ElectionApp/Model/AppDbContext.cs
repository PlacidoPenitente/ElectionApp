using System.Data.Entity;

namespace ElectionApp.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("election")
        {

        }

        public DbSet<Vote> Votes { get; set; }
        public DbSet<Voter> Voters { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Party> Parties { get; set; }
    }
}
