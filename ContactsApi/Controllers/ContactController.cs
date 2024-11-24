using ContactsApi.Models;
using ContactsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Controllers;

[ApiController]
[Route("")]
public class ContactController(IContactService contactService, ILogger<ContactController> logger) : ControllerBase
{
    private readonly ILogger<ContactController> _logger = logger;

    private readonly IContactService _contactService = contactService;

    [Route("/contact/{id}")]
    [HttpGet(Name = "GetContact")]
    [ProducesResponseType<ContactRecord>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetContact(string id)
    {
        var (result, status) = await _contactService.GetContactAsync(id);
        return status switch
        {
            200 => Ok(result),
            _ => StatusCode(status),
        };
    }
}

