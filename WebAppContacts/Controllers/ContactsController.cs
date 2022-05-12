using System;
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

        // POST
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
                PhoneNumber = create.PhoneMuber,
                BirthDate = create.BirthDate
            };
            repository.CreateContact(contact);
            
            return Ok(contact);
        }
    }
}