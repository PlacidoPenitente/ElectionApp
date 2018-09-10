namespace ElectionApp.Model
{
    public class Candidate : Voter
    {
        public Party Party { get; set; }
        public Position Position { get; set; }
    }
}
