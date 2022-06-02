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
    public partial class AjoutFourn : Form
    {
        private FournisseurCo fourCo;
        public AjoutFourn()
        {
            InitializeComponent();
            fourCo = new FournisseurCo();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtNum.Text != "" )
            {
                Fournisseur nouvEmp = new Fournisseur(0, txtNom.Text, txtPrenom.Text, txtNum.Text);
                if (fourCo.AddFournisseur(nouvEmp))
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
            var EmpFor = new ConsFourn();
            this.Hide();
            EmpFor.ShowDialog();
        }

        private void AjoutFourn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
