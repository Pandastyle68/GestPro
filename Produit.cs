using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPro
{
    class Produit
    {
        private int id;
        private string libelle;
        private string poids;
        private int stock;
        private string prixAchat;
        private string prixVente;
        private int idFournisseur;

        public Produit(int id, string libelle, string poids, int stock, string prixAchat, string prixVente, int idFournisseur)
        {
            this.id = id;
            this.libelle = libelle;
            this.poids = poids;
            this.stock = stock;
            this.prixAchat = prixAchat;
            this.prixVente = prixVente;
            this.idFournisseur = idFournisseur;
        }

        public int Id { get => id; }
        public string Libelle { get => libelle; }
        public string Poids { get => poids;  }
        public int Stock { get => stock;  }
        public string PrixAchat { get => prixAchat;  }
        public string PrixVente { get => prixVente;  }
        public int IdFournisseur { get => idFournisseur; }
    }
}
