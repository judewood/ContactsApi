using ContactsApi.Models;

namespace ContactsApi.Services
{
    public interface IContactService
    {
        Task<(ContactRecord?, int)> GetContactAsync(string id);
    }
}
