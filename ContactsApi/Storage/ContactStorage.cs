using ContactsApi.Models;

namespace ContactsApi.Storage
{
    public class ContactStorage : IContactStorage
    {
        public async Task<ContactsApi.Models.ContactRecord> GetContactAsync<Contact>(string id)
        {
            var c = await Task.Run(() => getContact());
            return c;
        }


        private ContactRecord getContact()
        {
            ContactRecord contact = new("Fred", "Smith");
            return contact;
        }
    }
}
