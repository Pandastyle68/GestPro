using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPro
{
    public partial class ConsFourn : Form
    {
        private FournisseurCo fourCo;
        public ConsFourn()
        {
            InitializeComponent();
            fourCo = new FournisseurCo();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            var FormEmp = new AjoutFourn();
            this.Hide();
            FormEmp.ShowDialog();
        }

        private void ConsFourn_Load(object sender, EventArgs e)
        {
            List<Fournisseur> fournisseurs = fourCo.GetFournisseurs();
            dataGridView1.DataSource = fournisseurs;
            dataGridView1.Columns[0].HeaderText = "Identifiant";
            dataGridView1.Columns[1].HeaderText = "Nom";
            dataGridView1.Columns[2].HeaderText = "Adresse";
            dataGridView1.Columns[3].HeaderText = "Pays";
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                Fournisseur unEmp = fourCo.GetFournisseurById(int.Parse(txtId.Text));
                if (unEmp.Id != 0)
                {
                    MessageBox.Show("Nom : " + unEmp.Nom + "\nAdresse : " + unEmp.Adresse + "\nPays : " + unEmp.Pays);
                }
                else
                {
                    MessageBox.Show("Fournisseur introuvable");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Impossible de chercher ce fournisseur, erreur : " + exc.Message);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var FormEmp = new Form1();
            this.Hide();
            FormEmp.ShowDialog();
        }

        private void ConsFourn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
