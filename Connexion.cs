using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestPro
{
    class Connexion
    {
        private MySqlConnection connectstring = new MySqlConnection("server=localhost;user id=root;database=bdd_progest;persistsecurityinfo=True");
        private bool connecte = false;

        public bool Connecte { get => connecte; }

        static Connexion()
        {
        }

        public void OpenConnection()
        {
            if (!connecte)
            {
                connectstring.Open();
                connecte = true;
            }
        }

        public void CloseConnection()
        {
            if (connecte)
            {
                connectstring.Close();
                connecte = false;
            }
        }

        public MySqlConnection getConnectString()
        {
            return connectstring;
        }

    }
}
