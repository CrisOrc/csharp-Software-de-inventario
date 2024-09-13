using Negocios;
using Presentacion.Vistas;

namespace crud
{
    public partial class frmMain : Form
    {
        private conProducto Producto = new conProducto();
        private string idProducto = "";

        private bool Editar = false;

        public frmMain()
        {
            InitializeComponent();
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

        private void msiFacturacion_Click(object sender, EventArgs e)
        {
            frmFacturacion frm = frmFacturacion.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
