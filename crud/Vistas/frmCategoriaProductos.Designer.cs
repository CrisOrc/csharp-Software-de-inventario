namespace Presentacion.Vistas
{
    partial class frmCategoriaProductos
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
            groupBox1 = new GroupBox();
            gbCampos = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            gbControles = new GroupBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            dtgCategoriaProductos = new DataGridView();
            clId = new DataGridViewTextBoxColumn();
            clNombre = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            gbCampos.SuspendLayout();
            gbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCategoriaProductos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gbCampos);
            groupBox1.Controls.Add(gbControles);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 495);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // gbCampos
            // 
            gbCampos.Controls.Add(lblNombre);
            gbCampos.Controls.Add(txtNombre);
            gbCampos.Location = new Point(6, 12);
            gbCampos.Name = "gbCampos";
            gbCampos.Size = new Size(333, 355);
            gbCampos.TabIndex = 27;
            gbCampos.TabStop = false;
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
            gbControles.Location = new Point(6, 371);
            gbControles.Name = "gbControles";
            gbControles.Size = new Size(333, 125);
            gbControles.TabIndex = 26;
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
            btnEliminar.Click += btnEliminar_Click;
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
            // dtgCategoriaProductos
            // 
            dtgCategoriaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCategoriaProductos.Columns.AddRange(new DataGridViewColumn[] { clId, clNombre });
            dtgCategoriaProductos.Dock = DockStyle.Right;
            dtgCategoriaProductos.Location = new Point(362, 0);
            dtgCategoriaProductos.Name = "dtgCategoriaProductos";
            dtgCategoriaProductos.Size = new Size(273, 495);
            dtgCategoriaProductos.TabIndex = 1;
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
            // frmCategoriaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 495);
            Controls.Add(dtgCategoriaProductos);
            Controls.Add(groupBox1);
            Name = "frmCategoriaProductos";
            Text = "Categoria Productos";
            Load += frmCategoriaProductos_Load;
            groupBox1.ResumeLayout(false);
            gbCampos.ResumeLayout(false);
            gbCampos.PerformLayout();
            gbControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgCategoriaProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox gbCampos;
        private Label lblNombre;
        private TextBox txtNombre;
        private GroupBox gbControles;
        private Button btnIngresar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnActualizar;
        private Button btnInsertar;
        private DataGridView dtgCategoriaProductos;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clNombre;
    }
}