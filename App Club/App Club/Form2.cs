using System;
using System.Windows.Forms;
using ValidacionesITTL;

namespace App_Club
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btninisiarform2_Click(object sender, EventArgs e)
        {
            // Validar los datos antes de continuar
            if (Validador.ValidarCampoVacio(txt1form2, "No. Control") &&
            Validador.ValidarCampoVacio(txt2form2, "Contraseña") &&
            Validador.ValidarCredenciales(txt1form2.Text, txt2form2.Text))
            {
                Form3 formulario = new Form3();
                formulario.Show();
                this.Hide();
            }
        }



        private void btnregresarFo2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
        }

        private void txt1form2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2form2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form formul = new Form1();
            formul.Show();
        }
    }
}
