namespace ElectionApp.Model
{
    public class Candidate : Voter, ICandidate
    {
        public Party Party { get; set; }
        public Position Position { get; set; }
    }
}
