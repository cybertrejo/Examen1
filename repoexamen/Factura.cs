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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            menuPrincipal menuPrincipal = new menuPrincipal();
          this.Hide();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            decimal cantidad = Convert.ToDecimal(txtCantidad.Text);

            decimal Total = await TotalAsync(precio, cantidad);

            txtTotal.Text = Total.ToString();

        }

        private async Task<decimal> TotalAsync(decimal precio, decimal cantidad)
        {
            decimal SubTotal = await Task.Run(() =>
            {
                return precio * cantidad;
            });

            decimal descuento = await Task.Run(() =>
            {
                return SubTotal * 0.15M;
            });

            decimal total = await Task.Run(() =>
            {
                return SubTotal - descuento;
            });
            return total;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
            txtProducto.Focus();
        }
    }

}
