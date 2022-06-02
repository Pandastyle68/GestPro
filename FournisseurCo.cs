using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestPro
{
    class FournisseurCo
    {
        private Connexion laConnexion = new Connexion();


        public Fournisseur GetFournisseurById(int id)
        {
            laConnexion.OpenConnection();
            Fournisseur fourn;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM fournisseur WHERE id = " + id, laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                fourn = new Fournisseur(int.Parse(dt.Rows[0].ItemArray[0].ToString()), dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[2].ToString(), dt.Rows[0].ItemArray[3].ToString());
            }
            else
            {
                fourn = new Fournisseur(0, "null", "null", "null");
            }
            laConnexion.CloseConnection();
            return fourn;
        }

        public bool AddFournisseur(Fournisseur fo)
        {
            bool ok = false;
            laConnexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO fournisseur(nom,adresse,pays) VALUES('" + fo.Nom + "','" + fo.Adresse + "','" + fo.Pays +"')" ,laConnexion.getConnectString());
            try
            {
                da.Fill(dt);
                ok = true;
            }
            catch (Exception e)
            {

            }
            return ok;
        }

        public bool ModifyFournisseur(Fournisseur fourn)
        {
            bool ok = false;
            laConnexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("UPDATE fournisseur SET nom = '" + fourn.Nom + "', adresse ='" + fourn.Adresse + "', pays = '" + fourn.Pays + "' WHERE id = " + fourn.Id, laConnexion.getConnectString());
            try
            {
                da.Fill(dt);
                ok = true;
            }
            catch (Exception e)
            {

            }
            return ok;
        }


        public List<Fournisseur> GetFournisseurs()
        {
            laConnexion.OpenConnection();
            List<Fournisseur> fournisseurs = new List<Fournisseur>();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM fournisseur", laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Fournisseur fourn = new Fournisseur(int.Parse(row.ItemArray[0].ToString()), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString());
                    fournisseurs.Add(fourn);
                }
            }

            laConnexion.CloseConnection();
            return fournisseurs;
        }
    }
}
