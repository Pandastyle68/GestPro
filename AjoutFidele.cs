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
    public partial class AjoutFidele : Form
    {
        private FideleCo fidCo;
        public AjoutFidele()
        {
            InitializeComponent();
            fidCo = new FideleCo();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "")
            {
                Fidele nouvEmp = new Fidele(0, txtNom.Text, txtPrenom.Text, dateTimePicker1.Value);
                if (fidCo.AddFidele(nouvEmp))
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
            this.Hide();
            Form form = new ConsFidele();
            form.ShowDialog();
        }
    }
}
