using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPro
{
    class Fournisseur
    {
        private int id;
        private string nom;
        private string adresse;
        private string pays;

        public Fournisseur(int id, string nom, string adresse, string pays)
        {
            this.id = id;
            this.nom = nom;
            this.adresse = adresse;
            this.pays = pays;
        }

        public int Id { get => id;  }
        public string Nom { get => nom;  }
        public string Adresse { get => adresse;  }
        public string Pays { get => pays; }


    }
}
