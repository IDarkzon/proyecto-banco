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
    public partial class CuentaMan03 : Form
    {
        CuentaBE objCuentaBE = new CuentaBE();
        CuentaBE objCuentaBE_temp = new CuentaBE();
        CuentaBL objCuentaBL = new CuentaBL();

        public CuentaMan03()
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

        public String Codigo { get; set; }

        private void CuentaMan03_Load(object sender, EventArgs e)
        {

            //dtpFechaApertura.MaxDate = DateTime.Now.AddDays(1);

            // Mostrar Cuenta a Actualizar
            objCuentaBE = objCuentaBL.ConsultarCuenta(Codigo);
            objCuentaBE_temp = objCuentaBL.ConsultarCuenta(Codigo);

            lblNumCuenIng.Text = objCuentaBE.Num_Cuen;
            txtCodCli.Text = objCuentaBE.Cod_Cli;
            txtCodAge.Text = objCuentaBE.Cod_Age;
            mskSaldo.Text = Convert.ToString(objCuentaBE.Sal_Cuen);

            switch (objCuentaBE.Tip_Mon)
            {
                case 1:
                    optSoles.Checked = true;
                    break;
                case 2:
                    optDolares.Checked = true;
                    break;
            }

            switch (objCuentaBE.Tipo)
            {
                case 1:
                    optCorriente.Checked = true;
                    break;
                case 2:
                    optAhorro.Checked = true;
                    break;
            }



            chkActivo.Checked = Convert.ToBoolean(objCuentaBE.Est_Cuen);
        }


        // Función que evita que se hagan falsas modificaciones
        private bool VerificarCambios(Int16 tipoMoneda, Int16 tipo)
        {

            if (txtCodCli.Text.Trim() != objCuentaBE_temp.Cod_Cli ||
                txtCodAge.Text.Trim() != objCuentaBE_temp.Cod_Age ||
                Convert.ToString(mskSaldo.Text.Trim()) != Convert.ToString(objCuentaBE_temp.Sal_Cuen) ||
                tipoMoneda != objCuentaBE_temp.Tip_Mon ||
                tipo != objCuentaBE_temp.Tipo ||
                Convert.ToInt16(chkActivo.Checked) != objCuentaBE_temp.Est_Cuen)
            {
                // Hay cambios
                return false;
            }

            // No hay cambios
            return true;
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

                if (VerificarCambios(tipoMoneda, tipoCuenta))
                {
                    throw new Exception("No se ha hecho ningún cambio.");
                }

                // Insertamos
                objCuentaBE.Tip_Mon = tipoMoneda;
                objCuentaBE.Sal_Cuen = Convert.ToSingle(mskSaldo.Text.Trim());
                objCuentaBE.Tipo = tipoCuenta;
                objCuentaBE.Cod_Cli = txtCodCli.Text.Trim();
                objCuentaBE.Cod_Age = txtCodAge.Text.Trim();
                objCuentaBE.Est_Cuen = Convert.ToInt16(chkActivo.Checked); ;

                objCuentaBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                // Enviamos los datos...
                if (objCuentaBL.ActualizarCuenta(objCuentaBE))
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizó el registro, contacte con TI.");
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