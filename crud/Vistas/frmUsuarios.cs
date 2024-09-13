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
    public partial class frmUsuarios : Form
    {
        private static frmUsuarios instancia = null;
        private string idSeleccionado = null;

        public static frmUsuarios VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmUsuarios();
                return instancia;
            }
            return instancia;
        }

        private bool Validar()
        {
            bool username = Validacion.Validacion.CampoVacio(txtUsername.Text, lblMensajeUsername);
            bool email = Validacion.Validacion.Email(txtEmail.Text, lblMensajeEmail);
            bool password = Validacion.Validacion.Contraseña(txtPassword.Text, lblMensajePassword);
            bool roll = Validacion.Validacion.CampoVacio(txtRoll.Text, lblMensajeRoll);
            return username && email && password && roll;
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
            txtUsername.Text = "";
            lblMensajeUsername.Text = "";
            txtEmail.Text = "";
            lblMensajeEmail.Text = "";
            txtPassword.Text = "";
            lblMensajePassword.Text = "";
            txtRoll.Text = "";
            lblMensajeRoll.Text = "";
        }

        private void ActualizarDTG()
        {
            conUsuarios conUsuarios = new conUsuarios();
            DataTable data = conUsuarios.Mostrar();
            dtgUsuarios.DataSource = data;
        }

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ReiniciarForm();
            this.BackColor = Color.FromArgb(255, 255, 255);
            lblMensajeUsername.ForeColor = Color.FromArgb(229, 57, 53);
            lblMensajeEmail.ForeColor = Color.FromArgb(229, 57, 53);
            lblMensajePassword.ForeColor = Color.FromArgb(229, 57, 53);
            lblMensajeRoll.ForeColor = Color.FromArgb(229, 57, 53);
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
            if (Validar() is false) return;
            conUsuarios conUsuarios = new conUsuarios();
            conUsuarios.InsertarUsuarios(txtUsername.Text, txtEmail.Text, txtPassword.Text, txtRoll.Text);
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
            conUsuarios conUsuarios = new conUsuarios();
            conUsuarios.EditarUsuarios(txtUsername.Text, txtEmail.Text, txtPassword.Text, txtRoll.Text, this.idSeleccionado);
            ReiniciarForm();
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbCampos.Enabled = false;
            txtUsername.Text = dtgUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dtgUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dtgUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRoll.Text = dtgUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPassword.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnIngresar.Enabled = false;

            btnCancelar.Enabled = true;
            this.idSeleccionado = dtgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void frmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmUsuarios.instancia = null;
        }
    }
}
