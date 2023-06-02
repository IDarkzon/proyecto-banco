namespace ProyBanco_GUI
{
    partial class frmVisorImagenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFiltro = new TextBox();
            btnFile = new Button();
            pbFoto = new PictureBox();
            Imagenes = new ListBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 49);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el patrón de filtro:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(225, 46);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(62, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.Tag = "";
            txtFiltro.Text = "*.*";
            txtFiltro.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFile
            // 
            btnFile.Location = new Point(436, 39);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(160, 35);
            btnFile.TabIndex = 2;
            btnFile.Text = "Seleccionar Archivos";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.Click += btnFile_Click;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(48, 99);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(275, 255);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 3;
            pbFoto.TabStop = false;
            // 
            // Imagenes
            // 
            Imagenes.FormattingEnabled = true;
            Imagenes.ItemHeight = 15;
            Imagenes.Location = new Point(361, 99);
            Imagenes.Name = "Imagenes";
            Imagenes.Size = new Size(285, 259);
            Imagenes.TabIndex = 4;
            Imagenes.SelectedIndexChanged += Imagenes_SelectedIndexChanged;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = true;
            btnSalir.BackColor = Color.Transparent;
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(640, 14);
            btnSalir.Margin = new Padding(0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(42, 39);
            btnSalir.TabIndex = 57;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseEnter += btnSalir_MouseEnter;
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            // 
            // frmVisorImagenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(Imagenes);
            Controls.Add(pbFoto);
            Controls.Add(btnFile);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVisorImagenes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visor Imágenes";
            Load += frmVisorImagenes_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private Button btnFile;
        private PictureBox pbFoto;
        private ListBox Imagenes;
        private Button btnSalir;
    }
}