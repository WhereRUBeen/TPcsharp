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
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        //id_adresse
        public Categorie categorie_id { get; set; }
    }
    //class - table categorie
    public class Categorie
    {
        public int Id_categorie { get; set; }
        public string Nom_categori { get; set; }
    }

    //class - table adresse
    public class Adresse
    {
        public int Id_adresse { get; set; }
        public string Numero_rue { get; set; }
        public string Nom_rue { get; set; }
        public string Code_postal { get; set; }
        public string Province { get; set; }
    }

}
