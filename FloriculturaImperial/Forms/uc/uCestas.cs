using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloriculturaImperial.Forms.uc
{
    public partial class uCestas : UserControl
    {
        public uCestas()
        {
            InitializeComponent();

            //Default
            ucMontarCesta mc = new ucMontarCesta();
            mc.Dock = DockStyle.Fill;
            pnPrincipal.Controls.Add(mc);
        }

        private void btnMontarCestas_Click(object sender, EventArgs e)
        {
            ucMontarCesta mc = new ucMontarCesta();
            mc.Dock = DockStyle.Fill;
            pnPrincipal.Controls.Add(mc);
        }
    }
}
