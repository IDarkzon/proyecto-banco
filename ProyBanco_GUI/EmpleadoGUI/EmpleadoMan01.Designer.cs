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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblDatos = new Label();
            lblRegistros = new Label();
            txtFiltro = new TextBox();
            lblFiltro = new Label();
            dtgDatos = new DataGridView();
            btnEditar = new Button();
            btnNuevo = new Button();
            btnCerrar = new Button();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Apellido_Paterno = new DataGridViewTextBoxColumn();
            Apellido_Materno = new DataGridViewTextBoxColumn();
            Numero_Documento = new DataGridViewTextBoxColumn();
            Tipo_Documento = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Provincia = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
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
            btnEditar.Click += btnEditar_Click;
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
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Código";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Codigo";
            dataGridViewTextBoxColumn3.HeaderText = "Código";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Apellido_Paterno
            // 
            Apellido_Paterno.DataPropertyName = "Apellido Paterno";
            Apellido_Paterno.HeaderText = "Apellido Paterno";
            Apellido_Paterno.Name = "Apellido_Paterno";
            Apellido_Paterno.Width = 362;
            // 
            // Apellido_Materno
            // 
            Apellido_Materno.DataPropertyName = "Apellido Materno";
            Apellido_Materno.HeaderText = "Apellido Materno";
            Apellido_Materno.Name = "Apellido_Materno";
            // 
            // Numero_Documento
            // 
            Numero_Documento.DataPropertyName = "Numero Documento";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            Numero_Documento.DefaultCellStyle = dataGridViewCellStyle1;
            Numero_Documento.HeaderText = "Documento";
            Numero_Documento.Name = "Numero_Documento";
            // 
            // Tipo_Documento
            // 
            Tipo_Documento.DataPropertyName = "Tipo Documento";
            Tipo_Documento.HeaderText = "Tipo Documento";
            Tipo_Documento.Name = "Tipo_Documento";
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Telefono.DefaultCellStyle = dataGridViewCellStyle2;
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Departamento
            // 
            Departamento.DataPropertyName = "Departamento";
            Departamento.HeaderText = "Departamento";
            Departamento.Name = "Departamento";
            // 
            // Provincia
            // 
            Provincia.DataPropertyName = "Provincia";
            Provincia.HeaderText = "Provincia";
            Provincia.Name = "Provincia";
            // 
            // Distrito
            // 
            Distrito.DataPropertyName = "Distrito";
            Distrito.HeaderText = "Distrito";
            Distrito.Name = "Distrito";
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Codigo";
            dataGridViewTextBoxColumn5.HeaderText = "Código";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Codigo";
            dataGridViewTextBoxColumn7.HeaderText = "Codigo";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 725;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn8.HeaderText = "Nombre";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // EmpleadoMan01
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
            Name = "EmpleadoMan01";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Información de Empleados";
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
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Apellido_Paterno;
        private DataGridViewTextBoxColumn Apellido_Materno;
        private DataGridViewTextBoxColumn Numero_Documento;
        private DataGridViewTextBoxColumn Tipo_Documento;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}