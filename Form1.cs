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
        public Form1()
        {
            InitializeComponent();
            emCo = new EmployeCo();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Employe emp = emCo.GetEmployeById(2);
            textBox1.Text = emp.getNom;
            List<Employe> lesEmp = emCo.GetEmployes();
            dataGridView1.DataSource = lesEmp;
        }
    }
}
