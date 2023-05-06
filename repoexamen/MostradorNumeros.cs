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
    public partial class MostradorNumeros : Form
    {
        public MostradorNumeros()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuPrincipal menuPrincipal = new menuPrincipal();
            this.Hide();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {

            Multip();
        }
        private static void Multip()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    MessageBox.Show("Stephany Trejo");
                }
                else if (i % 3 == 0)
                {
                    MessageBox.Show("Stephany");
                }
                else if (i % 5 == 0)
                {
                    MessageBox.Show("Trejo");
                }
                else
                {
                    MessageBox.Show("" + i);

                }
            }
        }
    }

}
