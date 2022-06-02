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
    public partial class AjoutEmploye : Form
    {
        private EmployeCo emCo;
        public AjoutEmploye()
        {
            InitializeComponent();
            emCo = new EmployeCo();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var EmpFor = new ConsultEmploye();
            this.Hide();
            EmpFor.ShowDialog();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtNum.Text != "" && txtEmail.Text != "")
            {
                Employe nouvEmp = new Employe(0, txtNom.Text, txtPrenom.Text, txtNum.Text, txtEmail.Text);
                if (emCo.AddEmploye(nouvEmp))
                {
                    MessageBox.Show("Ajout réussi ! ");
                }
                else
                {
                    MessageBox.Show("Ajout échoué ! ");
                }
            }
        }

        private void AjoutEmploye_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
