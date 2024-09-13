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
    public partial class frmClientes : Form
    {
        private static frmClientes instancia = null;
        private string idSeleccionado = null;

        public static frmClientes VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmClientes();
                return instancia;
            }
            return instancia;
        }

        private bool Validar()
        {
            bool nombre = Validacion.Validacion.CampoVacio(txtNombre.Text, lblMensajeNombre);
            bool email = Validacion.Validacion.Email(txtEmail.Text, lblMensajeEmail);
            bool telefono = Validacion.Validacion.Entero(txtTelefono.Text, 10, lblMensajeTelefono);
            return nombre && email && telefono;
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
            txtEmail.Text = "";
            lblMensajeEmail.Text = "";
            txtTelefono.Text = "";
            lblMensajeTelefono.Text = "";
        }

        private void ActualizarDTG()
        {
            conCliente conCliente = new conCliente();
            DataTable data = conCliente.MostrarClientes();
            dtgClientes.DataSource = data;
        }

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ReiniciarForm();
            this.BackColor = Color.FromArgb(255, 255, 255);
            lblMensajeNombre.ForeColor = Color.FromArgb(229, 57, 53);
            lblMensajeEmail.ForeColor = Color.FromArgb(229, 57, 53);
            lblMensajeTelefono.ForeColor = Color.FromArgb(229, 57, 53);
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
            //TODO: arreglar
            if (Validar() is false) return;
            conCliente conClientes = new conCliente();
            conClientes.InsertarClientes(txtNombre.Text, txtEmail.Text, txtTelefono.Text);
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
            if (Validar() is false)return; 
            conCliente conCliente = new conCliente();
            conCliente.EditarClientes(txtNombre.Text, txtEmail.Text, txtTelefono.Text, this.idSeleccionado);
            ReiniciarForm();
        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbCampos.Enabled = false;
            txtNombre.Text = dtgClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dtgClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefono.Text = dtgClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnIngresar.Enabled = false;

            btnCancelar.Enabled = true;
            this.idSeleccionado = dtgClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void frmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmClientes.instancia = null;
        }
    }
}
