using System;
using WebAppContacts.Models;

namespace WebAppContacts.Repositories
{
    public class MongoDbRepository : IContactsRepository
    {
        public Contacts GetContact(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}