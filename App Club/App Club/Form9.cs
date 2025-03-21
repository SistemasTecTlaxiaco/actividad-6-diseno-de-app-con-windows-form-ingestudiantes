using System;
using System.Windows.Forms;
using ValidacionesITTL;

namespace App_Club
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEnviar_f9_Click(object sender, EventArgs e)
        {
            // Validar los datos antes de continuar
            bool datosCorrectos = ValidarDatos();
            if (datosCorrectos)
            {
                // Mostrar cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Los datos son correctos?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Si el usuario confirma, abrir el siguiente formulario
                    Form formulario = new Form10();
                    formulario.Show();
                }
                else
                {
                    // Enfocar el primer TextBox si el usuario dice que no
                    textBox1.Focus();
                }
            }
        }

        private void btnCancelar_f9_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Lógica para el TextBox2 (si es necesario)
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Lógica para GroupBox (si es necesario)
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Lógica para el RadioButton2 (si es necesario)
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Lógica para el RadioButton3 (si es necesario)
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // Lógica para el RadioButton4 (si es necesario)
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            // Lógica para el RadioButton5 (si es necesario)
        }

        private bool ValidarDatos()
        {
            // Validar TextBoxes usando la librería
            if (!Validador.ValidarCampoVacio(textBox1, "Nombre")) return false;
            if (!Validador.ValidarCampoVacio(textBox2, "No. Control")) return false;
            if (!Validador.ValidarCampoVacio(textBox3, "Carrera")) return false;

            // Validar RadioButtons usando la librería
            if (!Validador.ValidarRadioButton(radioButton1, radioButton2, radioButton3, radioButton4, radioButton5))
            {
                MessageBox.Show("Debes seleccionar una opción del Menu de Clubes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
