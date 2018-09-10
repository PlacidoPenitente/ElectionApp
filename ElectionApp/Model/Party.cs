using System.Collections.Generic;

namespace ElectionApp.Model
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
