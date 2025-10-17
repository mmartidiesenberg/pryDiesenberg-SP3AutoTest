using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenberg_SP3AutoTest
{
    public partial class frmAutotest : Form
    {
        public frmAutotest()
        {
            InitializeComponent();
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
            // Sacamos espacios por las dudas
            string texto = txtDominio.Text.Trim();

            // Si tiene menos de 6 caracteres, marcamos en rojo
            if (texto.Length < 6)
            {
                txtDominio.BackColor = Color.LightPink;
            }
            else
            {
                txtDominio.BackColor = SystemColors.Window;
            }
        }

        private void txtDominio_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras mayúsculas y números
            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }
    }
}



