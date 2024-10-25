namespace Biblioteca
{
    public partial class From1 : Form
    {
        private Administracion administrador;
        public From1(Administracion admin)
        {
            InitializeComponent();
            administrador = admin;
            // Usar el RGB (111, 78, 55) para establecer un color marr�n oscuro
            // this.BackColor = System.Drawing.Color.FromArgb(111, 78, 55);
            //this.BackColor = System.Drawing.Color.FromArgb(128, 64, 0);
            //this.BackColor = System.Drawing.Color.FromArgb(25, 11, 5);
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrearUsuario crear = new CrearUsuario(administrador);
            crear.Show();
        }

        private void textIngresarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIngresarContrase�a_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string username = textIngresarUsuario.Text;
            string password = textIngresarContrase�a.Text;

            if (administrador.Login(username, password))
            {
                MessageBox.Show("Login exitoso");
                // Aqu� puedes abrir el siguiente formulario y pasar la instancia de administrador
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }

        }
    }
}
