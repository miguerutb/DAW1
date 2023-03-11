using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBancariaAppNS
{
    public partial class GestionBancariaApp : Form
    {
        private double saldo;  
        public const string ERR_CANTIDAD_NO_VALIDA = "Cantidad no válida, sólo se admiten cantidades positivas.";
        public const string ERR_SALDO_INSUFICIENTE = "No se ha podido realizar la operación (¿Saldo insuficiente?)";

        public GestionBancariaApp(double saldo = 0)
        {
            InitializeComponent();
            if (saldo > 0)
                this.saldo = saldo;
            else
                this.saldo = 0;
            txtSaldo.Text = ObtenerSaldo().ToString();
            txtCantidad.Text = "0";
        }

        public double ObtenerSaldo() { return saldo; }

        public void RealizarReintegro(double cantidad) 
        {
            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(ERR_CANTIDAD_NO_VALIDA);
            if (saldo < cantidad)
                throw new ArgumentOutOfRangeException(ERR_SALDO_INSUFICIENTE);
            saldo -= cantidad;
        }

        public void RealizarIngreso(double cantidad) {
            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(ERR_CANTIDAD_NO_VALIDA);
            saldo += cantidad;
        }

        private void btOperar_Click(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(txtCantidad.Text); // Cogemos la cantidad del TextBox y la pasamos a número
            try
            {
                if (rbReintegro.Checked)
                {
                    RealizarReintegro(cantidad);
                    MessageBox.Show("Transacción realizada.");
                }
                else {
                    RealizarIngreso(cantidad);
                    MessageBox.Show("Transacción realizada.");
                }
            } catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
           txtSaldo.Text = ObtenerSaldo().ToString();
        }
    }
}
