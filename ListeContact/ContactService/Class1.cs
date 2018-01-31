using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactService
{
    public class Service
    {
        //connection a la basse de donnees
        static string connectionString = @"Data Source=DESKTOP-IMF9U2H;
                Initial Catalog = listecontact;
                Integrated Security = True;
                 Connect Timeout = 5";

        public static List<Contact> ListeContact()
        {
            List<Contact> contacts = new List<Contact>();

            string connStr = connectionString;
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"select * from contact";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contact contact = new Contact();
                            contact.Nom = reader.GetString(1);
                            contact.Prenom = reader.GetString(2);
                           
                            contacts.Add(contact);
                        }
                    }
                }
            }

            return contacts;
        }

    }
}
