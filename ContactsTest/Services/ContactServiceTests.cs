namespace ContactsTest;
using ContactsApi.Services;
using ContactsApi.Storage;

public class ContactServiceTests
{
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData(" \t")]
    public async void GetContactAsync_ReturnsNullWhenNoIsSupplied(string id)
    {
        var uut = new ContactService(new ContactStorage());
        var result = await uut.GetContactAsync(id);
        Assert.Null(result);
    }
}