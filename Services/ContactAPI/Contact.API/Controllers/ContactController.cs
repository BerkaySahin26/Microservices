using Contact.API.Infrastructure;
using Contact.API.Models;
using Contact.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService ContactService)
        {
            _contactService = ContactService;
            
        }

        [HttpGet]
        public ContactDTO Get(int Id) 
        {
            return _contactService.GetContactById(Id);
        }
    }
}
