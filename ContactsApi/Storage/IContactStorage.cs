namespace ContactsApi.Storage
{
    public interface IContactStorage
    {
        Task<ContactsApi.Models.ContactRecord> GetContactAsync<Contact>(string id);
    }
}
