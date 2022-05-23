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


        public Employe GetEmployeById(int id)
        {
            laConnexion.OpenConnection();
            Employe emp;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM employe WHERE id = " + id, laConnexion.getConnectString());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                emp = new Employe(int.Parse(dt.Rows[0].ItemArray[0].ToString()), dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[2].ToString(), dt.Rows[0].ItemArray[3].ToString(), dt.Rows[0].ItemArray[4].ToString());
            }
            else
            {
                emp = new Employe(0, "null", "null", "null", "null");
            }
            laConnexion.CloseConnection();
            return emp;
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
                    Employe unEmp = new Employe(int.Parse(row.ItemArray[0].ToString()), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), row.ItemArray[4].ToString());
                    emp.Add(unEmp);
                }
            }

                laConnexion.CloseConnection();
            return emp;
        }

    }
}
