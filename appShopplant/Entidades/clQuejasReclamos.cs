using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appShopplant.Entidades
{
    public class clQuejasReclamos
    {

        public int idQuejasReclamos { get; set; }
        public int idCliente { get; set; }
        public string especificacion { get; set; }
        public DateTime fechaHora { get; set; }

    }
}