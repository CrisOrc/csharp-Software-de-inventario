using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Logic
{
    internal class UsePanel
    {
        private Panel panel;
        public UsePanel(Panel panel)
        {
            this.panel = panel;
        }
        public void OpenChildForm(Form ChildForm)
        {
            if (this.panel.Controls.Count > 0) this.panel.Controls.RemoveAt(0);
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            this.panel.Controls.Add(ChildForm);
            this.panel.Tag = ChildForm;
            ChildForm.Show();
        }
        public void CloseChildForm()
        {
            if (this.panel.Controls.Count > 0) this.panel.Controls.RemoveAt(0);
        }
    }
}

