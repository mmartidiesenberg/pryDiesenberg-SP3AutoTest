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
        Turno[] turnos = new Turno[100];
        int Cantidad = 0; // contador de turnos cargados

        // Definición de la estructura
        struct Turno
        {
            public int Numero;
            public string Dominio;
            public int AñoFabricacion;
            public string Titular;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDominio.Text.Trim().Length >= 6 &&
             txtTitular.Text.Trim().Length >= 2 &&
             mskNumero.Text.Trim() != "" &&
             nrmAñoFab.Value > 0)
            {
                MessageBox.Show("Registro Exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faltan Datos o Hay Campos Inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // primer consulta: cantidad de turnos registrados
            // se obtiene directamente de la variable 'Cantidad'
            mskCantTurnos.Text = Cantidad.ToString();
            // segunda consulta: se debe recorrer el arreglo y determinar
            // el menor valor del campo 'AnioFabricacion'
            int menor = int.MaxValue; // mayor valor posible
            int pos;
            // recorrer el arreglo hasta la posición con datos
            for (pos = 0; pos < Cantidad; pos++)
            {
                // comparar el valor del elemento en el arreglo
                if (turnos[pos].AñoFabricacion < menor)
                {
                    menor = turnos[pos].AñoFabricacion; // guarda el menor valor
                }
            }
            // mostrar el resultado
            mskMasAntiguo.Text = menor.ToString();
            // tercera consulta: cantidad de vehículos con dominio de 6 caracteres
            int contador = 0; // contador en cero
                              // recorrer el arreglo hasta la posición con datos
            for (pos = 0; pos < Cantidad; pos++)
            {
                // controlar si la longitud del dominio es 6
                if (turnos[pos].Dominio.Length == 6)
                {
                    contador++; // incrementar el contador
                }
            }
            // mostrar el resultado
            mskCant6Caracteres.Text = contador.ToString();
        }
    }
}






