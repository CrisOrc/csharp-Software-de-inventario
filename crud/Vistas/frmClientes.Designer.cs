namespace Presentacion.Vistas
{
    partial class frmClientes
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
            gbFormulario = new GroupBox();
            gbCampos = new GroupBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            gbControles = new GroupBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            dtgClientes = new DataGridView();
            clId = new DataGridViewTextBoxColumn();
            clNombre = new DataGridViewTextBoxColumn();
            clEmail = new DataGridViewTextBoxColumn();
            clTelefono = new DataGridViewTextBoxColumn();
            gbFormulario.SuspendLayout();
            gbCampos.SuspendLayout();
            gbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClientes).BeginInit();
            SuspendLayout();
            // 
            // gbFormulario
            // 
            gbFormulario.Controls.Add(gbCampos);
            gbFormulario.Controls.Add(gbControles);
            gbFormulario.Dock = DockStyle.Left;
            gbFormulario.Location = new Point(0, 0);
            gbFormulario.Name = "gbFormulario";
            gbFormulario.Size = new Size(353, 487);
            gbFormulario.TabIndex = 18;
            gbFormulario.TabStop = false;
            // 
            // gbCampos
            // 
            gbCampos.Controls.Add(lblTelefono);
            gbCampos.Controls.Add(txtTelefono);
            gbCampos.Controls.Add(lblEmail);
            gbCampos.Controls.Add(txtEmail);
            gbCampos.Controls.Add(lblNombre);
            gbCampos.Controls.Add(txtNombre);
            gbCampos.Location = new Point(6, 7);
            gbCampos.Name = "gbCampos";
            gbCampos.Size = new Size(333, 355);
            gbCampos.TabIndex = 24;
            gbCampos.TabStop = false;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(15, 119);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 21);
            lblTelefono.TabIndex = 32;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(130, 119);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(195, 29);
            txtTelefono.TabIndex = 31;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(15, 68);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 30;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(130, 68);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 29);
            txtEmail.TabIndex = 29;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(15, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 28;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(130, 19);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 29);
            txtNombre.TabIndex = 27;
            // 
            // gbControles
            // 
            gbControles.Controls.Add(btnIngresar);
            gbControles.Controls.Add(btnCancelar);
            gbControles.Controls.Add(btnEliminar);
            gbControles.Controls.Add(btnModificar);
            gbControles.Controls.Add(btnActualizar);
            gbControles.Controls.Add(btnInsertar);
            gbControles.Location = new Point(6, 361);
            gbControles.Name = "gbControles";
            gbControles.Size = new Size(333, 125);
            gbControles.TabIndex = 23;
            gbControles.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(6, 22);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 43);
            btnIngresar.TabIndex = 17;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(6, 71);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 43);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(218, 22);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.RightToLeft = RightToLeft.Yes;
            btnEliminar.Size = new Size(100, 43);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(112, 22);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 43);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(112, 22);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 43);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(6, 22);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(100, 43);
            btnInsertar.TabIndex = 18;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dtgClientes
            // 
            dtgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgClientes.Columns.AddRange(new DataGridViewColumn[] { clId, clNombre, clEmail, clTelefono });
            dtgClientes.Dock = DockStyle.Right;
            dtgClientes.Location = new Point(379, 0);
            dtgClientes.Name = "dtgClientes";
            dtgClientes.Size = new Size(475, 487);
            dtgClientes.TabIndex = 17;
            // 
            // clId
            // 
            clId.HeaderText = "ID";
            clId.Name = "clId";
            // 
            // clNombre
            // 
            clNombre.HeaderText = "Nombre";
            clNombre.Name = "clNombre";
            // 
            // clEmail
            // 
            clEmail.HeaderText = "Email";
            clEmail.Name = "clEmail";
            // 
            // clTelefono
            // 
            clTelefono.HeaderText = "Telefono";
            clTelefono.Name = "clTelefono";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 487);
            Controls.Add(gbFormulario);
            Controls.Add(dtgClientes);
            Name = "frmClientes";
            Text = "Clientes";
            Load += frmClientes_Load;
            gbFormulario.ResumeLayout(false);
            gbCampos.ResumeLayout(false);
            gbCampos.PerformLayout();
            gbControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFormulario;
        private GroupBox gbCampos;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblNombre;
        private TextBox txtNombre;
        private GroupBox gbControles;
        private Button btnIngresar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnActualizar;
        private Button btnInsertar;
        private DataGridView dtgClientes;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clNombre;
        private DataGridViewTextBoxColumn clEmail;
        private DataGridViewTextBoxColumn clTelefono;
    }
}