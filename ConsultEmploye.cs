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
    public partial class ConsultEmploye : Form
    {
        EmployeCo emCo;
        int idSelect = 0;
        public ConsultEmploye()
        {
            InitializeComponent();
            emCo = new EmployeCo();
        }

        private void ConsultEmploye_Load(object sender, EventArgs e)
        {
            List<Employe> lesEmployes = emCo.GetEmployes();
            dataGridView1.DataSource = lesEmployes;
            dataGridView1.Columns[0].HeaderText = "Identifiant";
            dataGridView1.Columns[1].HeaderText = "Nom";
            dataGridView1.Columns[2].HeaderText = "Prenom";
            dataGridView1.Columns[3].HeaderText = "Numéro de téléphone";
            dataGridView1.Columns[4].HeaderText = "Adresse email";
            dataGridView1.Columns[5].HeaderText = "Poste occupé";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelect = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void ConsultEmploye_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((idSelect) != 0)
            {
                var FormEmp = new ModEmploye(idSelect);
                this.Hide();
                FormEmp.ShowDialog();
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                Employe unEmp = emCo.GetEmployeById(int.Parse(txtId.Text));
                if (unEmp.getId != 0)
                {
                    MessageBox.Show("Nom : " + unEmp.getNom + "\nPrénom : " + unEmp.getPrenom + "\nNuméro de téléphone : " + unEmp.getTel + "\nAdresse Email : " + unEmp.getEmail + "\nPoste occupé : " + unEmp.getPosteLibelle);
                }
                else
                {
                    MessageBox.Show("Employé introuvable");
                }
            }catch(Exception exc)
            {
                MessageBox.Show("Impossible de chercher cet employé, erreur : " + exc.Message);
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            var FormEmp = new AjoutEmploye();
            this.Hide();
            FormEmp.ShowDialog();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
