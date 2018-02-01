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
            using (SqlConnection conn = new SqlConnection(connStr))
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
                            contact.Id = reader.GetInt16(1);
                            contact.Personne.nom_personne = reader.GetString(1);
                            contact.Personne.prenom_personne = reader.GetString(2);
                            contact.Personne.mail = reader.GetString(3);
                            contact.Personne.id_categorie.Type_categorie = reader.GetString(2);
                            contact.Personne.id_genre.type_genre = reader.GetString(6);

                            contacts.Add(contact);
                        }
                    }
                }
            }


            return contacts;
        }
        public static Contact GetGetContact(int id)
        {
            Contact contact = null;
            string con = connectionString;
            using (SqlConnection connexion = new SqlConnection(con))
            {
                connexion.Open();
                using (SqlCommand cmd = connexion.CreateCommand())
                {
                    cmd.CommandText = @"select nom from contact where @id";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                             contact = new Contact();
                            {
                                contact.Id = reader.GetInt16(1);
                                contact.Personne.nom_personne = reader.GetString(1);
                                contact.Personne.prenom_personne = reader.GetString(2);
                                contact.Personne.mail = reader.GetString(3);
                                contact.Personne.id_categorie.Type_categorie = reader.GetString(2);
                                contact.Personne.id_genre.type_genre = reader.GetString(6);

                            }
                        }
                    }
                }
            }
            return contact;
        }

    }
}
