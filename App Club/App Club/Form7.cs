using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Club
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_f7_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }

        private void btnRegistrarse_f7_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9();
            formulario.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
