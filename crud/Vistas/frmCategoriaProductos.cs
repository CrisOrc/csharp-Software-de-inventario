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

        public static frmCategoriaProductos VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmCategoriaProductos();
                return instancia;
            }
            return instancia;
        }

        public frmCategoriaProductos()
        {
            InitializeComponent();
        }

        private void ReiniciarForm()
        {
            gbCampos.Enabled = false;
            btnActualizar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            btnIngresar.Visible = true;
            btnInsertar.Visible = false;
            txtNombre.Text = "";
        }

        private void frmCategoriaProductos_Load(object sender, EventArgs e)
        {
            ReiniciarForm();
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
            //TODO: validaciones frontend y operaciones de insercion de datos
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
            ReiniciarForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ReiniciarForm();
        }
    }
}
