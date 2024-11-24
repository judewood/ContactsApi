namespace ContactsApi.Storage
{
    public interface IContactStorage
    {
        Task<Models.ContactRecord?> GetContactAsync(string id);
    }
}
