using Negocios;

namespace crud
{
    public partial class frmMain : Form
    {
        private conProducto Producto = new conProducto();
        private string idProducto = null;
<<<<<<< HEAD
<<<<<<< HEAD
        private bool Editar = false;*/

        //UsePanel panel = null;
=======
        private bool Editar = false;
>>>>>>> 2914e63593496e9aad8764326fb9ed1aa70ff47d
=======
        private bool Editar = false;
>>>>>>> 2914e63593496e9aad8764326fb9ed1aa70ff47d

        public frmMain()
        {
            InitializeComponent();
<<<<<<< HEAD
<<<<<<< HEAD
            //panel = new UsePanel(pnlVistas);
        }

        private void msiGestionProductos_Click(object sender, EventArgs e)
        {
            frmProductos frm = frmProductos.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msiCategoriaProductos_Click(object sender, EventArgs e)
        {
            frmCategoriaProductos frm = frmCategoriaProductos.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msiUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = frmUsuarios.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msiClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = frmClientes.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mediosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMediosPago frm = frmMediosPago.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
        }


        /*private void msiInicio_Click(object sender, EventArgs e)
        {
            //panel.CloseChildForm();
=======
>>>>>>> 2914e63593496e9aad8764326fb9ed1aa70ff47d
=======
>>>>>>> 2914e63593496e9aad8764326fb9ed1aa70ff47d
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void msiGestionProductos_Click(object sender, EventArgs e)
        {
            panel.OpenChildForm(new frmProductos());
        }

        private void msiCategoriaProductos_Click(object sender, EventArgs e)
        {
            panel.OpenChildForm(new frmCategoriaProductos());
        }

        private void msiUsuarios_Click(object sender, EventArgs e)
        {
            panel.OpenChildForm(new frmUsuarios());
        }

        private void msiClientes_Click(object sender, EventArgs e)
        {
            panel.OpenChildForm(new frmClientes());
        }

        private void mediosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenChildForm(new frmMediosPago());
        }*/



        /*private void MostrarProductos()
=======
        private void MostrarProductos()
>>>>>>> 2914e63593496e9aad8764326fb9ed1aa70ff47d
=======
        private void MostrarProductos()
>>>>>>> 2914e63593496e9aad8764326fb9ed1aa70ff47d
        {
            conProducto objeto = new conProducto();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    Producto.InsertarPRod(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarProductos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    Producto.EditarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
                    MessageBox.Show("se edito correctamente");
                    MostrarProductos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void limpiarForm()
        {
            txtDesc.Clear();
            txtMarca.Text = "";
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                Producto.EliminarPRod(idProducto);
                MessageBox.Show("Eliminado correctamente");
                MostrarProductos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text = Producto.getNombre((int)numericUpDown1.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text = Convert.ToString(Producto.Contar());
        }
    }
}
