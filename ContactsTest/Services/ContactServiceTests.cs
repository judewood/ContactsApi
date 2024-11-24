namespace ContactsTest;
using ContactsApi.Models;
using ContactsApi.Services;
using ContactsApi.Storage;
using Moq;

public class ContactServiceTests
{
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData(" \t")]
    public async void GetContactAsync_Returns400_WhenIdNotSupplied(string id)
    {
        var uut = new ContactService(new ContactStorage());

        var (result, status) = await uut.GetContactAsync(id);

        Assert.Null(result);
        Assert.Equal(400, status);
    }

    [Fact]
    public async void GetContactAsync_Returns204_WhenNotFound()
    {

        var id = "anything";

        var mockContactStorage = new Mock<IContactStorage>();
        mockContactStorage.Setup(x => x.GetContactAsync(id)).ReturnsAsync((ContactRecord?)null);

        var uut = new ContactService(mockContactStorage.Object);

        var (result, status) = await uut.GetContactAsync(id);

        Assert.Null(result);
        Assert.Equal(204, status);
    }

    [Fact]
    public async void GetContactAsync_Returns200_WhenSuccess()
    {
        var id = "anything";
        ContactRecord? expected = new("Fred", "Smith");

        var uut = new ContactService(new ContactStorage());

        var (result, status) = await uut.GetContactAsync(id);
        Assert.Equal(200, status);
        Assert.Equal(expected, result);
        
    }
}