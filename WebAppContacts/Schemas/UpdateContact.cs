using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppContacts.Schemas
{
    public record UpdateContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string NumberCategory { get; set; }
        public string SubCategory { get; set; }
        public string PhoneNumber { get; set; }
        public DateTimeOffset BirthDate { get; set; }
    }
}