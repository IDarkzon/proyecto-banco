using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyBanco_ADO;
// Otros...
using ProyBanco_BE;
using ProyBanco_BL;
using ProyBanco_GUI.ClienteGUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyBanco_GUI.CuentaGUI
{
    public partial class CuentaMan02 : Form
    {
        CuentaBE objCuentaBE = new CuentaBE();
        CuentaBL objCuentaBL = new CuentaBL();
        ClienteBE objClienteBE = new ClienteBE();
        ClienteBL objClienteBL = new ClienteBL();
        AgenciaBL objAgenciaBL = new AgenciaBL();

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
            try
            {   
                cboAgencia.DataSource = objAgenciaBL.ListarAgencia();
                cboAgencia.ValueMember = "Codigo Agencia";
                cboAgencia.DisplayMember = "Codigo Agencia";
                cboAgencia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (txtCodCli.Text.Trim() == String.Empty)
                {
                    throw new Exception("El DNI del cliente es obligatorio.");
                }

                if (txtCodCli.Text.Trim().Length < 8 || txtCodCli.Text.Trim().Length > 8)
                {
                    throw new Exception("El DNI del Cliente debe tener 8 Caracteres.");
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

                objClienteBE = objClienteBL.ConsultarClienteDNI(txtCodCli.Text.Trim());

                if (objClienteBE.Num_doc_Cli == null)
                {
                    DialogResult vrpta;
                    vrpta = MessageBox.Show("El DNI del cliente no existe, ¿Quiere ingresarlo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vrpta == DialogResult.Yes)
                    {
                        ClienteMan02 frmClienteMan = new ClienteMan02(txtCodCli.Text.Trim());
                        frmClienteMan.ShowDialog();

                        return;
                    } else
                    {
                        return;
                    }
                }

                //Insertamos
                objCuentaBE.Cod_Age = cboAgencia.SelectedValue.ToString();
                objCuentaBE.Cod_Cli = objClienteBE.Cod_Cli;
                objCuentaBE.Est_Cuen = Convert.ToInt16(chkActivo.Checked);

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
