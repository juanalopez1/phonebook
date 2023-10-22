using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contact owner = new Contact("pablo", "+598 99747441", "pablo@gmail.com");

            //Phonebook list = new Phonebook(owner);

            //list.AddContact("belen", "+598 98770061", "mimail@gmail.com");
            //list.AddContact("markitos", "+598 91070442", "mimail@gmail.com");

            var whatsApp = new WhatsAppApi();
            whatsApp.Send("+59899747441", "anduvo!!!!");

            // Agregar contactos a la lista

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}