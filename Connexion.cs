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

        static Connexion()
        {
        }

        public void OpenConnection()
        {
            connectstring.Open();
        }

        public void CloseConnection()
        {
            connectstring.Close();
        }

        public MySqlConnection getConnectString()
        {
            return connectstring;
        }

    }
}
