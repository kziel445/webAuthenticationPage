using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using WebAppContacts.Models;

namespace WebAppContacts.Repositories
{
    public class MongoDbContactsRepository : IContactsRepository
    {
        private readonly IMongoCollection<Contact> contactsCollection;
        private readonly FilterDefinitionBuilder<Contact> filterBuilder = Builders<Contact>.Filter;
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

        public void DeleteContact(Guid id)
        {
            var filter = Builders<Contact>.Filter.Eq(contact => contact.Id, id);            
            contactsCollection.FindOneAndDelete(filter);
        }

        public Contact GetContact(Guid id)
        {
            var filter = Builders<Contact>.Filter.Eq(contact => contact.Id, id);

            return contactsCollection.Find(filter).SingleOrDefault();
        }

        public IEnumerable<Contact> GetContacts()
        {
            return contactsCollection.Find(new BsonDocument()).ToList();
        }

        public void UpdateContact(Contact contact)
        {
            var filter = Builders<Contact>.Filter.Eq(contact => contact.Id, contact.Id);
            
            contactsCollection.ReplaceOne(filter, contact);
        }
    }
}