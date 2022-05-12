using System;
using WebAppContacts.Models;

namespace WebAppContacts.Repositories
{
    public interface IContactsRepository
    {
        Contact GetContact(Guid id);  
        void CreateContact(Contact contact);

    }
}