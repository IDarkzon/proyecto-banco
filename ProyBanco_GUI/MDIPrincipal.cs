using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBanco_GUI
{
    public partial class MDIPrincipal : Form
    {
        TimeSpan horaEntrada = new TimeSpan();
        Computer miEquipo = new Computer();

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Texto del Form
            this.Text = "Banco Nación - Pantalla Principal | " + DateTime.Now.ToString();

            // Mostramos tiempo de uso de la Aplicación
            lblTiempo.Text = "Tiempo: " + DateTime.Now.TimeOfDay.Subtract(horaEntrada).ToString().Substring(0, 8);
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // Información del Equipo
                if (miEquipo.Network.IsAvailable == true)
                {
                    lblRed.Text = "Conectado";
                    lblRed.ForeColor = Color.Lime;
                }
                else
                {
                    lblRed.Text = "Desconectado";
                    lblRed.ForeColor = Color.Red;
                }

                // Información del Usuario
                lblEquipo.Text = "Usuario: " + clsCredenciales.Usuario + " | Estado:";

                // Registramos la hora de ingreso
                horaEntrada = DateTime.Now.TimeOfDay;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is ClienteGUI.ClienteMan01);

            if (frm != null)
            {
                frm.BringToFront();
                return;
            }

            ClienteGUI.ClienteMan01 frmClienteMan = new ClienteGUI.ClienteMan01();
            frmClienteMan.MdiParent = this;
            frmClienteMan.Show();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("¿Estás seguro de que quieres salir del Programa?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Timer.Enabled = false;
            Application.Exit();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is EmpleadoGUI.EmpleadoMan01);

            if (frm != null)
            {
                frm.BringToFront();
                return;
            }

            EmpleadoGUI.EmpleadoMan01 frmEmpleadoMan = new EmpleadoGUI.EmpleadoMan01();
            frmEmpleadoMan.MdiParent = this;
            frmEmpleadoMan.Show();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is CuentaGUI.CuentaMan01);

            if (frm != null)
            {
                frm.BringToFront();
                return;
            }

            CuentaGUI.CuentaMan01 frmCuentaMan = new CuentaGUI.CuentaMan01();
            frmCuentaMan.MdiParent = this;
            frmCuentaMan.Show();
        }

        private void visorFotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is ProyBanco_GUI.frmVisorImagenes);

            if (frm != null)
            {
                frm.BringToFront();
                return;
            }

            // Cerrar los otros formularios
            foreach (Form frmHijo in this.MdiChildren)
            {
                if (frmHijo.Name != "frmVisorImagenes")
                {
                    frmHijo.Close();
                }
            }

            ProyBanco_GUI.frmVisorImagenes frmVisorImagenes = new ProyBanco_GUI.frmVisorImagenes();
            frmVisorImagenes.MdiParent = this;
            frmVisorImagenes.Show();
        }
    }
}
