namespace ElectionApp.Model
{
    public interface IPosition
    {
        int Id { get; set; }
        int MaximumWinners { get; set; }
        int MinimumWinners { get; set; }
        string Name { get; set; }
    }
}