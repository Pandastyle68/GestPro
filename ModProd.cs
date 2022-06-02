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
    public partial class ModProd : Form
    {
        private ProduitCo proCo;
        private int idProduit;
        public ModProd(int idPro)
        {
            InitializeComponent();
            idProduit = idPro;
            proCo = new ProduitCo();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtIdF.Text != "" && txtLabel.Text != "" && txtPoids.Text != "" && txtPrixA.Text != "" && txtPrixV.Text != "" && txtStock.Text != "")
            {
                Produit produit = new Produit(idProduit, txtLabel.Text, txtPoids.Text, int.Parse(txtStock.Text), txtPrixA.Text, txtPrixV.Text, int.Parse(txtIdF.Text));
                if (proCo.ModifyProduit(produit))
                {
                    MessageBox.Show("Modification réussie ! ");
                }
                else
                {
                    MessageBox.Show("Modification échouée ! ");
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var EmpFor = new ConsProd();
            this.Hide();
            EmpFor.ShowDialog();
        }

        private void ModProd_Load(object sender, EventArgs e)
        {
            Produit pro = proCo.GetProduitById(idProduit);
            txtIdF.Text = pro.IdFournisseur.ToString();
            txtLabel.Text = pro.Libelle;
            txtPoids.Text = pro.Poids;
            txtPrixA.Text = pro.PrixAchat.Replace(',','.');
            txtPrixV.Text = pro.PrixVente.Replace(',', '.');
            txtStock.Text = pro.Stock.ToString();
        }

        private void ModProd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
