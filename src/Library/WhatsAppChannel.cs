using WhatsAppApiUCU;

namespace Library;

public class WhatsAppChannel : IMessageChannel
{
    public void Send(Contact contact, Message message)
    {
        var whatsApp = new WhatsAppApi();
        whatsApp.Send(contact.Phone.ToString(), message.Text.ToString());
    }
}