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
    public partial class ConsCommande : Form
    {
        private int numSelect = 0;
        private CommandeCo comCo;
        private EmployeCo emCo;
        private ProduitCo proCo;
        public ConsCommande()
        {
            InitializeComponent();
            comCo = new CommandeCo();
            emCo = new EmployeCo();
            proCo = new ProduitCo();
        }

        private void ConsCommande_Load(object sender, EventArgs e)
        {
            List<Commande> commandes = comCo.getCommandes();
            dataGridView1.DataSource = commandes;
            dataGridView1.Columns[4].HeaderText = "Numéro";
            dataGridView1.Columns[3].HeaderText = "Employé";
            dataGridView1.Columns[2].HeaderText = "Produit";
            dataGridView1.Columns[1].HeaderText = "Quantité";
            dataGridView1.Columns[1].HeaderText = "Date";
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                Commande commande = comCo.getCommandeByNum(int.Parse(txtId.Text));
                if (commande.Numero != 0)
                {
                    MessageBox.Show("Commande numéro : " + commande.Numero + "\nEmployé : " + commande.LeEmploye + "\nProduit : " + commande.LeProduit + "\nQuantité : " + commande.Quantite + "\nDate : " + commande.LaDate);
                }
                else
                {
                    MessageBox.Show("Commande introuvable");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Impossible de chercher cette commande, erreur : " + exc.Message);
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new AjoutCommande();
            Form.ShowDialog();
        }

        private void ConsCommande_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form1();
            Form.ShowDialog();
        }
    }
}
