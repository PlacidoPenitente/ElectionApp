namespace ElectionApp.Model
{
    public class Vote
    {
        public int Id { get; set; }
        public Candidate Candidate { get; set; }
        public Ballot Ballot { get; set; }
    }
}
