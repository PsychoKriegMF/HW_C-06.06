using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_06._06
{
    public class ContactManager
    {
        private List<Contact> contacts = new List<Contact>();
        public void AddContact(string name,string phoneNumber)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber))
            {
                throw new ContactException();
            }
            contacts.Add(new Contact { Name = name, PhoneNumber = phoneNumber });
        }
        public IEnumerable<Contact> FindContactByName(string name)
        {
            return contacts.Where(x => x.Name == name);
        }
    }
}
