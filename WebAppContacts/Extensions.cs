using WebAppContacts.Models;

namespace WebAppContacts
{
    public static class Extensions
    {
        public static Contact ReturnContact(this Contact contact)
        {
            return new Contact 
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Email = contact.Email,
                Password = contact.Password,
                NumberCategory = contact.NumberCategory,
                SubCategory = contact.SubCategory,
                PhoneNumber = contact.PhoneNumber,
                BirthDate = contact.BirthDate
            };
        }
    }
}