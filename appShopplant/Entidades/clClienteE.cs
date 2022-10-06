using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appShopplant.Entidades
{
    public class clClienteE
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string celular { get; set; }
        public string documento { get; set; }
        public string correoCliente { get; set; }
        public string contraseña { get; set; }
        public int idCiudad { get; set; }

    }
}