using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestPro;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestPro
{
    class Employe
    {
        private int id;
        private string nom;
        private string prenom;
        private string email;
        private string tel;


        public Employe(int id, string nom, string prenom, string tel, string email)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.tel = tel;
        }


        public int getId { get => id; }
        public string getNom { get => nom; }
        public string getPrenom { get => prenom;}
        public string getEmail { get => email;  }
        public string getTel { get => tel; }
        
        
    }
}
