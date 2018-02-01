using ContactService;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Manager
    {
        public static List<Contact> AfficherContacts()
        {
            return Service.ListeContact();
        }

        public static Contact AfficherContactById(int id)
        {
            return Service.GetGetContact(id);
        }
    }
}
