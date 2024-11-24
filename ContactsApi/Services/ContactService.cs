using ContactsApi.Models;
using ContactsApi.Storage;

namespace ContactsApi.Services
{
    public class ContactService(IContactStorage contactStorage) : IContactService
    {
        private readonly IContactStorage _contactStorage = contactStorage;

        public async Task<(ContactRecord?, int)> GetContactAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return (null, 400);
            }
            var result = await _contactStorage.GetContactAsync(id: "abc");
            if (result is null)
            {
                return (null, 204);
            }
            return (result, 200);
        }
    }
}
