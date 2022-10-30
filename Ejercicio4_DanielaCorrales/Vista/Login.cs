using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CerrarSfButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void UsuarioSfButton_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese un código de usuario");
                UsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (ClaveTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(ClaveTextBox, "Ingrese una clave");
                ClaveTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos userDatos = new UsuarioDatos();

            bool valido = await userDatos.LoginAsync(UsuarioTextBox.Text, ClaveTextBox.Text);

            if (valido)
            {
               
                FormularioTwo formulario = new FormularioTwo();
                Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
