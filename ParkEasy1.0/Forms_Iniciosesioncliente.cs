using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkEasy1._0
{
    public partial class Forms_Iniciosesioncliente : Form
    {
        public static ClaseUsuario usuarioRegistrado;

        public Forms_Iniciosesioncliente()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioRegistrado = new ClaseUsuario 
            {
                Nombre = textBox1.Text,
                Apellido = textBox2.Text,
                DNI = textBox3.Text,
                Edad = int.Parse(textBox4.Text),
                Direccion = textBox5.Text,
                Sexo = radioButton1.Checked ? "Hombre" : "Mujer",
                Correo = textBox6.Text,
                Contraseña = textBox7.Text,
                ModeloDeCarro = textBox8.Text
            };

            MessageBox.Show("Registro exitoso!");

            // Abrir el formulario de inicio de sesión
            Form2 formInicioSesion = new Form2();
            formInicioSesion.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
