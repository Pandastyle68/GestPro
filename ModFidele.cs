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
    public partial class ModFidele : Form
    {
        private int fideleId;
        private FideleCo fidCo;
        public ModFidele(int id)
        {
            InitializeComponent();
            fideleId = id;
            fidCo = new FideleCo();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "")
            {
                Fidele nouvEmp = new Fidele(fideleId, txtNom.Text, txtPrenom.Text, dateTimePicker1.Value);
                if (fidCo.ModifyFidele(nouvEmp))
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
            this.Hide();
            Form form = new ConsFidele();
            form.ShowDialog();
        }

        private void ModFidele_Load(object sender, EventArgs e)
        {
            txtNom.Text = fidCo.GetFideleById(fideleId).Nom;
            txtPrenom.Text = fidCo.GetFideleById(fideleId).Prenom;
            dateTimePicker1.Value = fidCo.GetFideleById(fideleId).DateNaissance;
        }
    }
}
