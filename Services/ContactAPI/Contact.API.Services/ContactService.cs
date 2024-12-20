using Contact.API.Infrastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContact()
        {
            return new ContactDTO()
            {
                Id = 1,
                FirstName = "Berkay",
                LastName = "Şahin"
            };
        }

        public ContactDTO GetContactById(int Id)
        {
            return new ContactDTO()
            {
                Id = Id,
                FirstName = "Berkay",
                LastName = "Şahin"
            };
        }
    }
}
