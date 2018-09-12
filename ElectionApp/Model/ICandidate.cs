namespace ElectionApp.Model
{
    public interface ICandidate
    {
        Party Party { get; set; }
        Position Position { get; set; }
    }
}