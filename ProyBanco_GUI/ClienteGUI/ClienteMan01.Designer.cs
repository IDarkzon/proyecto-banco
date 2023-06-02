namespace ProyBanco_GUI.ClienteGUI
{
    partial class ClienteMan01
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnCerrar = new Button();
            btnNuevo = new Button();
            btnEditar = new Button();
            dtgDatos = new DataGridView();
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            lblRegistros = new Label();
            lblDatos = new Label();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido_Paterno = new DataGridViewTextBoxColumn();
            Apellido_Materno = new DataGridViewTextBoxColumn();
            Numero_Documento = new DataGridViewTextBoxColumn();
            Tipo_Documento = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Provincia = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fec_Registro = new DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Apellido_Paterno, Apellido_Materno, Numero_Documento, Tipo_Documento, Edad, Telefono, Correo, Direccion, Departamento, Provincia, Distrito, Estado, Fec_Registro });
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
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido_Paterno
            // 
            Apellido_Paterno.DataPropertyName = "Apellido_Paterno";
            Apellido_Paterno.HeaderText = "Apellido Paterno";
            Apellido_Paterno.Name = "Apellido_Paterno";
            Apellido_Paterno.ReadOnly = true;
            // 
            // Apellido_Materno
            // 
            Apellido_Materno.DataPropertyName = "Apellido_Materno";
            Apellido_Materno.HeaderText = "Apellido Materno";
            Apellido_Materno.Name = "Apellido_Materno";
            Apellido_Materno.ReadOnly = true;
            // 
            // Numero_Documento
            // 
            Numero_Documento.DataPropertyName = "Numero_Documento";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Numero_Documento.DefaultCellStyle = dataGridViewCellStyle2;
            Numero_Documento.HeaderText = "Documento";
            Numero_Documento.Name = "Numero_Documento";
            Numero_Documento.ReadOnly = true;
            // 
            // Tipo_Documento
            // 
            Tipo_Documento.DataPropertyName = "Tipo_Documento";
            Tipo_Documento.HeaderText = "Tipo Documento";
            Tipo_Documento.Name = "Tipo_Documento";
            Tipo_Documento.ReadOnly = true;
            // 
            // Edad
            // 
            Edad.DataPropertyName = "Edad";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            Edad.DefaultCellStyle = dataGridViewCellStyle3;
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.NullValue = null;
            Telefono.DefaultCellStyle = dataGridViewCellStyle4;
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Dirección";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Departamento
            // 
            Departamento.DataPropertyName = "Departamento";
            Departamento.HeaderText = "Departamento";
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            // 
            // Provincia
            // 
            Provincia.DataPropertyName = "Provincia";
            Provincia.HeaderText = "Provincia";
            Provincia.Name = "Provincia";
            Provincia.ReadOnly = true;
            // 
            // Distrito
            // 
            Distrito.DataPropertyName = "Distrito";
            Distrito.HeaderText = "Distrito";
            Distrito.Name = "Distrito";
            Distrito.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Fec_Registro
            // 
            Fec_Registro.DataPropertyName = "Fec_Registro";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            Fec_Registro.DefaultCellStyle = dataGridViewCellStyle5;
            Fec_Registro.HeaderText = "F. Registro";
            Fec_Registro.Name = "Fec_Registro";
            Fec_Registro.ReadOnly = true;
            // 
            // ClienteMan01
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
            Name = "ClienteMan01";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Información de Clientes";
            WindowState = FormWindowState.Maximized;
            Load += ClienteMan01_Load;
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
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido_Paterno;
        private DataGridViewTextBoxColumn Apellido_Materno;
        private DataGridViewTextBoxColumn Numero_Documento;
        private DataGridViewTextBoxColumn Tipo_Documento;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fec_Registro;
    }
}