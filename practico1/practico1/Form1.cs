namespace practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apellido = this.textBox1.Text;
            string nombre = this.textBox2.Text;

            textBox3.Text = textBox3.Text + nombre + " " + apellido + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Finalizar la aplicación
            Environment.Exit(0);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Si Ctrl y S están presionadas al mismo tiempo, cierra el formulario
                this.Close();
            }
        }
    }
}