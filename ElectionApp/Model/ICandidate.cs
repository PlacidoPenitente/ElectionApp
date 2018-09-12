using System;

namespace ElectionApp.Model
{
    public interface ICandidate
    {
        string Address { get; set; }
        DateTime? Birthdate { get; set; }
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        Party Party { get; set; }
        string Photo { get; set; }
        Position Position { get; set; }
    }
}