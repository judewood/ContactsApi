using ContactsApi.Models;
using ContactsApi.Storage;

namespace ContactsApi.Services
{
    public class ContactService(IContactStorage contactStorage) : IContactService
    {
        private readonly IContactStorage _contactStorage = contactStorage;

        public async Task<ContactRecord?> GetContactAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }
            return await _contactStorage.GetContactAsync<ContactRecord>(id: "abc");
        }
    }
}
