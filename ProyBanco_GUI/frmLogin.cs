using ProyBanco_BE;
using ProyBanco_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyBanco_GUI
{
    public partial class frmLogin : Form
    {
        int intentos = 0; // Cantidad de Intentos Fallidos
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Si hacemos click en el botón de salida
            Application.Exit();
        }

        #region Configuración estética
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Red;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Black;
        }

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.FlatAppearance.BorderColor = Color.Red;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.FlatAppearance.BorderColor = Color.Black;
        }
        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != String.Empty && txtContrasena.Text.Trim() != String.Empty)
            {
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtUsuario.Text.Trim());

                if (objUsuarioBE.Login_Usuario == null)
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos++;
                    ValidarAcceso();
                }
                else if (objUsuarioBE.Login_Usuario == txtUsuario.Text.Trim() && objUsuarioBE.Pass_Usuario == txtContrasena.Text.Trim())
                {
                    this.Hide(); // Ocultamos el Login
                    clsCredenciales.Usuario = objUsuarioBE.Login_Usuario;
                    clsCredenciales.Password = objUsuarioBE.Pass_Usuario;
                    clsCredenciales.Nivel = objUsuarioBE.Niv_Usuario;

                    MDIPrincipal objMDI = new MDIPrincipal();
                    objMDI.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos++;
                ValidarAcceso();
            }
        }

        private void ValidarAcceso()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos, sobrepasó el número de intentos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnSalir.PerformClick();
            }
        }
    }
}
