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
    public partial class ConsFidele : Form
    {
        private FideleCo fidCo;
        private int idSelect;
        public ConsFidele()
        {
            InitializeComponent();
            fidCo = new FideleCo();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                Fidele unEmp = fidCo.GetFideleById(int.Parse(txtId.Text));
                if (unEmp.Id != 0)
                {
                    MessageBox.Show("Nom : " + unEmp.Nom + "\nPrénom : " + unEmp.Prenom + "\nDate de naissance : " + unEmp.DateNaissance);
                }
                else
                {
                    MessageBox.Show("Client introuvable");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Impossible de chercher ce client, erreur : " + exc.Message);
            }
        }

        private void ConsFidele_Load(object sender, EventArgs e)
        {
            List<Fidele> fideles = fidCo.GetFideles();
            dataGridView1.DataSource = fideles;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var FormEmp = new Form1();
            this.Hide();
            FormEmp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((idSelect) != 0)
            {
                var FormEmp = new ModFidele(idSelect);
                this.Hide();
                FormEmp.ShowDialog();
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            var FormEmp = new AjoutFidele();
            this.Hide();
            FormEmp.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelect = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
