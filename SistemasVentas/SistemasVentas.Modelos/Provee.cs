﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class Provee
    {
        public int IdProvee { get; set; }
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public string Fecha { get; set; }
        public string Precio { get; set; }
    }
}
