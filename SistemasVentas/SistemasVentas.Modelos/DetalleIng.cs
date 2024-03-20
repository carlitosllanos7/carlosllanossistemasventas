using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class DetalleIng
    {
        public int IdDetalleIng { get; set; }
        public int IdIngreso { get; set; }
        public int IdProducto { get; set; }
        public string FechaVenc { get; set; }
        public string Cantidad { get; set; }
        public string PrecioCosto { get; set; }
        public string PrecioVenta { get; set; }
        public string SubTotal { get; set; }
        public string Estado { get; set; }
    }
}
