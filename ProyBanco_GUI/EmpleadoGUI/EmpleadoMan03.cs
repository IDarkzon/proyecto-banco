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

namespace ProyBanco_GUI.EmpleadoGUI
{
    public partial class EmpleadoMan03 : Form
    {
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        EmpleadoBE objEmpleadoBE_Temp = new EmpleadoBE();
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();

        public EmpleadoMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void EmpleadoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Mostrar datos del empleado
            objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(Codigo);
            objEmpleadoBE_Temp = objEmpleadoBL.ConsultarEmpleado(Codigo);

            lblCodigoIng.Text = objEmpleadoBE.Cod_Emp;
            txtNombre.Text = objEmpleadoBE.Nom_Emp;
            txtApellidoP.Text = objEmpleadoBE.Ape_pat_Emp;
            txtApellidoM.Text = objEmpleadoBE.Ape_mat_Emp;
            txtTelefono.Text = objEmpleadoBE.Tel_Emp;
            txtCorreo.Text = objEmpleadoBE.Cor_Emp;
            txtDocumento.Text = objEmpleadoBE.Num_doc_Emp;
            switch (objEmpleadoBE.Tip_doc_Emp)
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

            String Id_Ubigeo = objEmpleadoBE.Id_Ubigeo;
            CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));
            chkActivo.Checked = Convert.ToBoolean(objEmpleadoBE.Est_Emp);
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();

            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "ID_Departamento";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "ID_Provincia";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
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

            if (txtNombre.Text.Trim() != objEmpleadoBE_Temp.Nom_Emp ||
                    txtApellidoP.Text.Trim() != objEmpleadoBE_Temp.Ape_pat_Emp ||
                    txtApellidoM.Text.Trim() != objEmpleadoBE_Temp.Ape_mat_Emp ||
                    txtTelefono.Text.Trim() != objEmpleadoBE_Temp.Tel_Emp ||
                    txtCorreo.Text.Trim() != objEmpleadoBE_Temp.Cor_Emp ||
                    txtDocumento.Text.Trim() != objEmpleadoBE_Temp.Num_doc_Emp ||
                    tipoDocumento != objEmpleadoBE_Temp.Tip_doc_Emp ||
                    Id_Ubigeo != objEmpleadoBE_Temp.Id_Ubigeo ||
                    Convert.ToInt16(chkActivo.Checked) != objEmpleadoBE_Temp.Est_Emp) 
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

                if (pbFoto.Image == null)
                {
                    throw new Exception("La foto es obligatoria.");
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
                objEmpleadoBE.Nom_Emp = txtNombre.Text.Trim();
                objEmpleadoBE.Ape_pat_Emp = txtApellidoP.Text.Trim();
                objEmpleadoBE.Ape_mat_Emp = txtApellidoM.Text.Trim();
                objEmpleadoBE.Tel_Emp = txtTelefono.Text.Trim();
                objEmpleadoBE.Cor_Emp = txtCorreo.Text.Trim();
                objEmpleadoBE.Tip_doc_Emp = tipoDocumento;
                objEmpleadoBE.Num_doc_Emp = txtDocumento.Text.Trim();
                objEmpleadoBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString();
                objEmpleadoBE.Est_Emp = Convert.ToInt16(chkActivo.Checked);

                // Imagen
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                objEmpleadoBE.Img_Emp = ms.GetBuffer();


                // Auditoría
                objEmpleadoBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                // Enviamos los datos
                if (objEmpleadoBL.ActualizarEmpleado(objEmpleadoBE))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region Configuración estética

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Black;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Red;
        }

        #endregion

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog objOpenFileDialog = new OpenFileDialog();
                objOpenFileDialog.Filter = "Archivos de imagen (*.jpg, *.png) | *.jpg; *.png";
                if (objOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(objOpenFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
