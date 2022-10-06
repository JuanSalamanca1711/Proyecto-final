using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appShopplant.Entidades
{
    public class clProductosE
    {
        public int idProducto { get; set; }
        public string imagen { get; set; }
        public string descripcion { get; set; }
        public string cuidados { get; set; }
        public int precioVenta { get; set; }
        public int cantidad { get; set; }
        public string nombre { get; set; }
        public string estado { get; set; }
    }
}