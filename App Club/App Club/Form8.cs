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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_F8_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9();
            formulario.Show();
        }

        private void btnRegistrrse_f8_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9();
            formulario.Show();
        }
    }
}
