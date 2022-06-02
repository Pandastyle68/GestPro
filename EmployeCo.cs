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
    class EmployeCo
    {
        private Connexion laConnexion = new Connexion();
        private PosteCo pC = new PosteCo();

        public Employe GetEmployeById(int id)
        {
            laConnexion.OpenConnection();
            Employe emp;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM employe WHERE id = " + id, laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Poste p = pC.GetPosteByEmployeId(int.Parse(dt.Rows[0].ItemArray[0].ToString()));
                emp = new Employe(int.Parse(dt.Rows[0].ItemArray[0].ToString()), dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[2].ToString(), dt.Rows[0].ItemArray[3].ToString(), dt.Rows[0].ItemArray[4].ToString(),p);
            }
            else
            {
                emp = new Employe(0, "null", "null", "null", "null");
            }
            laConnexion.CloseConnection();
            return emp;
        }

        public bool AddEmploye(Employe emp)
        {
            bool ok = false;
            laConnexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Employe(nom,prenom,tel,email) VALUES('" + emp.getNom + "','" + emp.getPrenom + "','" + emp.getTel + "','" + emp.getEmail +"')", laConnexion.getConnectString());
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

        public bool ModifyEmploye(Employe emp)
        {
            bool ok = false;
            laConnexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("UPDATE employe SET nom = '" + emp.getNom + "', prenom ='" + emp.getPrenom + "', tel = '" + emp.getTel + "', email = '" + emp.getEmail + "' WHERE id = " + emp.getId, laConnexion.getConnectString());
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
        public List<Employe> GetEmployes()
        {
            laConnexion.OpenConnection();
            List<Employe> emp = new List<Employe>();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM employe", laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    Poste p = pC.GetPosteByEmployeId(int.Parse(row.ItemArray[0].ToString()));
                    Employe unEmp = new Employe(int.Parse(row.ItemArray[0].ToString()), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), row.ItemArray[4].ToString(), p);
                    emp.Add(unEmp);
                }
            }

                laConnexion.CloseConnection();
            return emp;
        }

    }
}
