namespace Library.Tests;

public class ContactTests
{
    [TestCase("belu", "+598minumero", "belu@correo.com")]
    public void CorrectConstructor(string name, string phone, string email)
    {
        // arrange 
        Contact contact = new Contact(name, phone, email);

        // act
        string myName = "belu";
        string myPhone = "+598minumero";
        string myEmail = "belu@correo.com";

        // assert
        Assert.That(contact.Name, Is.EqualTo(myName));
        Assert.That(contact.Phone, Is.EqualTo(myPhone));
        Assert.That(contact.Email, Is.EqualTo(myEmail));

    }
}