namespace Library.Tests;

public class PhonebookTests
{
    [Test]
    public void CorrectAdd()
    {
        Contact owner = new Contact("Juan", "+59892230531", "juan.tanca@correo.ucu.edu.uy");
        Phonebook list = new Phonebook(owner);

        list.AddContact("Belu", "+59898770061", "vendomadera@correo.ucu.edu.uy");
        list.AddContact("Juanita", "+59899747441", "juana.lopez@correo.ucu.edu.uy");

        string[] namesList = new string[4];
        namesList[0] = "Juanita";
        namesList[1] = "Belu";

        List<Contact> contacts = list.Search(namesList);
        int expected = 2;

        Assert.That(expected, Is.EqualTo(contacts.Count()));
    }

}