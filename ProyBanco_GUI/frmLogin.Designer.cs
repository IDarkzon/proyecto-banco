namespace ProyBanco_GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DimGray;
            btnIngresar.FlatAppearance.BorderColor = Color.Black;
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(66, 308);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(108, 37);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.MouseEnter += btnIngresar_MouseEnter;
            btnIngresar.MouseLeave += btnIngresar_MouseLeave;
            // 
            // txtUsuario
            // 
            txtUsuario.CharacterCasing = CharacterCasing.Lower;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(55, 199);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(130, 29);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = SystemColors.Window;
            txtContrasena.CharacterCasing = CharacterCasing.Lower;
            txtContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.Location = new Point(55, 234);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.PlaceholderText = "Contraseña";
            txtContrasena.Size = new Size(130, 29);
            txtContrasena.TabIndex = 2;
            txtContrasena.TextAlign = HorizontalAlignment.Center;
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
            btnSalir.Location = new Point(203, -2);
            btnSalir.Margin = new Padding(0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(42, 39);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseEnter += btnSalir_MouseEnter;
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(66, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 111);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.fondoLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(241, 392);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            KeyDown += frmLogin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}