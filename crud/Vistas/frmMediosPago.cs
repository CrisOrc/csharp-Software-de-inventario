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
    public partial class frmMediosPago : Form
    {
        private static frmMediosPago instancia = null;

        public static frmMediosPago VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmMediosPago();
                return instancia;
            }
            return instancia;
        }

        public frmMediosPago()
        {
            InitializeComponent();
        }

        private void frmMediosPago_Load(object sender, EventArgs e)
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
            txtMetodo.Text = "";
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
            txtMetodo.Focus();
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
