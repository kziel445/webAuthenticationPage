using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAppContacts.Models;
using WebAppContacts.Repositories;
using WebAppContacts.Schemas;

namespace WebAppContacts.Controllers
{   
    [ApiController][Route("contacts")]
    public class ContactsController : ControllerBase
    {
        private readonly IContactsRepository repository;
        public ContactsController(IContactsRepository repository)
        {
            this.repository = repository;
        }

        // GET /contacts
        [HttpGet]
        public IEnumerable<Contact> GetItems()
        {
            var contacts = repository.GetContacts().Select(contacts => contacts.ReturnContact());
            
            return contacts;
        }

        // GET /contacts/{id}
        [HttpGet("{id}")]
        public ActionResult<Contact> GetItem(Guid id)
        {
            var contact = repository.GetContact(id);
            if(contact is null) return NotFound();
            return contact.ReturnContact();
        }

        // POST /contacts
        [HttpPost]
        public ActionResult<Contact> CreateContact(CreateContact create)
        {
            Contact contact = new Contact()
            {
                Id = Guid.NewGuid(),
                FirstName = create.FirstName,
                LastName = create.LastName,
                Email = create.Email,
                Password = create.Password,
                NumberCategory = create.NumberCategory,
                SubCategory = create.SubCategory,
                PhoneNumber = create.PhoneNumber,
                BirthDate = create.BirthDate
            };
            repository.CreateContact(contact);
            
            return Ok(contact);
        }

        // PUT /contacts/{id}
        [HttpPut("{id}")]
        public ActionResult<Contact> UpdateContact(Guid id, UpdateContact contact)
        {
            var existingContact = repository.GetContact(id);
            if(existingContact is null) return NotFound();

            Contact update = existingContact with
            {
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Email = contact.Email,
                Password = contact.Password,
                NumberCategory = contact.NumberCategory,
                SubCategory = contact.SubCategory,
                PhoneNumber = contact.PhoneNumber,
                BirthDate = contact.BirthDate
            };
            repository.UpdateContact(update);

            return NoContent();
        }

        // DELETE /contacts/{id}
        [HttpDelete("{id}")]
        public ActionResult<Contact> DeleteContact(Guid id)
        {
            var existingContact = repository.GetContact(id);
            if(existingContact is null) return NotFound();

            repository.DeleteContact(id);

            return NoContent();
        }
    }
}
