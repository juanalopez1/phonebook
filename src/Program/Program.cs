using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Contact owner = new Contact("Juan", "+59892230531", "juan.tanca@correo.ucu.edu.uy");

            Phonebook list = new Phonebook(owner);

            // Agregar contactos a la lista
            list.AddContact("Belu", "+59898770061", "vendomadera@correo.ucu.edu.uy");
            list.AddContact("Juanita", "+59899747441", "juana.lopez@correo.ucu.edu.uy");
            list.AddContact("Gabi", "+59899747441", "juana.lopez@correo.ucu.edu.uy");

            // Enviar un WhatsApp a algunos contactos
            string[] namesList = new string[3];
            namesList[0] = "Juanita";
            namesList[1] = "Belu";

            List<Contact> contacts = list.Search(namesList);

            foreach (Contact contact in contacts)
            {
                WhatsAppChannel msj = new WhatsAppChannel();
                Message txt = new Message(owner.Name, contact.Name, "HOLA, ANDO VENDIENDO MADERA");
                msj.Send(contact, txt);
            }






        }
    }
}