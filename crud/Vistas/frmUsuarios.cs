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
    public partial class frmUsuarios : Form
    {
        private static frmUsuarios instancia = null;

        public static frmUsuarios VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmUsuarios();
                return instancia;
            }
            return instancia;
        }

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
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
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
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
            txtUsername.Focus();
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
