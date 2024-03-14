using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class Persona
    {
        public int IdPersona { get; set; }
        public int Nombre { get; set; }
        public int Apellido { get; set; }
        public int Telefono { get; set; }
        public int Ci { get; set; }
        public DateTime Fecha { get; set; }
    }
}
