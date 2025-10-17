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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitular_Validating(object sender, CancelEventArgs e)
        {
            if (txtTitular.Text.Length < 2)
            {
                MessageBox.Show("El titular debe tener al menos 2 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // evita que el foco se pierda hasta que el usuario corrija
                txtTitular.BackColor = Color.LightPink; // opcional: resalta el error
            }
            else
            {
                txtTitular.BackColor = SystemColors.Window; // vuelve al color normal
            }
        }
    }
}






