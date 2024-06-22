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
    public partial class FormContrasenaPropietario : Form
    {
        public FormContrasenaPropietario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Forms_Login_SocialMedia.estacionamientoRegistrado.Nombre && textBox2.Text == Forms_Login_SocialMedia.estacionamientoRegistrado.Contrasena)
            {
                MessageBox.Show("Inicio de sesión exitoso!");
                // Aquí puedes abrir el siguiente formulario o la funcionalidad principal de tu aplicación
                PrimeraPantallaSesion mainForm = new PrimeraPantallaSesion();
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
