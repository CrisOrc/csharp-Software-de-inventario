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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            txtResult = new TextBox();
            button1 = new Button();
            label5 = new Label();
            txtStock = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtMarca = new TextBox();
            label2 = new Label();
            txtDesc = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(636, 341);
            dataGridView1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(238, 356);
            button2.Name = "button2";
            button2.Size = new Size(112, 35);
            button2.TabIndex = 12;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(381, 356);
            button3.Name = "button3";
            button3.Size = new Size(112, 35);
            button3.TabIndex = 13;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDesc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 500);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtResult);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(3, 353);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 144);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Comandos";
            // 
            // button5
            // 
            button5.Location = new Point(108, 43);
            button5.Name = "button5";
            button5.Size = new Size(95, 31);
            button5.TabIndex = 30;
            button5.Text = "Nombre";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(108, 75);
            button4.Name = "button4";
            button4.Size = new Size(95, 31);
            button4.TabIndex = 29;
            button4.Text = "Contar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 31);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 28;
            label7.Text = "ID";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(17, 49);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 23);
            numericUpDown1.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 94);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 26;
            label6.Text = "Resultado";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(17, 112);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(186, 23);
            txtResult.TabIndex = 25;
            // 
            // button1
            // 
            button1.Location = new Point(12, 297);
            button1.Name = "button1";
            button1.Size = new Size(194, 33);
            button1.TabIndex = 22;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 241);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 21;
            label5.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(12, 259);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(194, 23);
            txtStock.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 19;
            label4.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 205);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(194, 23);
            txtPrecio.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 17;
            label3.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 149);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(194, 23);
            txtMarca.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 15;
            label2.Text = "Descripción:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(12, 96);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(194, 23);
            txtDesc.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 12;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 500);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Name = "frmMain";
            Text = "Inventario";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Button button1;
        private Label label5;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtMarca;
        private Label label2;
        private TextBox txtDesc;
        private Label label1;
        private TextBox txtNombre;
        private GroupBox groupBox2;
        private Button button5;
        private Button button4;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private TextBox txtResult;
    }
}
