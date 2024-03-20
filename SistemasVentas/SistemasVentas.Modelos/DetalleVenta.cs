using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public string Cantidad { get; set; }
        public string PrecioVenta { get; set; }
        public string SubTotal { get; set; }
        public string Estado { get; set; }
    }
}
