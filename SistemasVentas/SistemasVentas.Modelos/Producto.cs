using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class Producto
    {
        public int IdProducto { get; set; }
        public int IdTipoProd { get; set; }
        public int IdMarca { get; set; }
        public int Nombre { get; set; }
        public int CodigoBarra { get; set; }
        public int Unidad { get; set; }
        public int Descripcion { get; set; }
        public int Estado { get; set; }
    }
}
