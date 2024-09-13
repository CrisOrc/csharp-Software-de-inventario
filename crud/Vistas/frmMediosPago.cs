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
    public partial class frmMediosPago : Form
    {
        private static frmMediosPago instancia = null;
        private string idSeleccionado = null;

        public static frmMediosPago VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmMediosPago();
                return instancia;
            }
            return instancia;
        }

        private bool Validar()
        {
            bool metodo = Validacion.Validacion.SoloTexto(txtMetodo.Text,lblMensajeMetodo);
            return metodo;
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
            txtMetodo.Text = "";
            lblMensajeMetodo.Text = "";
        }

        private void ActualizarDTG()
        {
            conMedioPago conMedioPago = new conMedioPago();
            DataTable data = conMedioPago.MostrarMediosPago();
            dtgProductos.DataSource = data;
        }

        public frmMediosPago()
        {
            InitializeComponent();
        }

        private void frmMediosPago_Load(object sender, EventArgs e)
        {
            ReiniciarForm();
            this.BackColor = Color.FromArgb(255, 255, 255);
            lblMensajeMetodo.ForeColor = Color.FromArgb(229, 57, 53);
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
            if (Validar() is false) return;
            conMedioPago conMedioPago = new conMedioPago();
            conMedioPago.InsertarMediosPago(txtMetodo.Text);
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

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMediosPago_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
