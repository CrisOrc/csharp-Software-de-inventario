namespace Presentacion.Vistas
{
    partial class frmUsuarios
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
            cbRoll = new ComboBox();
            lblRoll = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            gbControles = new GroupBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            dtgUsuarios = new DataGridView();
            clId = new DataGridViewTextBoxColumn();
            clUsername = new DataGridViewTextBoxColumn();
            clEmail = new DataGridViewTextBoxColumn();
            clPassword = new DataGridViewTextBoxColumn();
            clRol = new DataGridViewTextBoxColumn();
            gbFormulario.SuspendLayout();
            gbCampos.SuspendLayout();
            gbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // gbFormulario
            // 
            gbFormulario.Controls.Add(gbCampos);
            gbFormulario.Controls.Add(gbControles);
            gbFormulario.Dock = DockStyle.Left;
            gbFormulario.Location = new Point(0, 0);
            gbFormulario.Name = "gbFormulario";
            gbFormulario.Size = new Size(345, 488);
            gbFormulario.TabIndex = 18;
            gbFormulario.TabStop = false;
            // 
            // gbCampos
            // 
            gbCampos.Controls.Add(cbRoll);
            gbCampos.Controls.Add(lblRoll);
            gbCampos.Controls.Add(lblPassword);
            gbCampos.Controls.Add(txtPassword);
            gbCampos.Controls.Add(lblEmail);
            gbCampos.Controls.Add(txtEmail);
            gbCampos.Controls.Add(lblUsername);
            gbCampos.Controls.Add(txtUsername);
            gbCampos.Location = new Point(6, 13);
            gbCampos.Name = "gbCampos";
            gbCampos.Size = new Size(333, 355);
            gbCampos.TabIndex = 24;
            gbCampos.TabStop = false;
            // 
            // cbRoll
            // 
            cbRoll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRoll.FormattingEnabled = true;
            cbRoll.Location = new Point(130, 171);
            cbRoll.Name = "cbRoll";
            cbRoll.Size = new Size(195, 29);
            cbRoll.TabIndex = 38;
            // 
            // lblRoll
            // 
            lblRoll.AutoSize = true;
            lblRoll.Font = new Font("Segoe UI", 12F);
            lblRoll.Location = new Point(15, 169);
            lblRoll.Name = "lblRoll";
            lblRoll.Size = new Size(37, 21);
            lblRoll.TabIndex = 37;
            lblRoll.Text = "Roll";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(15, 119);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 32;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(130, 119);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(195, 29);
            txtPassword.TabIndex = 31;
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
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.Location = new Point(15, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 21);
            lblUsername.TabIndex = 28;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(130, 19);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(195, 29);
            txtUsername.TabIndex = 27;
            // 
            // gbControles
            // 
            gbControles.Controls.Add(btnIngresar);
            gbControles.Controls.Add(btnCancelar);
            gbControles.Controls.Add(btnEliminar);
            gbControles.Controls.Add(btnModificar);
            gbControles.Controls.Add(btnActualizar);
            gbControles.Controls.Add(btnInsertar);
            gbControles.Location = new Point(6, 368);
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
            // dtgUsuarios
            // 
            dtgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuarios.Columns.AddRange(new DataGridViewColumn[] { clId, clUsername, clEmail, clPassword, clRol });
            dtgUsuarios.Dock = DockStyle.Right;
            dtgUsuarios.Location = new Point(359, 0);
            dtgUsuarios.Name = "dtgUsuarios";
            dtgUsuarios.Size = new Size(601, 488);
            dtgUsuarios.TabIndex = 17;
            // 
            // clId
            // 
            clId.HeaderText = "ID";
            clId.Name = "clId";
            // 
            // clUsername
            // 
            clUsername.HeaderText = "Username";
            clUsername.Name = "clUsername";
            // 
            // clEmail
            // 
            clEmail.HeaderText = "Email";
            clEmail.Name = "clEmail";
            // 
            // clPassword
            // 
            clPassword.HeaderText = "Password";
            clPassword.Name = "clPassword";
            // 
            // clRol
            // 
            clRol.HeaderText = "Rol";
            clRol.Name = "clRol";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 488);
            Controls.Add(gbFormulario);
            Controls.Add(dtgUsuarios);
            Name = "frmUsuarios";
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            gbFormulario.ResumeLayout(false);
            gbCampos.ResumeLayout(false);
            gbCampos.PerformLayout();
            gbControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbFormulario;
        private GroupBox gbCampos;
        private ComboBox cbRoll;
        private Label lblRoll;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblUsername;
        private TextBox txtUsername;
        private GroupBox gbControles;
        private Button btnIngresar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnActualizar;
        private Button btnInsertar;
        private DataGridView dtgUsuarios;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clUsername;
        private DataGridViewTextBoxColumn clEmail;
        private DataGridViewTextBoxColumn clPassword;
        private DataGridViewTextBoxColumn clRol;
    }
}