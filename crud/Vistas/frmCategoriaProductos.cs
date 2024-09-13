using Datos;
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
    public partial class frmCategoriaProductos : Form
    {
        private static frmCategoriaProductos instancia = null;
        private string idSeleccionado = null;

        public static frmCategoriaProductos VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmCategoriaProductos();
                return instancia;
            }
            return instancia;
        }

        private bool Validar()
        {
            bool nombre = Validacion.Validacion.SoloTexto(txtNombre.Text, lblMensajeNombre);
            return nombre;
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
        }

        private void ActualizarDTG()
        {
            conCategoria conCategoria = new conCategoria();
            DataTable data = conCategoria.Mostrar_Categoria();
            dtgCategoriaProductos.DataSource = data;
        }

        public frmCategoriaProductos()
        {
            InitializeComponent();
        }

        private void frmCategoriaProductos_Load(object sender, EventArgs e)
        {
            ReiniciarForm();
            this.BackColor = Color.FromArgb(255, 255, 255);
            lblMensajeNombre.ForeColor = Color.FromArgb(229, 57, 53);
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
            conCategoria conCategoria = new conCategoria();
            conCategoria.InsertarCategoria(txtNombre.Text);
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
            //TODO: validaciones frontend y operaciones de actualización de datos
            if (Validar() is false) return;
            conCategoria conCategoria = new conCategoria();
            conCategoria.EditarCategoria(txtNombre.Text, this.idSeleccionado);
            ReiniciarForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conCategoria conCategoria = new conCategoria();
            conCategoria.EliminarCategoria(this.idSeleccionado);
            ReiniciarForm();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ReiniciarForm();
        }

        private void dtgCategoriaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbCampos.Enabled = false;
            txtNombre.Text = dtgCategoriaProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnIngresar.Enabled = false;
            btnCancelar.Enabled = true;
            this.idSeleccionado = dtgCategoriaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void frmCategoriaProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCategoriaProductos.instancia = null;
        }
    }
}
