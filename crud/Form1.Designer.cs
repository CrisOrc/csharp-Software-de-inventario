namespace crud
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msMenu = new MenuStrip();
            msiInicio = new ToolStripMenuItem();
            msiProductos = new ToolStripMenuItem();
            msiGestionProductos = new ToolStripMenuItem();
            msiCategoriaProductos = new ToolStripMenuItem();
            msiUsuarios = new ToolStripMenuItem();
            msiClientes = new ToolStripMenuItem();
            mediosDePagoToolStripMenuItem = new ToolStripMenuItem();
            pnlVistas = new Panel();
            msMenu.SuspendLayout();
            SuspendLayout();
            // 
            // msMenu
            // 
            msMenu.Items.AddRange(new ToolStripItem[] { msiInicio, msiProductos, msiUsuarios, msiClientes, mediosDePagoToolStripMenuItem });
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.Size = new Size(1192, 24);
            msMenu.TabIndex = 0;
            msMenu.Text = "menuStrip1";
            // 
            // msiInicio
            // 
            msiInicio.Name = "msiInicio";
            msiInicio.Size = new Size(48, 20);
            msiInicio.Text = "Inicio";
            msiInicio.Click += msiInicio_Click;
            // 
            // msiProductos
            // 
            msiProductos.DropDownItems.AddRange(new ToolStripItem[] { msiGestionProductos, msiCategoriaProductos });
            msiProductos.Name = "msiProductos";
            msiProductos.Size = new Size(73, 20);
            msiProductos.Text = "Productos";
            // 
            // msiGestionProductos
            // 
            msiGestionProductos.Name = "msiGestionProductos";
            msiGestionProductos.Size = new Size(181, 22);
            msiGestionProductos.Text = "Gestión productos";
            msiGestionProductos.Click += msiGestionProductos_Click;
            // 
            // msiCategoriaProductos
            // 
            msiCategoriaProductos.Name = "msiCategoriaProductos";
            msiCategoriaProductos.Size = new Size(181, 22);
            msiCategoriaProductos.Text = "Categoria procuctos";
            msiCategoriaProductos.Click += msiCategoriaProductos_Click;
            // 
            // msiUsuarios
            // 
            msiUsuarios.Name = "msiUsuarios";
            msiUsuarios.Size = new Size(64, 20);
            msiUsuarios.Text = "Usuarios";
            msiUsuarios.Click += msiUsuarios_Click;
            // 
            // msiClientes
            // 
            msiClientes.Name = "msiClientes";
            msiClientes.Size = new Size(61, 20);
            msiClientes.Text = "Clientes";
            msiClientes.Click += msiClientes_Click;
            // 
            // mediosDePagoToolStripMenuItem
            // 
            mediosDePagoToolStripMenuItem.Name = "mediosDePagoToolStripMenuItem";
            mediosDePagoToolStripMenuItem.Size = new Size(104, 20);
            mediosDePagoToolStripMenuItem.Text = "Medios de pago";
            mediosDePagoToolStripMenuItem.Click += mediosDePagoToolStripMenuItem_Click;
            // 
            // pnlVistas
            // 
            pnlVistas.Dock = DockStyle.Fill;
            pnlVistas.Location = new Point(0, 24);
            pnlVistas.Name = "pnlVistas";
            pnlVistas.Size = new Size(1192, 637);
            pnlVistas.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 661);
            Controls.Add(pnlVistas);
            Controls.Add(msMenu);
            MainMenuStrip = msMenu;
            Name = "frmMain";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            Load += Form1_Load;
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMenu;
        private ToolStripMenuItem msiInicio;
        private ToolStripMenuItem msiProductos;
        private ToolStripMenuItem msiGestionProductos;
        private ToolStripMenuItem msiCategoriaProductos;
        private ToolStripMenuItem msiUsuarios;
        private ToolStripMenuItem msiClientes;
        private Panel pnlVistas;
        private ToolStripMenuItem mediosDePagoToolStripMenuItem;
    }
}
