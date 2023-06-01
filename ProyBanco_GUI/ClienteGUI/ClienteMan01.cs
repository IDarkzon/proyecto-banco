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

namespace ProyBanco_GUI.ClienteGUI
{
    public partial class ClienteMan01 : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        DataView dtv;

        public ClienteMan01()
        {
            InitializeComponent();
        }

        private void ClienteMan01_Load(object sender, EventArgs e)
        {
            if (clsCredenciales.Nivel == 2)
            {
                btnNuevo.Visible = false;
                btnEditar.Visible = false;
            }

            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objClienteBL.ListarCliente());
            dtv.RowFilter = "Nombre like '%" + strFiltro + "%'";
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
                ClienteMan02 frmClienteMan = new ClienteMan02();
                frmClienteMan.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMan03 frmClienteMan = new ClienteMan03();
                frmClienteMan.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                frmClienteMan.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
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
