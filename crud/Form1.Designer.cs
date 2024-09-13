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
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            msiFacturacion = new ToolStripMenuItem();
            msiProductos = new ToolStripMenuItem();
            msiGestionProductos = new ToolStripMenuItem();
            msiCategoriaProductos = new ToolStripMenuItem();
            msiUsuarios = new ToolStripMenuItem();
            msiClientes = new ToolStripMenuItem();
            mediosDePagoToolStripMenuItem = new ToolStripMenuItem();
            msMenu.SuspendLayout();
            SuspendLayout();
            // 
            // msMenu
            // 
            msMenu.Items.AddRange(new ToolStripItem[] { msiFacturacion, msiProductos, msiUsuarios, msiClientes, mediosDePagoToolStripMenuItem });
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.Size = new Size(1192, 24);
            msMenu.TabIndex = 1;
            msMenu.Text = "menuStrip1";
            // 
            // msiFacturacion
            // 
            msiFacturacion.Name = "msiFacturacion";
            msiFacturacion.Size = new Size(81, 20);
            msiFacturacion.Text = "Facturación";
            msiFacturacion.Click += msiFacturacion_Click;
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
            msiGestionProductos.Size = new Size(198, 22);
            msiGestionProductos.Text = "Gestión de Productos";
            msiGestionProductos.Click += msiGestionProductos_Click;
            // 
            // msiCategoriaProductos
            // 
            msiCategoriaProductos.Name = "msiCategoriaProductos";
            msiCategoriaProductos.Size = new Size(198, 22);
            msiCategoriaProductos.Text = "Categoría de Productos";
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
            mediosDePagoToolStripMenuItem.Text = "Medios de Pago";
            mediosDePagoToolStripMenuItem.Click += mediosDePagoToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 661);
            Controls.Add(msMenu);
            IsMdiContainer = true;
            Name = "frmMain";
            Text = "Inventario";
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMenu;
        private ToolStripMenuItem msiFacturacion;
        private ToolStripMenuItem msiProductos;
        private ToolStripMenuItem msiGestionProductos;
        private ToolStripMenuItem msiCategoriaProductos;
        private ToolStripMenuItem msiUsuarios;
        private ToolStripMenuItem msiClientes;
        private ToolStripMenuItem mediosDePagoToolStripMenuItem;
    }
}
