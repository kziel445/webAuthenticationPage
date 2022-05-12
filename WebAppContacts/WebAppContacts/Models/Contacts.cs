using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppContacts.Models
{
    public class Contacts
    {
        public enum Category
        {
            Private,
            Business,
            Other
        }
        [Key]
        public Guid Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public Category NumberCategory { get; set; }
        public string SubCategory { get; set; }
        public string PhoneMuber { get; set; }
        public DateTimeOffset BirthDate { get; set; }

    }
}
