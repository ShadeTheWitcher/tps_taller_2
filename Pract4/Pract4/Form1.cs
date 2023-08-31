using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación: Asegúrate de que el campo no esté vacío y solo contenga números.
            if (!int.TryParse(textBox1.Text, out int numero1) || !int.TryParse(textBox2.Text, out int numero2))
            {
                MessageBox.Show("Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpia la lista actual
            listBox1.Items.Clear();

            // Genera y agrega los números al ListBox
            for (int i = numero1; i <= numero2; i++)
            {
                listBox1.Items.Add(i);
            }


            chart1.Series[0].Points.DataBind(listBox1.Items, "Text", "Tag", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(textBox1.Text, out int numero1) || !int.TryParse(textBox2.Text, out int numero2))
            {
                MessageBox.Show("Ingrese números válidos en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = numero1; i <= numero2; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }


            chart1.Series[0].Points.DataBind(listBox1.Items, "Text", "Tag", "");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(textBox1.Text, out int numero1) || !int.TryParse(textBox2.Text, out int numero2))
            {
                MessageBox.Show("Ingrese números válidos en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = numero1; i <= numero2; i++)
            {
                if (i % 2 != 0)
                {
                    listBox1.Items.Add(i);
                }
            }


            chart1.Series[0].Points.DataBind(listBox1.Items, "Text", "Tag", "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(textBox1.Text, out int numero1) || !int.TryParse(textBox2.Text, out int numero2))
            {
                MessageBox.Show("Ingrese números válidos en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = numero1; i <= numero2; i++)
            {
                if (EsPrimo(i))
                {
                    listBox1.Items.Add(i);
                }
            }

            chart1.Series[0].Points.DataBind(listBox1.Items, "Text", "Tag", "");
        }



        // Función para verificar si un número es primo
        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }



}
