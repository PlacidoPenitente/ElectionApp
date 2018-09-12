using System.Collections.Generic;

namespace ElectionApp.Model
{
    public interface IParty
    {
        List<Candidate> Candidates { get; set; }
        int Id { get; set; }
        string Name { get; set; }
    }
}