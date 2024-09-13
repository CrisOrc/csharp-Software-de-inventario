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
    public partial class frmClientes : Form
    {
        private static frmClientes instancia = null;

        public static frmClientes VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmClientes();
                return instancia;
            }
            return instancia;
        }

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ReiniciarForm();
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
            txtEmail.Text = "";
            txtTelefono.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
    }
}
