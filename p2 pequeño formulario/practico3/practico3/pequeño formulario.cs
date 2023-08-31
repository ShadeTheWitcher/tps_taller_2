namespace practico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDni.Text) || string.IsNullOrWhiteSpace(TApellido.Text) || string.IsNullOrWhiteSpace(TNombre.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                string nombreCompleto = TNombre.Text + " " + TApellido.Text;
                MessageBox.Show($"El Cliente: {nombreCompleto} se insertó correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LModificar.Text = nombreCompleto;
            }

            TDni.Clear();
            TApellido.Clear();
            TNombre.Clear();


        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show($"Está a punto de eliminar el Cliente: {LModificar.Text}",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2); //msgboxdefaul es el "focus" osea el enfoque donde ira a seleccionar por defecto la opcion

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show($"El Cliente: {LModificar.Text} se eliminó correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();
                LModificar.Text = "";
            }
        }
    }
}