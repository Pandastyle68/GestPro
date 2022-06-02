using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPro
{
    class Poste
    {
        private int id;
        private string libelle;

        public Poste(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int Id { get => id;  }
        public string Libelle { get => libelle;  }
    }
}
