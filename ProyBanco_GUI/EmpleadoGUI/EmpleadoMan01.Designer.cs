namespace ProyBanco_GUI.EmpleadoGUI
{
    partial class EmpleadoMan01
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
            lblDatos = new Label();
            lblRegistros = new Label();
            txtFiltro = new TextBox();
            lblFiltro = new Label();
            dtgDatos = new DataGridView();
            btnEditar = new Button();
            btnNuevo = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDatos.BackColor = Color.White;
            lblDatos.BorderStyle = BorderStyle.FixedSingle;
            lblDatos.Location = new Point(721, 50);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(43, 23);
            lblDatos.TabIndex = 7;
            lblDatos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRegistros.BackColor = Color.DimGray;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.ForeColor = Color.White;
            lblRegistros.Location = new Point(656, 50);
            lblRegistros.Margin = new Padding(3, 0, 0, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(65, 23);
            lblRegistros.TabIndex = 6;
            lblRegistros.Text = "Registros:";
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(196, 50);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(200, 23);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // lblFiltro
            // 
            lblFiltro.BackColor = Color.DimGray;
            lblFiltro.BorderStyle = BorderStyle.FixedSingle;
            lblFiltro.ForeColor = Color.White;
            lblFiltro.Location = new Point(36, 50);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(163, 23);
            lblFiltro.TabIndex = 5;
            lblFiltro.Text = "Filtro de Datos por Nombre:";
            lblFiltro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Location = new Point(36, 93);
            dtgDatos.MultiSelect = false;
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(728, 279);
            dtgDatos.TabIndex = 1;
            dtgDatos.DoubleClick += dtgDatos_DoubleClick;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.Location = new Point(590, 394);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevo.Location = new Point(491, 394);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Location = new Point(689, 394);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // EmpleadoMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDatos);
            Controls.Add(lblRegistros);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(dtgDatos);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmpleadoMan01";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Información de Clientes";
            WindowState = FormWindowState.Maximized;
            Load += EmpleadoMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Label lblRegistros;
        private TextBox txtFiltro;
        private Label lblFiltro;
        private DataGridView dtgDatos;
        private Button btnEditar;
        private Button btnNuevo;
        private Button btnCerrar;
    }
}