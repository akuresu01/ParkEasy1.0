using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkEasy1._0
{
    public class DatosdePropietario
    {
        public string Nombre { get; set; }
        public int EspaciosDisponibles { get; set; }
        public string Direccion { get; set; }
        public string Contrasena { get; set; }
        public List<string> Servicios { get; set; }
        public List<string> Horario { get; set; }
         
    }
}
