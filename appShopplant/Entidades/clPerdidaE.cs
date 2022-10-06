using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appShopplant.Entidades
{
    public class clPerdidaE
    {
        public int idPerdida { get; set; }
        public int idProducto { get; set; }
        public int idEmpleado { get; set; }
        public string razon { get; set;}
        public  DateTime fecha { get; set; }
    }
}