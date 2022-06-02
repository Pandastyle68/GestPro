using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace GestPro
{
    class PosteCo
    {
        private Connexion laConnexion = new Connexion();


        public Poste GetPosteById(int id)
        {
            laConnexion.OpenConnection();
            Poste unPoste;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM poste WHERE id = " + id, laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                unPoste = new Poste(int.Parse(dt.Rows[0].ItemArray[0].ToString()), dt.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                unPoste = new Poste(0, "null");
            }
            laConnexion.CloseConnection();
            return unPoste;
        }

        public Poste GetPosteByEmployeId(int id)
        {
            laConnexion.OpenConnection();
            Poste unPoste;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM occupe WHERE idEmploye = " + id, laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                unPoste = GetPosteById(int.Parse(dt.Rows[0].ItemArray[1].ToString()));
            }
            else
            {
                unPoste = new Poste(4, "Employé");
            }
            laConnexion.CloseConnection();
            return unPoste;
        }

        public List<Poste> GetPostes()
        {
            laConnexion.OpenConnection();
            List<Poste> lesPostes = new List<Poste>();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM poste", laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Poste poste = new Poste(int.Parse(row.ItemArray[0].ToString()), row.ItemArray[1].ToString());
                    lesPostes.Add(poste);
                }
            }

            laConnexion.CloseConnection();
            return lesPostes;
        }
    }
}
