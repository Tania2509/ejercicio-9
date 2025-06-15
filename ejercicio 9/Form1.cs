using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precioArticulo, dinero, cambio;

            if (double.TryParse(txtPrecioArticulo.Text, out precioArticulo) && double.TryParse(txtDineroCantidad.Text, out dinero) )
            {

                if (precioArticulo >= 0 || dinero >= 0)
                {
                    cambio = dinero - precioArticulo;
                    txtCambio.Text = cambio.ToString("N2");
                }                        

                else
                {
                    lblError.Text = "Ingrese numeros positivos";
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtPrecioArticulo.Text) || string.IsNullOrEmpty(txtDineroCantidad.Text))
                {
                    lblError.Text = "Existe un campo vacio";
                }

                else
                {
                    lblError.Text = "Ingresa numeros y no letras";
                }
            }
            txtDineroCantidad.ReadOnly = true;
            txtPrecioArticulo.ReadOnly = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDineroCantidad.Clear();
            txtPrecioArticulo.Clear();
            txtCambio.Clear();
            lblError.Text = "Error:";
            txtDineroCantidad.ReadOnly = false;
            txtPrecioArticulo.ReadOnly = false;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
