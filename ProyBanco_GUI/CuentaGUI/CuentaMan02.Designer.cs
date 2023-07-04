namespace ProyBanco_GUI.CuentaGUI
{
    partial class CuentaMan02
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
            lblCodCli = new Label();
            txtCodCli = new TextBox();
            lblCodAge = new Label();
            txtCodAge = new TextBox();
            lblSaldo = new Label();
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            optDolares = new RadioButton();
            optSoles = new RadioButton();
            btnGuardar = new Button();
            chkActivo = new CheckBox();
            lblTitulo = new Label();
            btnSalir = new Button();
            groupBox2 = new GroupBox();
            optAhorro = new RadioButton();
            optCorriente = new RadioButton();
            mskSaldo = new MaskedTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodCli
            // 
            lblCodCli.AutoSize = true;
            lblCodCli.Location = new Point(49, 105);
            lblCodCli.Name = "lblCodCli";
            lblCodCli.Size = new Size(108, 15);
            lblCodCli.TabIndex = 1;
            lblCodCli.Text = "Código del Cliente:";
            // 
            // txtCodCli
            // 
            txtCodCli.Location = new Point(177, 102);
            txtCodCli.MaxLength = 4;
            txtCodCli.Name = "txtCodCli";
            txtCodCli.PlaceholderText = "C001";
            txtCodCli.Size = new Size(82, 23);
            txtCodCli.TabIndex = 2;
            // 
            // lblCodAge
            // 
            lblCodAge.AutoSize = true;
            lblCodAge.Location = new Point(48, 156);
            lblCodAge.Name = "lblCodAge";
            lblCodAge.Size = new Size(123, 15);
            lblCodAge.TabIndex = 3;
            lblCodAge.Text = "Código de la Agencia:";
            // 
            // txtCodAge
            // 
            txtCodAge.Location = new Point(177, 153);
            txtCodAge.MaxLength = 4;
            txtCodAge.Name = "txtCodAge";
            txtCodAge.PlaceholderText = "A001";
            txtCodAge.Size = new Size(82, 23);
            txtCodAge.TabIndex = 4;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(49, 238);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(39, 15);
            lblSaldo.TabIndex = 5;
            lblSaldo.Text = "Saldo:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(418, 396);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optDolares);
            groupBox1.Controls.Add(optSoles);
            groupBox1.Location = new Point(296, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 117);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Moneda";
            // 
            // optDolares
            // 
            optDolares.AutoSize = true;
            optDolares.Location = new Point(46, 73);
            optDolares.Name = "optDolares";
            optDolares.Size = new Size(64, 19);
            optDolares.TabIndex = 1;
            optDolares.Text = "Dolares";
            optDolares.UseVisualStyleBackColor = true;
            // 
            // optSoles
            // 
            optSoles.AutoSize = true;
            optSoles.Checked = true;
            optSoles.Location = new Point(46, 38);
            optSoles.Name = "optSoles";
            optSoles.Size = new Size(52, 19);
            optSoles.TabIndex = 0;
            optSoles.TabStop = true;
            optSoles.Text = "Soles";
            optSoles.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(319, 396);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(49, 278);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 7;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(48, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(151, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nueva Cuenta";
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
            btnSalir.Location = new Point(491, 32);
            btnSalir.Margin = new Padding(0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(42, 39);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnCerrar_Click;
            btnSalir.MouseEnter += btnSalir_MouseEnter;
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(optAhorro);
            groupBox2.Controls.Add(optCorriente);
            groupBox2.Location = new Point(296, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 118);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Cuenta";
            // 
            // optAhorro
            // 
            optAhorro.AutoSize = true;
            optAhorro.Location = new Point(46, 73);
            optAhorro.Name = "optAhorro";
            optAhorro.Size = new Size(62, 19);
            optAhorro.TabIndex = 1;
            optAhorro.TabStop = true;
            optAhorro.Text = "Ahorro";
            optAhorro.UseVisualStyleBackColor = true;
            // 
            // optCorriente
            // 
            optCorriente.AutoSize = true;
            optCorriente.Checked = true;
            optCorriente.Location = new Point(46, 39);
            optCorriente.Name = "optCorriente";
            optCorriente.Size = new Size(74, 19);
            optCorriente.TabIndex = 0;
            optCorriente.TabStop = true;
            optCorriente.Text = "Corriente";
            optCorriente.UseVisualStyleBackColor = true;
            // 
            // mskSaldo
            // 
            mskSaldo.Location = new Point(110, 235);
            mskSaldo.Mask = "99999.99";
            mskSaldo.Name = "mskSaldo";
            mskSaldo.Size = new Size(100, 23);
            mskSaldo.TabIndex = 6;
            // 
            // CuentaMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 450);
            ControlBox = false;
            Controls.Add(mskSaldo);
            Controls.Add(groupBox2);
            Controls.Add(btnSalir);
            Controls.Add(lblTitulo);
            Controls.Add(chkActivo);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCerrar);
            Controls.Add(txtCodAge);
            Controls.Add(txtCodCli);
            Controls.Add(lblSaldo);
            Controls.Add(lblCodAge);
            Controls.Add(lblCodCli);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CuentaMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Cliente";
            Load += CuentaMan02_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCodCli;
        private TextBox txtCodCli;
        private Label lblCodAge;
        private TextBox txtCodAge;
        private Label lblSaldo;
        private Button btnCerrar;
        private GroupBox groupBox1;
        private RadioButton optDolares;
        private RadioButton optSoles;
        private Button btnGuardar;
        private CheckBox chkActivo;
        private Label lblTitulo;
        private Button btnSalir;
        private GroupBox groupBox2;
        private RadioButton optAhorro;
        private RadioButton optCorriente;
        private MaskedTextBox mskSaldo;
    }
}