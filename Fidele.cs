using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPro
{
    class Fidele
    {
        private int id;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        public Fidele(int id, string nom, string prenom, DateTime dateNaissance)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        public int Id { get => id;  }
        public string Nom { get => nom; }
        public string Prenom { get => prenom;  }
        public DateTime DateNaissance { get => dateNaissance;}
    }
}
