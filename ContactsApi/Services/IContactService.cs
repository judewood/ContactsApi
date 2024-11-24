using ContactsApi.Models;

namespace ContactsApi.Services
{
    public interface IContactService
    {
        Task<ContactRecord?> GetContactAsync(string id);
    }
}
