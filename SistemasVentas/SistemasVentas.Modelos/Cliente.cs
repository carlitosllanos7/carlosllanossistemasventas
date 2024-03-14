using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public int IdPersona { get; set; }
        public int TipoCliente { get; set; }
        public int CodigoCliente { get; set; }
        public int Estado { get; set; }
    }
}
