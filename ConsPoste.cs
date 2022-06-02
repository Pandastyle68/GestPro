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
    public partial class ConsPoste : Form
    {
        private PosteCo posCo;
        public ConsPoste()
        {
            InitializeComponent();
            posCo = new PosteCo();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Form1();
            Form.ShowDialog();
        }

        private void ConsPoste_Load(object sender, EventArgs e)
        {
            List<Poste> postes = posCo.GetPostes();
            dataGridView1.DataSource = postes;
        }

        private void ConsPoste_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
