using System;

namespace ElectionApp.Model
{
    public class Voter : IVoter
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
    }
}
