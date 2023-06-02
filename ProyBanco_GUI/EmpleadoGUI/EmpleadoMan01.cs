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

namespace ProyBanco_GUI.EmpleadoGUI
{
    public partial class EmpleadoMan01 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        DataView dtv;

        public EmpleadoMan01()
        {
            InitializeComponent();
        }

        private void EmpleadoMan01_Load(object sender, EventArgs e)
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
            dtv = new DataView(objEmpleadoBL.ListarEmpleado());
            dtv.RowFilter = "Nombre LIKE '%" + strFiltro + "%'";
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
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoMan02 frmEmpleadoMan = new EmpleadoMan02();
                frmEmpleadoMan.ShowDialog();

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
                EmpleadoMan03 frmEmpleadoMan = new EmpleadoMan03();
                frmEmpleadoMan.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                frmEmpleadoMan.ShowDialog();

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
