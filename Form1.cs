namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text;
            string password = TxtPassword.Text;

            // Verificar si el usuario y la contraseña son correctos
            if (usuario == "Rayner" && password == "123")
            {
                MessageBox.Show("¡Usuario BIENVENIDO!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Instanciar y mostrar el formulario de Lista de Productos
                ListadeProductos listaProductosForm = new ListadeProductos();
                listaProductosForm.Show();

                // Opcional: Cerrar el formulario actual después de una autenticación exitosa
                //this.Close();

            }
            else
            {
                MessageBox.Show("Error de usuario o contraseña. Inténtelo de nuevo.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación o realizar alguna otra acción al presionar Cancelar
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}