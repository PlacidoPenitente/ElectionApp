using System.Collections.Generic;

namespace ElectionApp.Model
{
    public class Ballot
    {
        public int Id { get; set; }
        public List<Vote> Votes { get; set; }
        public Voter Voter { get; set; }
    }
}
