using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
// Otros...
using ProyBanco_BE;
using ProyBanco_BL;

namespace ProyBanco_GUI.CuentaGUI
{
    public partial class CuentaMan02 : Form
    {
        CuentaBE objCuentaBE = new CuentaBE();
        CuentaBL objCuentaBL = new CuentaBL();

        public CuentaMan02()
        {
            InitializeComponent();
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
        #endregion

        private void CuentaMan02_Load(object sender, EventArgs e)
        {

            //dtpFechaApertura.MaxDate = DateTime.Now.AddDays(1);
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (txtCodCli.Text.Trim() == String.Empty)
                {
                    throw new Exception("El Código del cliente es obligatorio.");
                }

                if (txtCodCli.Text.Trim().Length < 4 || txtCodCli.Text.Trim().Length > 4)
                {
                    throw new Exception("El Código del Cliente debe tener 4 Caracteres.");
                }

                if (txtCodAge.Text.Trim() == String.Empty)
                {
                    throw new Exception("El Código de la Agencia es obligatorio.");
                }

                if (txtCodAge.Text.Trim().Length < 4 || txtCodAge.Text.Trim().Length > 4)
                {
                    throw new Exception("El Código de la Agencia debe tener 4 Caracteres.");
                }

                // Definición
                Int16 tipoMoneda;
                if (optSoles.Checked)
                {
                    tipoMoneda = 1;
                }
                else
                {
                    tipoMoneda = 2;
                }

                Int16 tipoCuenta;
                if (optCorriente.Checked)
                {
                    tipoCuenta = 1;
                }
                else
                {
                    tipoCuenta = 2;
                }



                // Insertamos
                objCuentaBE.Tip_Mon = tipoMoneda;
                objCuentaBE.Sal_Cuen = Convert.ToSingle(mskSaldo.Text.Trim());
                objCuentaBE.Tipo = tipoCuenta;
                objCuentaBE.Fec_Aper = DateTime.Today;
                objCuentaBE.Cod_Cli = txtCodCli.Text.Trim();
                objCuentaBE.Cod_Age = txtCodAge.Text.Trim();
                objCuentaBE.Est_Cuen = Convert.ToInt16(chkActivo.Checked); ;

                objCuentaBE.Usu_Registro = clsCredenciales.Usuario;

                // Enviamos los datos...
                if (objCuentaBL.InsertarCuenta(objCuentaBE))
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se insertó el registro, contacte con TI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
