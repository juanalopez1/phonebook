namespace Library;

public class Message
{
    protected Message(string from, string to, string text)
    {
        this.From = from;
        this.To = to;
        this.Text = text;
    }

    public string Text { get; }

    public string From { get; }

    public string To { get; }
}