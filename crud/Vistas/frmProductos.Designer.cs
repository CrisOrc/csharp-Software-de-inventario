namespace Presentacion.Vistas
{
    partial class frmProductos
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
            dtgProductos = new DataGridView();
            clId = new DataGridViewTextBoxColumn();
            clNombre = new DataGridViewTextBoxColumn();
            clDescripcion = new DataGridViewTextBoxColumn();
            clMarca = new DataGridViewTextBoxColumn();
            clPrecio = new DataGridViewTextBoxColumn();
            clStock = new DataGridViewTextBoxColumn();
            clCategoria = new DataGridViewTextBoxColumn();
            gbFormulario = new GroupBox();
            gbCampos = new GroupBox();
            cbCategoria = new ComboBox();
            lblCategoria = new Label();
            lblStock = new Label();
            txtStock = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            gbControles = new GroupBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).BeginInit();
            gbFormulario.SuspendLayout();
            gbCampos.SuspendLayout();
            gbControles.SuspendLayout();
            SuspendLayout();
            // 
            // dtgProductos
            // 
            dtgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProductos.Columns.AddRange(new DataGridViewColumn[] { clId, clNombre, clDescripcion, clMarca, clPrecio, clStock, clCategoria });
            dtgProductos.Dock = DockStyle.Right;
            dtgProductos.Location = new Point(344, 0);
            dtgProductos.Name = "dtgProductos";
            dtgProductos.Size = new Size(778, 486);
            dtgProductos.TabIndex = 0;
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
            // clDescripcion
            // 
            clDescripcion.HeaderText = "Descripcion";
            clDescripcion.Name = "clDescripcion";
            // 
            // clMarca
            // 
            clMarca.HeaderText = "Marca";
            clMarca.Name = "clMarca";
            // 
            // clPrecio
            // 
            clPrecio.HeaderText = "Precio";
            clPrecio.Name = "clPrecio";
            // 
            // clStock
            // 
            clStock.HeaderText = "Stock";
            clStock.Name = "clStock";
            // 
            // clCategoria
            // 
            clCategoria.HeaderText = "Categoria ID";
            clCategoria.Name = "clCategoria";
            // 
            // gbFormulario
            // 
            gbFormulario.Controls.Add(gbCampos);
            gbFormulario.Controls.Add(gbControles);
            gbFormulario.Dock = DockStyle.Left;
            gbFormulario.Location = new Point(0, 0);
            gbFormulario.Name = "gbFormulario";
            gbFormulario.Size = new Size(345, 486);
            gbFormulario.TabIndex = 16;
            gbFormulario.TabStop = false;
            // 
            // gbCampos
            // 
            gbCampos.Controls.Add(cbCategoria);
            gbCampos.Controls.Add(lblCategoria);
            gbCampos.Controls.Add(lblStock);
            gbCampos.Controls.Add(txtStock);
            gbCampos.Controls.Add(lblPrecio);
            gbCampos.Controls.Add(txtPrecio);
            gbCampos.Controls.Add(lblMarca);
            gbCampos.Controls.Add(txtMarca);
            gbCampos.Controls.Add(lblDescripcion);
            gbCampos.Controls.Add(txtDescripcion);
            gbCampos.Controls.Add(lblNombre);
            gbCampos.Controls.Add(txtNombre);
            gbCampos.Location = new Point(6, 13);
            gbCampos.Name = "gbCampos";
            gbCampos.Size = new Size(333, 355);
            gbCampos.TabIndex = 24;
            gbCampos.TabStop = false;
            // 
            // cbCategoria
            // 
            cbCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(130, 273);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(195, 29);
            cbCategoria.TabIndex = 38;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F);
            lblCategoria.Location = new Point(15, 271);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 21);
            lblCategoria.TabIndex = 37;
            lblCategoria.Text = "Categoría";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F);
            lblStock.Location = new Point(15, 222);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(47, 21);
            lblStock.TabIndex = 36;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 12F);
            txtStock.Location = new Point(130, 222);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(195, 29);
            txtStock.TabIndex = 35;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F);
            lblPrecio.Location = new Point(15, 168);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 21);
            lblPrecio.TabIndex = 34;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.Location = new Point(130, 168);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(195, 29);
            txtPrecio.TabIndex = 33;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 12F);
            lblMarca.Location = new Point(15, 119);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 21);
            lblMarca.TabIndex = 32;
            lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 12F);
            txtMarca.Location = new Point(130, 119);
            txtMarca.Multiline = true;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(195, 29);
            txtMarca.TabIndex = 31;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F);
            lblDescripcion.Location = new Point(15, 68);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 21);
            lblDescripcion.TabIndex = 30;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.Location = new Point(130, 68);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(195, 29);
            txtDescripcion.TabIndex = 29;
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
            gbControles.Location = new Point(6, 369);
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
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 486);
            Controls.Add(gbFormulario);
            Controls.Add(dtgProductos);
            Name = "frmProductos";
            Text = "Productos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProductos).EndInit();
            gbFormulario.ResumeLayout(false);
            gbCampos.ResumeLayout(false);
            gbCampos.PerformLayout();
            gbControles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgProductos;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clNombre;
        private DataGridViewTextBoxColumn clDescripcion;
        private DataGridViewTextBoxColumn clMarca;
        private DataGridViewTextBoxColumn clPrecio;
        private DataGridViewTextBoxColumn clStock;
        private DataGridViewTextBoxColumn clCategoria;
        private GroupBox gbFormulario;
        private Button btnIngresar;
        private Button btnInsertar;
        private Button btnCancelar;
        private Button btnModificar;
        private Button btnActualizar;
        private Button btnEliminar;
        private GroupBox gbControles;
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
        private TextBox txtNombre;
    }
}