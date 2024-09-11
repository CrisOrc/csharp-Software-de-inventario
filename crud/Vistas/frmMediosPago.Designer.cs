namespace Presentacion.Vistas
{
    partial class frmMediosPago
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
            lblMetodo = new Label();
            txtMetodo = new TextBox();
            gbControles = new GroupBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            dtgProductos = new DataGridView();
            clId = new DataGridViewTextBoxColumn();
            clMetodo = new DataGridViewTextBoxColumn();
            gbFormulario.SuspendLayout();
            gbCampos.SuspendLayout();
            gbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).BeginInit();
            SuspendLayout();
            // 
            // gbFormulario
            // 
            gbFormulario.Controls.Add(gbCampos);
            gbFormulario.Controls.Add(gbControles);
            gbFormulario.Dock = DockStyle.Left;
            gbFormulario.Location = new Point(0, 0);
            gbFormulario.Name = "gbFormulario";
            gbFormulario.Size = new Size(345, 309);
            gbFormulario.TabIndex = 18;
            gbFormulario.TabStop = false;
            // 
            // gbCampos
            // 
            gbCampos.Controls.Add(lblMetodo);
            gbCampos.Controls.Add(txtMetodo);
            gbCampos.Location = new Point(6, 12);
            gbCampos.Name = "gbCampos";
            gbCampos.Size = new Size(333, 145);
            gbCampos.TabIndex = 24;
            gbCampos.TabStop = false;
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMetodo.Location = new Point(15, 19);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(64, 21);
            lblMetodo.TabIndex = 28;
            lblMetodo.Text = "Método";
            // 
            // txtMetodo
            // 
            txtMetodo.Font = new Font("Segoe UI", 12F);
            txtMetodo.Location = new Point(130, 19);
            txtMetodo.Multiline = true;
            txtMetodo.Name = "txtMetodo";
            txtMetodo.Size = new Size(195, 29);
            txtMetodo.TabIndex = 27;
            // 
            // gbControles
            // 
            gbControles.Controls.Add(btnIngresar);
            gbControles.Controls.Add(btnCancelar);
            gbControles.Controls.Add(btnEliminar);
            gbControles.Controls.Add(btnModificar);
            gbControles.Controls.Add(btnActualizar);
            gbControles.Controls.Add(btnInsertar);
            gbControles.Location = new Point(6, 160);
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
            // dtgProductos
            // 
            dtgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProductos.Columns.AddRange(new DataGridViewColumn[] { clId, clMetodo });
            dtgProductos.Dock = DockStyle.Right;
            dtgProductos.Location = new Point(372, 0);
            dtgProductos.Name = "dtgProductos";
            dtgProductos.Size = new Size(294, 309);
            dtgProductos.TabIndex = 17;
            // 
            // clId
            // 
            clId.HeaderText = "ID";
            clId.Name = "clId";
            // 
            // clMetodo
            // 
            clMetodo.HeaderText = "Metodo";
            clMetodo.Name = "clMetodo";
            // 
            // frmMediosPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 309);
            Controls.Add(gbFormulario);
            Controls.Add(dtgProductos);
            Name = "frmMediosPago";
            Text = "Medios Pago";
            Load += frmMediosPago_Load;
            gbFormulario.ResumeLayout(false);
            gbCampos.ResumeLayout(false);
            gbCampos.PerformLayout();
            gbControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbFormulario;
        private GroupBox gbCampos;
        private ComboBox cbCategoria;
        private Label lblCategoria;
        private Label lblStock;
        private TextBox txtStock;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblNombre;
        private TextBox txtMetodo;
        private GroupBox gbControles;
        private Button btnIngresar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnActualizar;
        private Button btnInsertar;
        private DataGridView dtgProductos;
        private Label lblMetodo;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clMetodo;
    }
}