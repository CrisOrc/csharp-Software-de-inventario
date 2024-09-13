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
    public partial class frmFacturacion : Form
    {
        private static frmFacturacion instancia = null;
        public frmFacturacion()
        {
            InitializeComponent();
        }

        public static frmFacturacion VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmFacturacion();
                return instancia;
            }
            return instancia;
        }
    }
}
