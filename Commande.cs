using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPro
{
    class Commande
    {
        private int numero;
        private Produit leProduit;
        private Employe leEmploye;
        private int quantite;
        private DateTime laDate;

        public Commande(int numero, Produit leProduit, Employe leEmploye, int quantite, DateTime laDate)
        {
            this.numero = numero;
            this.leProduit = leProduit;
            this.leEmploye = leEmploye;
            this.quantite = quantite;
            this.laDate = laDate;
        }

        public int Quantite { get => quantite;  }
        public DateTime LaDate { get => laDate;  }
        public string LeProduit { get => leProduit.Libelle; }
        public string LeEmploye { get => leEmploye.getNom+" "+leEmploye.getPrenom; }
        public int Numero { get => numero; }

        public Produit getLeProduit()
        {
            return this.leProduit;
        }

        public Employe getLeEmploye()
        {
            return this.leEmploye;
        }
    }
}
