using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Otros...
using ProyBanco_BL;

namespace ProyBanco_GUI.CuentaGUI
{
    public partial class CuentaMan01 : Form
    {
        CuentaBL objCuentaBL = new CuentaBL();
        DataView dtv;

        public CuentaMan01()
        {
            InitializeComponent();
        }

        private void CuentaMan01_Load(object sender, EventArgs e)
        {
            if (clsCredenciales.Nivel == 2)
            {
                btnNuevo.Visible = false;
                btnEditar.Visible = false;
            }

            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(string strFiltro)
        {
            dtv = new DataView(objCuentaBL.ListarCuenta());
            dtv.RowFilter = "[Nombre Cliente] like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblDatos.Text = dtgDatos.Rows.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                CuentaMan02 frmCuentaMan = new CuentaMan02();
                frmCuentaMan.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CuentaMan03 frmCuentaMan = new CuentaMan03();
                frmCuentaMan.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                frmCuentaMan.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtgDatos_DoubleClick(object sender, EventArgs e)
        {
            btnEditar.PerformClick();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
