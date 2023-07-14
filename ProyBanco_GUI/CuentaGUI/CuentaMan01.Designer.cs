namespace ProyBanco_GUI.CuentaGUI
{
    partial class CuentaMan01
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnCerrar = new Button();
            btnNuevo = new Button();
            btnEditar = new Button();
            dtgDatos = new DataGridView();
            Numero_Cuenta = new DataGridViewTextBoxColumn();
            Codigo_Cliente = new DataGridViewTextBoxColumn();
            Nombre_Cliente = new DataGridViewTextBoxColumn();
            Apellido_Paterno = new DataGridViewTextBoxColumn();
            Apellido_Materno = new DataGridViewTextBoxColumn();
            Tipo_Moneda = new DataGridViewTextBoxColumn();
            Saldo_Cuenta = new DataGridViewTextBoxColumn();
            Tipo_Cuenta = new DataGridViewTextBoxColumn();
            Fecha_Apertura = new DataGridViewTextBoxColumn();
            Codigo_Agencia = new DataGridViewTextBoxColumn();
            Estado_Cuenta = new DataGridViewTextBoxColumn();
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            lblRegistros = new Label();
            lblDatos = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
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
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.Location = new Point(590, 394);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Numero_Cuenta, Codigo_Cliente, Nombre_Cliente, Apellido_Paterno, Apellido_Materno, Tipo_Moneda, Saldo_Cuenta, Tipo_Cuenta, Fecha_Apertura, Codigo_Agencia, Estado_Cuenta });
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
            // Numero_Cuenta
            // 
            Numero_Cuenta.DataPropertyName = "Numero Cuenta";
            Numero_Cuenta.HeaderText = "N. Cuenta";
            Numero_Cuenta.Name = "Numero_Cuenta";
            Numero_Cuenta.ReadOnly = true;
            // 
            // Codigo_Cliente
            // 
            Codigo_Cliente.DataPropertyName = "Codigo Cliente";
            Codigo_Cliente.HeaderText = "Código Cliente";
            Codigo_Cliente.Name = "Codigo_Cliente";
            Codigo_Cliente.ReadOnly = true;
            // 
            // Nombre_Cliente
            // 
            Nombre_Cliente.DataPropertyName = "Nombre Cliente";
            Nombre_Cliente.HeaderText = "Nombre";
            Nombre_Cliente.Name = "Nombre_Cliente";
            Nombre_Cliente.ReadOnly = true;
            // 
            // Apellido_Paterno
            // 
            Apellido_Paterno.DataPropertyName = "Apellido Paterno";
            Apellido_Paterno.HeaderText = "Apellido Paterno";
            Apellido_Paterno.Name = "Apellido_Paterno";
            Apellido_Paterno.ReadOnly = true;
            // 
            // Apellido_Materno
            // 
            Apellido_Materno.DataPropertyName = "Apellido Materno";
            Apellido_Materno.HeaderText = "Apellido Materno";
            Apellido_Materno.Name = "Apellido_Materno";
            Apellido_Materno.ReadOnly = true;
            // 
            // Tipo_Moneda
            // 
            Tipo_Moneda.DataPropertyName = "Tipo Moneda";
            Tipo_Moneda.HeaderText = "T. Moneda";
            Tipo_Moneda.Name = "Tipo_Moneda";
            Tipo_Moneda.ReadOnly = true;
            // 
            // Saldo_Cuenta
            // 
            Saldo_Cuenta.DataPropertyName = "Saldo Cuenta";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            Saldo_Cuenta.DefaultCellStyle = dataGridViewCellStyle1;
            Saldo_Cuenta.HeaderText = "Saldo";
            Saldo_Cuenta.Name = "Saldo_Cuenta";
            Saldo_Cuenta.ReadOnly = true;
            // 
            // Tipo_Cuenta
            // 
            Tipo_Cuenta.DataPropertyName = "Tipo Cuenta";
            Tipo_Cuenta.HeaderText = "T. Cuenta";
            Tipo_Cuenta.Name = "Tipo_Cuenta";
            Tipo_Cuenta.ReadOnly = true;
            // 
            // Fecha_Apertura
            // 
            Fecha_Apertura.DataPropertyName = "Fecha Apertura";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            Fecha_Apertura.DefaultCellStyle = dataGridViewCellStyle2;
            Fecha_Apertura.HeaderText = "F. Apertura";
            Fecha_Apertura.Name = "Fecha_Apertura";
            Fecha_Apertura.ReadOnly = true;
            // 
            // Codigo_Agencia
            // 
            Codigo_Agencia.DataPropertyName = "Codigo Agencia";
            Codigo_Agencia.HeaderText = "Código Agencia";
            Codigo_Agencia.Name = "Codigo_Agencia";
            Codigo_Agencia.ReadOnly = true;
            // 
            // Estado_Cuenta
            // 
            Estado_Cuenta.DataPropertyName = "Estado Cuenta";
            Estado_Cuenta.HeaderText = "Estado Cuenta";
            Estado_Cuenta.Name = "Estado_Cuenta";
            Estado_Cuenta.ReadOnly = true;
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
            lblFiltro.Text = "Filtro de Datos por Apellido:";
            lblFiltro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(196, 50);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(200, 23);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
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
            // CuentaMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
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
            Name = "CuentaMan01";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Información de Cuentas";
            WindowState = FormWindowState.Maximized;
            Load += CuentaMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnNuevo;
        private Button btnEditar;
        private DataGridView dtgDatos;
        private Label lblFiltro;
        private TextBox txtFiltro;
        private Label lblRegistros;
        private Label lblDatos;
        private DataGridViewTextBoxColumn Numero_Cuenta;
        private DataGridViewTextBoxColumn Codigo_Cliente;
        private DataGridViewTextBoxColumn Nombre_Cliente;
        private DataGridViewTextBoxColumn Apellido_Paterno;
        private DataGridViewTextBoxColumn Apellido_Materno;
        private DataGridViewTextBoxColumn Tipo_Moneda;
        private DataGridViewTextBoxColumn Saldo_Cuenta;
        private DataGridViewTextBoxColumn Tipo_Cuenta;
        private DataGridViewTextBoxColumn Fecha_Apertura;
        private DataGridViewTextBoxColumn Codigo_Agencia;
        private DataGridViewTextBoxColumn Estado_Cuenta;
    }
}