using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Biblioteca
{
    public partial class CrearUsuario : Form
    {
        Administracion administracion;
        public CrearUsuario(Administracion admin)
        {
            InitializeComponent();
            administracion = admin;
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            comboRol.Items.Add("lector");
            comboRol.Items.Add("bibliotecario");
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crear_Usuario();
        }

        private void Crear_Usuario()
        {
            string usuario = textUsuario.Text;
            string nombre = textNombre.Text;
            string rol = comboRol.Text;
            string contraseña = textContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (!administracion.VerificarUsuarios(usuario))
            {  Usuario nuevoUsuario = new Usuario(usuario, nombre, contraseña, rol);
                administracion.AgregarUsuario(nuevoUsuario);
               
                MessageBox.Show("Usuario creado exitosamente.");
            }
            else
            {
                MessageBox.Show("El usuario ya existe.");
            }
        }


    }
}
