using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    //class - table contact
    public class Contact
    {
        public int Id { get; set; }
        public Personne Personne { get; set; }
    }

    //class - table personne
    public class Personne
    {
        public int Id_personne { get; set; }
        public string nom_personne { get; set; }
        public string prenom_personne { get; set; }
        public string mail { get; set; }
        public Adresse id_adresse { get; set; }
        public Categorie id_categorie { get; set; }
        public Genre id_genre { get; set; }
    }

    //class - table categorie
    public class Categorie
    {
        public int Id_categorie { get; set; }
        public string Type_categorie{ get; set; }
    }

    //claa - table genre
    public class Genre
    {
        public int id_genre { get; set; }
        public string type_genre { get; set; }

    }
    //class - table adresse
    public class Adresse
    {
        
        public int Id_adresse { get; set; }
        public string Numero_rue { get; set; }
        public string Nom_rue { get; set; }
        public string Code_postal { get; set; }
        public string Ville { get; set; }
        public string Province { get; set; }
    }

}
