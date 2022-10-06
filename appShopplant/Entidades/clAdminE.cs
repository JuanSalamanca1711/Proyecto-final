using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appShopplant.Entidades
{
    public class clAdminE
    {
        public int idAdministrador { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string celular { get; set; }
        public string correoAdministrador { get; set; }
        public string contraseña { get; set; }
        public string estado { get; set; }
    }
}