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
    public partial class Forms_Login_SocialMedia : Form
    {
        public static DatosdePropietario estacionamientoRegistrado;
        public Forms_Login_SocialMedia()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            estacionamientoRegistrado = new DatosdePropietario
            {
                Nombre = textBox1.Text,
                EspaciosDisponibles = int.Parse(textBox2.Text),
                Direccion = textBox4.Text,
                Contrasena = textBox3.Text,
                // Capturar los servicios seleccionados
                Servicios = checkedListBox1.SelectedItems.Cast<string>().ToList(),
                // Capturar el horario seleccionado
                Horario = checkedListBox2.CheckedItems.Cast<string>().ToList()
            };

            MessageBox.Show("Registro exitoso!");

            // Abrir el formulario de inicio de sesión
            FormContrasenaPropietario formInicioSesion = new FormContrasenaPropietario();
            formInicioSesion.Show();
            this.Hide();
        }
    }
}
