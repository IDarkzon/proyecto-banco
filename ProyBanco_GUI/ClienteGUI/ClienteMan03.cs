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

namespace ProyBanco_GUI.ClienteGUI
{
    public partial class ClienteMan03 : Form
    {
        ClienteBE objClienteBE = new ClienteBE();
        ClienteBE objClienteBE_Temp = new ClienteBE();
        ClienteBL objClienteBL = new ClienteBL();

        public ClienteMan03()
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

        private void ClienteMan03_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            dtpAnioNacimiento.MaxDate = DateTime.Now.AddDays(1);

            // Mostrar Cliente a Actualizar
            objClienteBE = objClienteBL.ConsultarCliente(Codigo);
            objClienteBE_Temp = objClienteBL.ConsultarCliente(Codigo);

            lblCodigoIng.Text = objClienteBE.Cod_Cli;
            txtNombre.Text = objClienteBE.Nom_Cli;
            txtApellidoP.Text = objClienteBE.Ape_pat_Cli;
            txtApellidoM.Text = objClienteBE.Ape_mat_Cli;
            txtTelefono.Text = objClienteBE.Tel_Cli;
            txtCorreo.Text = objClienteBE.Cor_Cli;
            txtDireccion.Text = objClienteBE.Dir_Cli;
            switch (objClienteBE.Tip_doc_Cli)
            {
                case 1:
                    optDNI.Checked = true;
                    break;
                case 2:
                    optCarnet.Checked = true;
                    break;
                case 3:
                    optPasaporte.Checked = true;
                    break;
            }
            dtpAnioNacimiento.Value = objClienteBE.Fec_nac_Cli;
            txtDocumento.Text = objClienteBE.Num_doc_Cli;
            String Id_Ubigeo = objClienteBE.Id_Ubigeo;
            CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));
            chkActivo.Checked = Convert.ToBoolean(objClienteBE.Est_Cli);
        }

        private void CargarUbigeo(String IdDep, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();

            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "ID_Departamento";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDep;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDep);
            cboProvincia.ValueMember = "ID_Provincia";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDep, IdProv);
            cboDistrito.ValueMember = "ID_Distrito";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;
        }

        private void DetectarNumeros(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false)
                {
                    e.Handled = true;
                }
            }
        }

        private void DetectarDocumento(object sender, EventArgs e)
        {
            if (optDNI.Checked)
            {
                txtDocumento.MaxLength = 8;
            }
            else
            {
                txtDocumento.MaxLength = 12;
            }
        }

        // Función para verificar el patrón de correo
        private bool VerificarCorreo(String strCorreo)
        {
            // Patrón de expresión regular para validar el formato del correo electrónico
            string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Verificar si el correo electrónico coincide con el patrón
            bool esValido = Regex.IsMatch(strCorreo, patron);

            return esValido;
        }

        // Función que evita que se hagan falsas modificaciones
        private bool VerificarCambios(Int16 tipoDocumento)
        {
            String Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                    cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();

            if (txtNombre.Text.Trim() != objClienteBE_Temp.Nom_Cli ||
                txtApellidoP.Text.Trim() != objClienteBE_Temp.Ape_pat_Cli ||
                txtApellidoM.Text.Trim() != objClienteBE_Temp.Ape_mat_Cli ||
                txtTelefono.Text.Trim() != objClienteBE_Temp.Tel_Cli ||
                txtCorreo.Text.Trim() != objClienteBE_Temp.Cor_Cli ||
                txtDireccion.Text.Trim() != objClienteBE_Temp.Dir_Cli ||
                tipoDocumento != objClienteBE_Temp.Tip_doc_Cli ||
                dtpAnioNacimiento.Value != objClienteBE_Temp.Fec_nac_Cli ||
                txtDocumento.Text.Trim() != objClienteBE_Temp.Num_doc_Cli ||
                Id_Ubigeo != objClienteBE_Temp.Id_Ubigeo ||
                Convert.ToInt16(chkActivo.Checked) != objClienteBE_Temp.Est_Cli)
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
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre es olbigatorio.");
                }

                if (txtApellidoP.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido paterno es obligatorio.");
                }

                if (txtApellidoM.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido materno es obligatorio.");
                }

                if (txtTelefono.Text.Trim() == String.Empty)
                {
                    throw new Exception("El número de telefono es obligatorio.");
                }

                if (txtTelefono.Text.Trim().Length < 9)
                {
                    throw new Exception("El número de telefono debe tener 9 digitos.");
                }

                if (txtCorreo.Text.Trim() == String.Empty)
                {
                    throw new Exception("La dirección de correo es obligatoria.");
                }

                if (!VerificarCorreo(txtCorreo.Text.Trim()))
                {
                    throw new Exception("La dirección de correo es errónea.");
                }

                if (txtDireccion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La dirección es obligatoria.");
                }

                if (dtpAnioNacimiento.Value > DateTime.Now.AddYears(-18))
                {
                    throw new Exception("El cliente debe ser mayor a 18 años.");
                }

                if (txtDocumento.Text.Trim() == String.Empty)
                {
                    throw new Exception("El número de documento es obligatorio.");
                }

                if (optDNI.Checked && txtDocumento.Text.Length < 8)
                {
                    throw new Exception("El número de DNI debe tener 8 dígitos.");
                }

                if (optDNI.Checked && txtDocumento.Text.Length > 8)
                {
                    // Por si acaso
                    throw new Exception("El número de DNI solo puede tener 8 dígitos.");
                }

                if ((optCarnet.Checked || optPasaporte.Checked) && txtDocumento.Text.Length < 12)
                {
                    throw new Exception("El Carnet de Extranjería o Pasaporte debe tener 12 dígitos.");
                }

                // Definición
                Int16 tipoDocumento;
                if (optDNI.Checked)
                {
                    tipoDocumento = 1;
                }
                else if (optCarnet.Checked)
                {
                    tipoDocumento = 2;
                }
                else
                {
                    tipoDocumento = 3;
                }

                if (VerificarCambios(tipoDocumento))
                {
                    throw new Exception("No se ha hecho ningún cambio.");
                }

                // Insertamos
                objClienteBE.Nom_Cli = txtNombre.Text.Trim();
                objClienteBE.Ape_pat_Cli = txtApellidoP.Text.Trim();
                objClienteBE.Ape_mat_Cli = txtApellidoM.Text.Trim();
                objClienteBE.Tel_Cli = txtTelefono.Text.Trim();
                objClienteBE.Cor_Cli = txtCorreo.Text.Trim();
                objClienteBE.Dir_Cli = txtDireccion.Text.Trim();
                objClienteBE.Tip_doc_Cli = tipoDocumento;
                objClienteBE.Fec_nac_Cli = dtpAnioNacimiento.Value;
                objClienteBE.Num_doc_Cli = txtDocumento.Text.Trim();
                objClienteBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                    cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();
                objClienteBE.Est_Cli = Convert.ToInt16(chkActivo.Checked);

                objClienteBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                // Enviamos los datos...
                if (objClienteBL.ActualizarCliente(objClienteBE))
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

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}