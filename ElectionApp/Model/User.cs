using System.ComponentModel.DataAnnotations;

namespace ElectionApp.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(32, ErrorMessage = ElectionAppConstants.UsernameTooLong)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(32, ErrorMessage = ElectionAppConstants.PasswordTooLong)]
        public string Password { get; set; }
        public AccountType AccountType { get; set; }
    }
}
