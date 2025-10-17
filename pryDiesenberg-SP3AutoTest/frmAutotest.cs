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

        private void txtDominio_Validating(object sender, CancelEventArgs e)
        {
            if (txtDominio.Text.Length < 6)
            {
                MessageBox.Show("Debe Ingresar al Menos 6 Caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
        List<int> numerosUsados = new List<int>();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(mskNumero.Text, out int numero))
            {
                if (numerosUsados.Contains(numero))
                {
                    MessageBox.Show("Ese número de turno ya fue usado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    numerosUsados.Add(numero);
                    MessageBox.Show("Turno guardado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número entero válido.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}






