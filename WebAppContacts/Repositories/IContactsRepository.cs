using System;
using System.Collections.Generic;
using WebAppContacts.Models;

namespace WebAppContacts.Repositories
{
    public interface IContactsRepository
    {
        Contact GetContact(Guid id);  
        IEnumerable<Contact> GetContacts();
        void CreateContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(Guid id);
    }
}