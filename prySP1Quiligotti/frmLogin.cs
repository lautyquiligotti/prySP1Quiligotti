using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP1Quiligotti
{
    public partial class frmLogin : Form
    {
        int intentos = 0; // Contador de intentos
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ( ((txtUsuario.Text == "Adm" && txtContraseña.Text == "@1a") && (cboModulo.Text == "ADM" || cboModulo.Text == "COM" || cboModulo.Text == "VTA"))
                || (txtUsuario.Text == "John" && txtContraseña.Text == "*2b" && cboModulo.Text == "SIST")
                || ((txtUsuario.Text == "Ceci" && txtContraseña.Text == "*@3c") && (cboModulo.Text == "ADM" || cboModulo.Text == "VTA")) 
                || (txtUsuario.Text == "God" && txtContraseña.Text == "*@#4d"))
            {
                this.Hide(); // Oculta este formulario
                frmInicio f = new frmInicio(); // Crea el frmInicio
                f.Text = txtUsuario.Text; // Asigna el texto de titulo
                f.ShowDialog(); // Ejecuta y visualiza el frmInicio
                this.Show(); // Muestra otra vez este formulario
                intentos = 0;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.");
                intentos++; // Incrementa el contador de intentos fallidos
                if ( intentos == 2 ) //Si llega a 3, se cierra el frm
                {
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblModulo_Click(object sender, EventArgs e)
        {

        }
    }
}
