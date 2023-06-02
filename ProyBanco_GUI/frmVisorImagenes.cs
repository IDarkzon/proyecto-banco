using ProyBanco_ADO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBanco_GUI
{
    public partial class frmVisorImagenes : Form
    {
        public frmVisorImagenes()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog objOpenFileDialog = new OpenFileDialog();
            objOpenFileDialog.Multiselect = true;
            objOpenFileDialog.Filter = "Ficheros de imagen (*.jpg)| " + txtFiltro.Text;
            objOpenFileDialog.ShowDialog();

            foreach (String file in objOpenFileDialog.FileNames)
            {
                Imagenes.Items.Add(file);
            }
        }

        private void Imagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pbFoto.Image = Image.FromFile(Imagenes.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede mostrar el archivo." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbFoto.Image = null;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Red;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Black;
        }

        private void frmVisorImagenes_Load(object sender, EventArgs e)
        {
            this.Height = 400;
            this.Width = 700;
        }
    }
}
