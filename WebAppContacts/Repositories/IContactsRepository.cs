using System;
using WebAppContacts.Models;

namespace WebAppContacts.Repositories
{
    public interface IItemsRepository
    {
        Contacts GetContact(Guid id);  
    }
}