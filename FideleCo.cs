using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestPro
{
    class FideleCo
    {
        private Connexion laConnexion = new Connexion();
        public Fidele GetFideleById(int id)
        {
            laConnexion.OpenConnection();
            Fidele fid;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM fidele WHERE id = " + id, laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                fid = new Fidele(int.Parse(dt.Rows[0].ItemArray[0].ToString()), dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[2].ToString(), DateTime.Parse(dt.Rows[0].ItemArray[3].ToString()));
            }
            else
            {
                fid = new Fidele(0, "null", "null", DateTime.Now);
            }
            laConnexion.CloseConnection();
            return fid;
        }

        public bool AddFidele(Fidele fid)
        {
            bool ok = false;
            laConnexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO fidele(nom,prenom,dateNaissance) VALUES('" + fid.Nom + "','" + fid.Prenom + "','" + fid.DateNaissance.ToString("yyyy/MM/dd") + "')", laConnexion.getConnectString());
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

        public bool ModifyFidele(Fidele fid)
        {
            bool ok = false;
            laConnexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("UPDATE fidele SET nom = '" + fid.Nom + "', prenom ='" + fid.Prenom + "', dateNaissance = '" + fid.DateNaissance.ToString("yyyy/MM/dd") + "' WHERE id = " + fid.Id, laConnexion.getConnectString());
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
        public List<Fidele> GetFideles()
        {
            laConnexion.OpenConnection();
            List<Fidele> lesFid = new List<Fidele>();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM fidele", laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Fidele unFid = new Fidele(int.Parse(row.ItemArray[0].ToString()), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), DateTime.Parse(row.ItemArray[3].ToString()));
                    lesFid.Add(unFid);
                }
            }

            laConnexion.CloseConnection();
            return lesFid;
        }
    }
}
