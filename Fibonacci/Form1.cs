using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int SerieFibonacci(int numero)
        {
            if(numero<=1)
            {
                return numero;
            }
            else
            {
                return SerieFibonacci(numero - 1) + SerieFibonacci(numero - 2);
            }
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text == String.Empty || txtNumero.Text == "Cantidad")
            {
                MessageBox.Show("Agregue una cantidad para iniciar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                int n = Int16.Parse(txtNumero.Text);
                txtNumero.Text = "Cantidad";
                txtNumero.ForeColor = Color.Gray;
                lblSerie.Text = "";
                for (int i = 0; i < n; i++)
                {
                    lblSerie.Text += (SerieFibonacci(i) + "  ").ToString();
                }
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            if (txtNumero.Text == "Cantidad")
            {
                txtNumero.Text = "";
                txtNumero.ForeColor = Color.Black;
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                txtNumero.Text = "Cantidad";
                txtNumero.ForeColor = Color.Gray;
            }
        }
    }
}
