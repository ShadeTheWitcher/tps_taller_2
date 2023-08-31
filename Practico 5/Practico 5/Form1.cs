using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text !="" && textBox2.Text != "" && textBox3.Text != "" && txtFoto.Text != "")
            {

            

            // Obtén el valor del DateTimePicker
            DateTime fecha = dateTimePicker1.Value;

            // Formatea la fecha como una cadena en formato corto
            string fechaFormateada = fecha.ToString("d"); // "d" representa el formato corto




            string genero = string.Empty;

            if (radioButton1.Checked)
            {
                genero = "Hombre";
            }
            else if (radioButton2.Checked)
            {
                genero = "Mujer";
            }


            int saldo = int.Parse(textBox3.Text);



                Image imagenOriginal = pictureBox1.Image;

                // Cambiar el tamaño de la imagen
                int nuevoAncho = 100;
                int nuevoAlto = 100;
                Image imagenRedimensionada = new Bitmap(imagenOriginal, nuevoAncho, nuevoAlto);

                // Asignar la imagen redimensionada al botón
                Image foto = imagenRedimensionada;

                tablaClientes.Rows.Add(
                textBox1.Text,
                textBox2.Text,
                fechaFormateada,
                genero,
                "",
                saldo,
                foto,
                txtFoto.Text
            
                ); //agrega los datos a la tabla

            

            // Limpia los TextBox después de guardar
            textBox1.Clear();
            textBox2.Clear();

            }
            else
            {
                MessageBox.Show("Se produjo un error. Por favor, ingrese todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\"; // Cambia la ruta según tu ubicación.
            openFileDialog1.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                txtFoto.Text = openFileDialog1.FileName;


                // Crear una carpeta "Images" dentro de la carpeta del proyecto
                string carpetaDestino = Path.Combine(Application.StartupPath, "Fotos");
                Directory.CreateDirectory(carpetaDestino);

                // Obtener el nombre del archivo
                string nombreArchivo = Path.GetFileName(openFileDialog1.FileName);

                // Combinar la carpeta de destino con el nombre del archivo
                string rutaArchivoDestino = Path.Combine(carpetaDestino, nombreArchivo);

                try
                {
                    // Copiar el archivo a la carpeta de destino
                    File.Copy(openFileDialog1.FileName, rutaArchivoDestino);

                    // Ahora tienes la imagen guardada en 'rutaArchivoDestino'
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                // Capitaliza la primera letra y convierte el resto en minúsculas
                textBox1.Text = char.ToUpper(textBox1.Text[0]) + textBox1.Text.Substring(1).ToLower();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                // Capitaliza la primera letra y convierte el resto en minúsculas
                textBox2.Text = char.ToUpper(textBox2.Text[0]) + textBox2.Text.Substring(1).ToLower();
            }
        }

        private void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0) // seleccionamos la columna donde tenemos el boton eliminar que va de 0-1-2 
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) { 


                    if (tablaClientes.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                {
                    // Se hizo clic en el botón de eliminación
                    int rowIndex = e.RowIndex; // Obtiene el índice de la fila
                    tablaClientes.Rows.RemoveAt(rowIndex); // Elimina la fila del DataGridView
                }

                }
            }


        }

        private void tablaClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == tablaClientes.Columns[0].Index ||  //el 0 es la posicion de la 1ra colum
                e.ColumnIndex == tablaClientes.Columns["Column2"].Index)   // Apellido, tmb se puede usar el nombre de la columna
            {
                // Cambia la fuente solo para la columna Nombre
                e.CellStyle.Font = new Font("MV Boli", 12); // Puedes ajustar la fuente según tus preferencias
            }


            if (e.ColumnIndex == tablaClientes.Columns["Column6"].Index) //  columna de saldo
            {
                if (e.Value != null  )
                {
                    int saldo = (int)e.Value;
                    if (saldo < 50)
                    {
                        tablaClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
