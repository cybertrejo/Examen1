using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repoexamen
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura P = new Factura();
            P.Show();
            P.MdiParent = this;
        }

        private void calcularInteresesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcularIntereses p = new CalcularIntereses();
            p.Show();
            p.MdiParent = this;
        }

        private void mostrarNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostradorNumeros p = new MostradorNumeros(); 
            p.Show();
            p.MdiParent = this;
        }
        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
