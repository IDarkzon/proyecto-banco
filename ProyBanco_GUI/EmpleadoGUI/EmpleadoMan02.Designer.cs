namespace ProyBanco_GUI.EmpleadoGUI
{
    partial class EmpleadoMan02
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
            btnSalir = new Button();
            lblTitulo = new Label();
            chkActivo = new CheckBox();
            cboDepartamento = new ComboBox();
            cboProvincia = new ComboBox();
            cboDistrito = new ComboBox();
            lblDistrito = new Label();
            lblDepartamento = new Label();
            lblProvincia = new Label();
            txtDocumento = new TextBox();
            groupBox1 = new GroupBox();
            optPasaporte = new RadioButton();
            optCarnet = new RadioButton();
            optDNI = new RadioButton();
            btnGuardar = new Button();
            btnCerrar = new Button();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            lblTelefono = new Label();
            txtApellidoM = new TextBox();
            lblApellidoM = new Label();
            txtApellidoP = new TextBox();
            lblApellidoP = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblDocumento = new Label();
            pbFoto = new PictureBox();
            btnFoto = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
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
            btnSalir.Location = new Point(724, 30);
            btnSalir.Margin = new Padding(0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(42, 39);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnCerrar_Click;
            btnSalir.MouseEnter += btnSalir_MouseEnter;
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(34, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(181, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Empleado";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(36, 350);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 21;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(37, 307);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(225, 23);
            cboDepartamento.TabIndex = 16;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(281, 307);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(225, 23);
            cboProvincia.TabIndex = 18;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(527, 307);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(225, 23);
            cboDistrito.TabIndex = 20;
            // 
            // lblDistrito
            // 
            lblDistrito.AutoSize = true;
            lblDistrito.Location = new Point(527, 289);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.Size = new Size(48, 15);
            lblDistrito.TabIndex = 19;
            lblDistrito.Text = "Distrito:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(34, 289);
            lblDepartamento.Margin = new Padding(3, 0, 3, 3);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(86, 15);
            lblDepartamento.TabIndex = 15;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(281, 289);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(59, 15);
            lblProvincia.TabIndex = 17;
            lblProvincia.Text = "Provincia:";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(112, 245);
            txtDocumento.MaxLength = 8;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "Ingrese el Documento";
            txtDocumento.Size = new Size(150, 23);
            txtDocumento.TabIndex = 12;
            txtDocumento.KeyPress += DetectarNumeros;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optPasaporte);
            groupBox1.Controls.Add(optCarnet);
            groupBox1.Controls.Add(optDNI);
            groupBox1.Location = new Point(281, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 117);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Documento";
            // 
            // optPasaporte
            // 
            optPasaporte.AutoSize = true;
            optPasaporte.Location = new Point(46, 79);
            optPasaporte.Name = "optPasaporte";
            optPasaporte.Size = new Size(77, 19);
            optPasaporte.TabIndex = 2;
            optPasaporte.Text = "Pasaporte";
            optPasaporte.UseVisualStyleBackColor = true;
            optPasaporte.CheckedChanged += DetectarDocumento;
            // 
            // optCarnet
            // 
            optCarnet.AutoSize = true;
            optCarnet.Location = new Point(46, 54);
            optCarnet.Name = "optCarnet";
            optCarnet.Size = new Size(134, 19);
            optCarnet.TabIndex = 1;
            optCarnet.Text = "Carnet de Extranjería";
            optCarnet.UseVisualStyleBackColor = true;
            optCarnet.CheckedChanged += DetectarDocumento;
            // 
            // optDNI
            // 
            optDNI.AutoSize = true;
            optDNI.Checked = true;
            optDNI.Location = new Point(46, 29);
            optDNI.Name = "optDNI";
            optDNI.Size = new Size(45, 19);
            optDNI.TabIndex = 0;
            optDNI.TabStop = true;
            optDNI.Text = "DNI";
            optDNI.UseVisualStyleBackColor = true;
            optDNI.CheckedChanged += DetectarDocumento;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(573, 397);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(677, 397);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 23;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(112, 195);
            txtCorreo.MaxLength = 50;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese el Correo";
            txtCorreo.Size = new Size(150, 23);
            txtCorreo.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(112, 151);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese el Teléfono";
            txtTelefono.Size = new Size(150, 23);
            txtTelefono.TabIndex = 8;
            txtTelefono.KeyPress += DetectarNumeros;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(34, 198);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(46, 15);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(34, 154);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtApellidoM
            // 
            txtApellidoM.Location = new Point(526, 96);
            txtApellidoM.MaxLength = 20;
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.PlaceholderText = "Ingrese el Apellido Materno";
            txtApellidoM.Size = new Size(226, 23);
            txtApellidoM.TabIndex = 6;
            // 
            // lblApellidoM
            // 
            lblApellidoM.AutoSize = true;
            lblApellidoM.Location = new Point(525, 78);
            lblApellidoM.Name = "lblApellidoM";
            lblApellidoM.Size = new Size(102, 15);
            lblApellidoM.TabIndex = 5;
            lblApellidoM.Text = "Apellido Materno:";
            // 
            // txtApellidoP
            // 
            txtApellidoP.Location = new Point(281, 96);
            txtApellidoP.MaxLength = 20;
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.PlaceholderText = "Ingrese el Apellido Paterno";
            txtApellidoP.Size = new Size(226, 23);
            txtApellidoP.TabIndex = 4;
            // 
            // lblApellidoP
            // 
            lblApellidoP.AutoSize = true;
            lblApellidoP.Location = new Point(281, 78);
            lblApellidoP.Name = "lblApellidoP";
            lblApellidoP.Size = new Size(98, 15);
            lblApellidoP.TabIndex = 3;
            lblApellidoP.Text = "Apellido Paterno:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 96);
            txtNombre.MaxLength = 40;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el Nombre";
            txtNombre.Size = new Size(226, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(34, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(34, 248);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(76, 15);
            lblDocumento.TabIndex = 11;
            lblDocumento.Text = "Documento: ";
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(624, 154);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(128, 114);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 57;
            pbFoto.TabStop = false;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(527, 203);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(79, 23);
            btnFoto.TabIndex = 14;
            btnFoto.Text = "Cargar Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // EmpleadoMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnFoto);
            Controls.Add(pbFoto);
            Controls.Add(btnSalir);
            Controls.Add(lblTitulo);
            Controls.Add(chkActivo);
            Controls.Add(cboDepartamento);
            Controls.Add(cboProvincia);
            Controls.Add(cboDistrito);
            Controls.Add(lblDistrito);
            Controls.Add(lblDepartamento);
            Controls.Add(lblProvincia);
            Controls.Add(txtDocumento);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCerrar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblCorreo);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellidoM);
            Controls.Add(lblApellidoM);
            Controls.Add(txtApellidoP);
            Controls.Add(lblApellidoP);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblDocumento);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmpleadoMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Empleado";
            Load += EmpleadoMan02_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label lblTitulo;
        private CheckBox chkActivo;
        private ComboBox cboDepartamento;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        private Label lblDistrito;
        private Label lblDepartamento;
        private Label lblProvincia;
        private TextBox txtDocumento;
        private GroupBox groupBox1;
        private RadioButton optPasaporte;
        private RadioButton optCarnet;
        private RadioButton optDNI;
        private Button btnGuardar;
        private Button btnCerrar;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private Label lblTelefono;
        private TextBox txtApellidoM;
        private Label lblApellidoM;
        private TextBox txtApellidoP;
        private Label lblApellidoP;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblDocumento;
        private PictureBox pbFoto;
        private Button btnFoto;
        private OpenFileDialog openFileDialog1;
    }
}