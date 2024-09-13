using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vistas
{
    public partial class frmProductos : Form
    {
        private static frmProductos instancia = null;
        private string idSeleccionado = null;

        public static frmProductos VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmProductos();
                return instancia;
            }
            return instancia;
        }

        private bool Validar()
        {
            bool nombre = Validacion.Validacion.SoloTexto(txtNombre.Text, lblMensajeNombre);
            bool descripcion = Validacion.Validacion.CampoVacio(txtDescripcion.Text, lblMensajeDescripcion);
            bool marca = Validacion.Validacion.CampoVacio(txtMarca.Text, lblMensajeMarca);
            bool precio = Validacion.Validacion.Decimal(txtPrecio.Text, 9, lblMensajePrecio);
            bool stock = Validacion.Validacion.Entero(txtStock.Text, 9, lblMensajeStock);
            bool categoria = cbCategoria.SelectedIndex != -1;
            if (categoria is false) lblMensajeCategoria.Text = "Debes seleccionar una categoria.";
            return nombre && descripcion && marca && precio && stock && categoria;
        }

        private void ReiniciarForm()
        {
            gbCampos.Enabled = false;
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnModificar.Enabled = false;
            btnModificar.Visible = true;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            btnIngresar.Enabled = true;
            btnIngresar.Visible = true;
            btnInsertar.Visible = false;
            this.idSeleccionado = null;
            ActualizarDTG();
            txtNombre.Text = "";
            lblMensajeNombre.Text = "";
            txtDescripcion.Text = "";
            lblMensajeDescripcion.Text = "";
            txtMarca.Text = "";
            lblMensajeMarca.Text = "";
            txtPrecio.Text = "";
            lblMensajePrecio.Text = "";
            txtStock.Text = "";
            lblMensajeStock.Text = "";
            lblMensajeCategoria.Text = "";
            cbCategoria.SelectedIndex = -1;
        }

        private void ActualizarDTG()
        {
            conProducto conProducto = new conProducto();
            DataTable data = conProducto.MostrarProd();
            dtgProductos.DataSource = data;
        }

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            ReiniciarForm();
            this.BackColor = Color.FromArgb(255, 255, 255);
            lblMensajeNombre.ForeColor = Color.FromArgb(229, 57, 53);
            lblMensajeDescripcion.ForeColor = Color.FromArgb(229, 57, 53);
            lblMensajeMarca.ForeColor = Color.FromArgb(229, 57, 53);
            lblMensajePrecio.ForeColor = Color.FromArgb(229, 57, 53);
            lblMensajeStock.ForeColor = Color.FromArgb(229, 57, 53);
            lblMensajeCategoria.ForeColor = Color.FromArgb(229, 57, 53);

            conCategoria conCategoria = new conCategoria();
            DataTable data = conCategoria.Mostrar_Categoria();
            cbCategoria.DataSource = data;
            //DataView dataView = new DataView(data);
            //dataView.Sort = "nombre ASC";
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Id";
            cbCategoria.SelectedIndex = -1;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnIngresar.Visible = false;
            btnInsertar.Visible = true;
            gbCampos.Enabled = true;
            txtNombre.Focus();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() is false) return;
            conProducto conProducto = new conProducto();
            int idProducto = Convert.ToInt32(cbCategoria.SelectedValue);
            conProducto.Insertar(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
            ReiniciarForm();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnModificar.Visible = false;
            btnActualizar.Visible = true;
            gbCampos.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Validar() is false) return;
            conProducto conProducto = new conProducto();
            int categoria = Convert.ToInt32(cbCategoria.SelectedValue);
            conProducto.Editar(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, categoria, this.idSeleccionado);
            ReiniciarForm();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ReiniciarForm();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbCampos.Enabled = false;
            txtNombre.Text = dtgProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescripcion.Text = dtgProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMarca.Text = dtgProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrecio.Text = dtgProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtStock.Text = dtgProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbCategoria.SelectedValue = int.Parse(dtgProductos.Rows[e.RowIndex].Cells[6].Value.ToString());
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnIngresar.Enabled = false;
            btnCancelar.Enabled = true;
            this.idSeleccionado = dtgProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void frmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProductos.instancia = null;
        }
    }
}
