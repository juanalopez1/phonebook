namespace Library.Tests;

public class MessageTest
{
    [TestCase("Juan", "Juanita", "Hola juaniiii")]
    public void MessageConstructor(string from, string to, string text)
    {
        // arrange 
        Message message = new Message(from, to, text);

        // act
        string fromExample = "Juan";
        string toExample = "Juanita";
        string textExample = "Hola juaniiii";

        // assert
        Assert.That(message.From, Is.EqualTo(fromExample));
        Assert.That(message.To, Is.EqualTo(toExample));
        Assert.That(message.Text, Is.EqualTo(textExample));

    }
}