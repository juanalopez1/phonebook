using System.Collections.Generic;

namespace Library;

public class Phonebook
{
    private List<Contact> persons;

    public Contact Owner { get; }

    public Phonebook(Contact owner)
    {
        this.Owner = owner;
        this.persons = new List<Contact>();
    }

    public List<Contact> Search(string[] names)
    {
        List<Contact> result = new List<Contact>();

        foreach (Contact person in this.persons)
        {
            foreach (string name in names)
            {
                if (person.Name.Equals(name))
                {
                    result.Add(person);
                }
            }
        }

        return result;
    }

    // agregamos addcontact por creator, la clase respeta open close ya que esta abierta a la extension.
    public void AddContact(string name, string phone, string email)
    {
        persons.Add(new Contact(name, phone, email));
    }

    public void Remove(Contact contact)
    {
        persons.Remove(contact);
    }
}