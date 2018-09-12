using System;

namespace ElectionApp.Model
{
    public interface IVoter
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        DateTime Birthdate { get; set; }
        string Address { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        AccountType AccountType { get; set; }
        string Photo { get; set; }
    }
}