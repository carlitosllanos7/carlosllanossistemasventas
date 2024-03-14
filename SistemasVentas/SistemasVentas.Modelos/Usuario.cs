using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdPersona { get; set; }
        public int NombreUser { get; set; }
        public int Contrasena { get; set; }
        public DateTime FechaReg { get; set; }
    }
}
