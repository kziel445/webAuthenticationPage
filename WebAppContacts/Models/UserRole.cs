using System.ComponentModel.DataAnnotations;

namespace WebAppContacts.Models
{
    public class Role
    {
        [Required]
        public string RoleName { get; set; }
    }
}