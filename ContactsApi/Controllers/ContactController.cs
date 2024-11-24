using ContactsApi.Models;
using ContactsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController(IContactService contactService, ILogger<ContactController> logger)
{
    private readonly ILogger<ContactController> _logger = logger;

    private readonly IContactService _contactService = contactService;

    [HttpGet(Name = "GetContact")]
    public async Task<ContactRecord?> GetContact()
    {
        string id = "99";
        return await _contactService.GetContactAsync(id);
    }
}

