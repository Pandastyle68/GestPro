using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestPro
{
    class CommandeCo
    {
        private Connexion laConnexion = new Connexion();
        private EmployeCo emCo = new EmployeCo();
        private ProduitCo proCo = new ProduitCo();

        public List<Commande> GetCommandeByEmployeId(int id)
        {
            laConnexion.OpenConnection();
            List<Commande> lesCommandes = new List<Commande>();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM commande WHERE idEmploye = " + id, laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Commande com = new Commande(int.Parse(row.ItemArray[0].ToString()),proCo.GetProduitById(int.Parse(row.ItemArray[2].ToString())), emCo.GetEmployeById(int.Parse(row.ItemArray[1].ToString())), int.Parse(row.ItemArray[3].ToString()), DateTime.Parse(row.ItemArray[4].ToString()));
                    lesCommandes.Add(com);
                }
            }

            laConnexion.CloseConnection();
            return lesCommandes;
        }

        public bool AddCommande(Commande co)
        {
            bool ok = false;
            laConnexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO commande(idProduit,idEmploye,quantite,date) VALUES(" + co.getLeProduit().Id + "," + co.getLeEmploye().getId + "," + co.Quantite + ",NOW())", laConnexion.getConnectString());
            try { da.Fill(dt);
                ok = true;
            }catch(Exception e)
            {
                
            }
            return ok;
        }

        public bool ModifyCommande(Commande co)
        {
            bool ok = false;
            laConnexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("UPDATE commande  SET idProduit = " + co.getLeProduit().Id + ", idEmploye =" + co.getLeEmploye().getId + ", quantite = " + co.Quantite + ", date = NOW() WHERE numero = "+ co.Numero, laConnexion.getConnectString());
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

        public List<Commande> GetCommandeByEmployeADNProduitId(int Empid, int Prodid)
        {
            laConnexion.OpenConnection();
            List<Commande> lesCommandes = new List<Commande>();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM commande WHERE idEmploye = " + Empid + " AND idProduit = " + Prodid, laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Commande com = new Commande(int.Parse(row.ItemArray[0].ToString()),proCo.GetProduitById(int.Parse(row.ItemArray[2].ToString())), emCo.GetEmployeById(int.Parse(row.ItemArray[1].ToString())), int.Parse(row.ItemArray[3].ToString()), DateTime.Parse(row.ItemArray[4].ToString()));
                    lesCommandes.Add(com);
                }
            }

            laConnexion.CloseConnection();
            return lesCommandes;
        }

        public List<Commande> GetCommandeByProduitId(int id)
        {
            laConnexion.OpenConnection();
            List<Commande> lesCommandes = new List<Commande>();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM commande where idProduit = " + id, laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Commande com = new Commande(int.Parse(row.ItemArray[0].ToString()),proCo.GetProduitById(int.Parse(row.ItemArray[2].ToString())), emCo.GetEmployeById(int.Parse(row.ItemArray[1].ToString())), int.Parse(row.ItemArray[3].ToString()), DateTime.Parse(row.ItemArray[4].ToString()));
                    lesCommandes.Add(com);
                }
            }

            laConnexion.CloseConnection();
            return lesCommandes;
        }

        public Commande getCommandeByNum(int id)
        {
            laConnexion.OpenConnection();
            Commande fid;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM commande WHERE numero = " + id, laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                fid = new Commande(int.Parse(dt.Rows[0].ItemArray[0].ToString()), proCo.GetProduitById(int.Parse(dt.Rows[0].ItemArray[2].ToString())), emCo.GetEmployeById(int.Parse(dt.Rows[0].ItemArray[1].ToString())), int.Parse(dt.Rows[0].ItemArray[3].ToString()), DateTime.Parse(dt.Rows[0].ItemArray[4].ToString()));
            }
            else
            {
                fid = new Commande(0, null, null, 0, DateTime.Now);
            }
            laConnexion.CloseConnection();
            return fid;
        }

        public List<Commande> getCommandes()
        {
            laConnexion.OpenConnection();
            List<Commande> lesCommandes = new List<Commande>();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM commande", laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Commande com = new Commande(int.Parse(row.ItemArray[0].ToString()),proCo.GetProduitById(int.Parse(row.ItemArray[2].ToString())), emCo.GetEmployeById(int.Parse(row.ItemArray[1].ToString())), int.Parse(row.ItemArray[3].ToString()),DateTime.Parse(row.ItemArray[4].ToString()));
                    lesCommandes.Add(com);
                }
            }

            laConnexion.CloseConnection();
            return lesCommandes;
        }

    }
}
