namespace ElectionApp.Model
{
    public interface IVote
    {
        Ballot Ballot { get; set; }
        Candidate Candidate { get; set; }
        int Id { get; set; }
        Position Position { get; set; }
    }
}