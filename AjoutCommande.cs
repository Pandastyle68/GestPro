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
    public partial class AjoutCommande : Form
    {
        private CommandeCo comCo;
        private ProduitCo proCo;
        private EmployeCo empCo;
        public AjoutCommande()
        {
            InitializeComponent();
            comCo = new CommandeCo();
            proCo = new ProduitCo();
            empCo = new EmployeCo();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new ConsCommande();
            Form.ShowDialog();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtEmp.Text != "" && txtProd.Text != "" && txtQuantite.Text != "" )
            {
                Commande com = new Commande(0, proCo.GetProduitById(int.Parse(txtProd.Text)), empCo.GetEmployeById(int.Parse(txtEmp.Text)), int.Parse(txtQuantite.Text), DateTime.Now);
                if (comCo.AddCommande(com))
                {
                    MessageBox.Show("Ajout réussi ! ");
                }
                else
                {
                    MessageBox.Show("Ajout échoué ! ");
                }
            }
        }

        private void AjoutCommande_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
