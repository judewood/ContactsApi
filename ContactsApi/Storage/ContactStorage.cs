using ContactsApi.Models;

namespace ContactsApi.Storage
{
    public class ContactStorage : IContactStorage
    {
        public async Task<ContactRecord?> GetContactAsync(string id)
        {
            var c = await Task.Run(getContact);
            return c;
        }

        private ContactRecord getContact()
        {
            ContactRecord contact = new("Fred", "Smith");
            return contact;
        }
    }
}
