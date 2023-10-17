namespace Library;

// Pueden agregar operaciones a esta interfaz.
public interface IMessageChannel
{
        void Send(Contact contact, Message message);
}