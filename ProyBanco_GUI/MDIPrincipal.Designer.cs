namespace ProyBanco_GUI
{
    partial class MDIPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            MenuStrip = new MenuStrip();
            herramientasToolStripMenuItem = new ToolStripMenuItem();
            ClientesToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            cuentasToolStripMenuItem = new ToolStripMenuItem();
            visorFotosToolStripMenuItem = new ToolStripMenuItem();
            Timer = new System.Windows.Forms.Timer(components);
            StatusStrip = new StatusStrip();
            lblEquipo = new ToolStripStatusLabel();
            lblRed = new ToolStripStatusLabel();
            lblTiempo = new ToolStripStatusLabel();
            MenuStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = SystemColors.Control;
            MenuStrip.BackgroundImageLayout = ImageLayout.None;
            MenuStrip.Items.AddRange(new ToolStripItem[] { herramientasToolStripMenuItem, visorFotosToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(800, 32);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "menuStrip1";
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.BackColor = Color.Transparent;
            herramientasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ClientesToolStripMenuItem, empleadosToolStripMenuItem, cuentasToolStripMenuItem });
            herramientasToolStripMenuItem.ForeColor = Color.Black;
            herramientasToolStripMenuItem.Image = Properties.Resources.config;
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.Padding = new Padding(4);
            herramientasToolStripMenuItem.Size = new Size(117, 28);
            herramientasToolStripMenuItem.Text = "Mantenimiento";
            // 
            // ClientesToolStripMenuItem
            // 
            ClientesToolStripMenuItem.Image = Properties.Resources.cliente;
            ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            ClientesToolStripMenuItem.Size = new Size(180, 22);
            ClientesToolStripMenuItem.Text = "Clientes";
            ClientesToolStripMenuItem.Click += ClientesToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Image = (Image)resources.GetObject("empleadosToolStripMenuItem.Image");
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(132, 22);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // cuentasToolStripMenuItem
            // 
            cuentasToolStripMenuItem.Image = Properties.Resources.Calc;
            cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            cuentasToolStripMenuItem.Size = new Size(132, 22);
            cuentasToolStripMenuItem.Text = "Cuentas";
            cuentasToolStripMenuItem.Click += cuentasToolStripMenuItem_Click;
            // 
            // visorFotosToolStripMenuItem
            // 
            visorFotosToolStripMenuItem.Image = (Image)resources.GetObject("visorFotosToolStripMenuItem.Image");
            visorFotosToolStripMenuItem.Name = "visorFotosToolStripMenuItem";
            visorFotosToolStripMenuItem.Size = new Size(115, 28);
            visorFotosToolStripMenuItem.Text = "Visor Imagenes";
            visorFotosToolStripMenuItem.Click += visorFotosToolStripMenuItem_Click;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // StatusStrip
            // 
            StatusStrip.BackgroundImageLayout = ImageLayout.Stretch;
            StatusStrip.Items.AddRange(new ToolStripItem[] { lblEquipo, lblRed, lblTiempo });
            StatusStrip.Location = new Point(0, 428);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(800, 22);
            StatusStrip.TabIndex = 1;
            StatusStrip.Text = "statusStrip1";
            // 
            // lblEquipo
            // 
            lblEquipo.BackColor = Color.Black;
            lblEquipo.ForeColor = Color.White;
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(50, 17);
            lblEquipo.Text = "Usuario:";
            // 
            // lblRed
            // 
            lblRed.BackColor = Color.Black;
            lblRed.ForeColor = Color.White;
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(0, 17);
            // 
            // lblTiempo
            // 
            lblTiempo.BackColor = Color.Transparent;
            lblTiempo.ForeColor = Color.Black;
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(50, 17);
            lblTiempo.Text = "Tiempo:";
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(StatusStrip);
            Controls.Add(MenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = MenuStrip;
            Name = "MDIPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banco Nación - Pantalla Principal | ";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            FormClosed += MDIPrincipal_FormClosed;
            Load += MDIPrincipal_Load;
            Resize += MDIPrincipal_Resize;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.Timer Timer;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel lblEquipo;
        private ToolStripStatusLabel lblTiempo;
        private ToolStripStatusLabel lblRed;
        private ToolStripMenuItem ClientesToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem visorFotosToolStripMenuItem;
        private ToolStripMenuItem cuentasToolStripMenuItem;
    }
}