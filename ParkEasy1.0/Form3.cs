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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Forms_Iniciosesioncliente.usuarioRegistrado.Correo && textBox2.Text == Forms_Iniciosesioncliente.usuarioRegistrado.Contraseña)
            {
                MessageBox.Show("Inicio de sesión exitoso!");
                // Aquí puedes abrir el siguiente formulario o la funcionalidad principal de tu aplicación
                Form4 mainForm = new Form4();
                mainForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.");
            }
        }
    }
}
