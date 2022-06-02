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
    public partial class AjoutProd : Form
    {
        private ProduitCo proCo;
        public AjoutProd()
        {
            InitializeComponent();
            proCo = new ProduitCo();
        }

        private void AjoutProd_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtIdF.Text != "" && txtLabel.Text != "" && txtPoids.Text != "" && txtPrixA.Text != "" && txtPrixV.Text != "" && txtStock.Text != "")
            {
                Produit produit = new Produit(0, txtLabel.Text, txtPoids.Text, int.Parse(txtStock.Text), txtPrixA.Text, txtPrixV.Text, int.Parse(txtIdF.Text));
                if (proCo.AddProduit(produit))
                {
                    MessageBox.Show("Ajout réussi ! ");
                }
                else
                {
                    MessageBox.Show("Ajout échoué ! ");
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var EmpFor = new ConsProd();
            this.Hide();
            EmpFor.ShowDialog();
        }
    }
}
