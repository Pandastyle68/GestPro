using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GestPro;

namespace GestPro
{
    public partial class Form1 : Form
    {
        EmployeCo emCo;
        ProduitCo proCo;
        FournisseurCo fourCo;
        PosteCo posCo;
        CommandeCo comCo;
        FideleCo FidCo;
        public Form1()
        {
            InitializeComponent();
            emCo = new EmployeCo();
            proCo = new ProduitCo();
            fourCo = new FournisseurCo();
            posCo = new PosteCo();
            comCo = new CommandeCo();
            FidCo = new FideleCo();
    }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConsultEmp = new ConsultEmploye();
            ConsultEmp.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConsProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConsultEmp = new ConsProd();
            ConsultEmp.ShowDialog();
        }

        private void btnConsCom_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConsultEmp = new ConsCommande();
            ConsultEmp.ShowDialog();
        }

        private void btnConsPostes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConsultEmp = new ConsPoste();
            ConsultEmp.ShowDialog();
        }

        private void btnConsFid_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConsultEmp = new ConsFidele();
            ConsultEmp.ShowDialog();
        }

        private void btnConsFour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConsultEmp = new ConsFourn();
            ConsultEmp.ShowDialog();
        }
    }
}
