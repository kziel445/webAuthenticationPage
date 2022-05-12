using System;
using MongoDB.Driver;
using WebAppContacts.Models;

namespace WebAppContacts.Repositories
{
    public class MongoDbContactsRepository : IContactsRepository
    {
        private readonly IMongoCollection<Contact> contactsCollection;

        // initialization database with MongoDB
        public MongoDbContactsRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase("WebAppContacts");
            contactsCollection = database.GetCollection<Contact>("Contacts");
        }

        public void CreateContact(Contact contact)
        {
            contactsCollection.InsertOne(contact);
        }

        public Contact GetContact(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}