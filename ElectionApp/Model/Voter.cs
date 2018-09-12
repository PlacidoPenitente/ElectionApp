using System;
using System.ComponentModel.DataAnnotations;

namespace ElectionApp.Model
{
    public class Voter : IVoter
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = ElectionAppConstants.FirstNameTooLong)]
        public string FirstName { get; set; }
        [MaxLength(255, ErrorMessage = ElectionAppConstants.MiddleNameTooLong)]
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = ElectionAppConstants.LastNameTooLong)]
        public string LastName { get; set; }
        [Required]
        public DateTime? Birthdate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = ElectionAppConstants.AddressTooLong)]
        public string Address { get; set; }
        [Required]
        public string Photo { get; set; }
    }
}
