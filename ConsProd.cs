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

    public partial class ConsProd : Form
    {
        ProduitCo proCo;
        FournisseurCo fourCo;
        int idSelect = 0;
        public ConsProd()
        {
            InitializeComponent();
            proCo = new ProduitCo();
            fourCo = new FournisseurCo();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var FormEmp = new Form1();
            this.Hide();
            FormEmp.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((idSelect) != 0)
            {
                var FormEmp = new ModProd(idSelect);
                this.Hide();
                FormEmp.ShowDialog();
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            var FormEmp = new AjoutProd();
            this.Hide();
            FormEmp.ShowDialog();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                Produit prod = proCo.GetProduitById(int.Parse(txtId.Text));
                if (prod.Id != 0)
                {
                    MessageBox.Show("Libellé : " + prod.Libelle + "\nPoids : " + prod.Poids + "\nStock : " + prod.Stock + "\nPrix Achat : " + prod.PrixAchat + "\nPrix Vente : " + prod.PrixVente+ "\nFournisseur : " + fourCo.GetFournisseurById(prod.IdFournisseur).Nom);
                }
                else
                {
                    MessageBox.Show("Produit introuvable");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Impossible de chercher ce produit, erreur : " + exc.Message);
            }
        }

        private void ConsProd_Load(object sender, EventArgs e)
        {
            List<Produit> lesProduits = proCo.GetProduits();
            dataGridView1.DataSource = lesProduits;
            dataGridView1.Columns[0].HeaderText = "Identifiant";
            dataGridView1.Columns[1].HeaderText = "Libelle";
            dataGridView1.Columns[2].HeaderText = "Poids";
            dataGridView1.Columns[3].HeaderText = "Stock";
            dataGridView1.Columns[4].HeaderText = "Prix Achat";
            dataGridView1.Columns[5].HeaderText = "Prix Vente";
            dataGridView1.Columns[5].HeaderText = "Identifiant Fournisseur";
        }

        private void ConsProd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelect = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
