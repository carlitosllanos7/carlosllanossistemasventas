using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class DetalleIng
    {
        public int IdDetalleIng { get; set; }
        public int IdIngreso { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaVenc { get; set; }
        public int Cantidad { get; set; }
        public int PrecioCosto { get; set; }
        public int PrecioVenta { get; set; }
        public int SubTotal { get; set; }
        public int Estado { get; set; }
    }
}
