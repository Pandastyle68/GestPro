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
    class ProduitCo
    {
        private Connexion laConnexion = new Connexion();


        public Produit GetProduitById(int id)
        {
            laConnexion.OpenConnection();
            Produit prod;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM produit WHERE id = " + id, laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                prod = new Produit(int.Parse(dt.Rows[0].ItemArray[0].ToString()), dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[2].ToString(), int.Parse(dt.Rows[0].ItemArray[3].ToString()),dt.Rows[0].ItemArray[4].ToString(),dt.Rows[0].ItemArray[5].ToString(),int.Parse(dt.Rows[0].ItemArray[6].ToString()));
            }
            else
            {
                prod = new Produit(0, "null", "0", 0, "0","0",0);
            }
            laConnexion.CloseConnection();
            return prod;
        }

        public bool AddProduit(Produit prod)
        {
            bool ok = false;
            laConnexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO produit(libelle,poids,stock,prixAchat,prixVente,idFournisseur)VALUES('" + prod.Libelle + "'," + prod.Poids + "," + prod.Stock + "," + prod.PrixAchat + "," + prod.PrixVente + "," + prod.IdFournisseur + ")", laConnexion.getConnectString());
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

        public bool ModifyProduit(Produit prod)
        {
            bool ok = false;
            laConnexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("UPDATE produit  SET libelle = '" + prod.Libelle + "', poids =" + prod.Poids + ", stock = " + prod.Stock + ", prixAchat = " + prod.PrixAchat +", prixVente = " + prod.PrixVente +", idFournisseur = " + prod.IdFournisseur +" WHERE id = " + prod.Id, laConnexion.getConnectString());
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


        public List<Produit> GetProduits()
        {
            laConnexion.OpenConnection();
            List<Produit> lesProd = new List<Produit>();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM produit", laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Produit prod = new Produit(int.Parse(row.ItemArray[0].ToString()), row.ItemArray[1].ToString(),row.ItemArray[2].ToString(), int.Parse(row.ItemArray[3].ToString()), row.ItemArray[4].ToString(), row.ItemArray[5].ToString(), int.Parse(row.ItemArray[6].ToString()));
                    lesProd.Add(prod);
                }
            }

            laConnexion.CloseConnection();
            return lesProd;
        }
    }
}
