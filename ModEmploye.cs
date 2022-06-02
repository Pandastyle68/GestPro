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
    public partial class ModEmploye : Form
    {
        private int employeMod;
        private EmployeCo emCo;
        public ModEmploye(int idEmp)
        {
            InitializeComponent();
            this.employeMod = idEmp;
            emCo = new EmployeCo();
        }

        private void ModEmploye_Load(object sender, EventArgs e)
        {
            Employe employe = emCo.GetEmployeById(employeMod);
            txtNom.Text = employe.getNom;
            txtPrenom.Text = employe.getPrenom;
            txtNum.Text = employe.getTel;
            txtEmail.Text = employe.getEmail;
        }

        private void ModEmploye_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var EmpFor = new ConsultEmploye();
            this.Hide();
            EmpFor.ShowDialog();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(txtNom.Text != "" && txtPrenom.Text != "" && txtNum.Text != "" && txtEmail.Text != "")
            {
                Employe nouvEmp = new Employe(employeMod, txtNom.Text, txtPrenom.Text, txtNum.Text, txtEmail.Text);
                if (emCo.ModifyEmploye(nouvEmp))
                {
                    MessageBox.Show("Modification réussie ! ");
                }
                else
                {
                    MessageBox.Show("Modification échouée ! ");
                }
            }
        }
    }
}
