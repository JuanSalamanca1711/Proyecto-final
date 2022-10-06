using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appShopplant.Entidades
{
    public class clEmpleadoE
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string celular { get; set; }
        public string correoEmpleado { get; set; }
        public string contraseña { get; set; }
        public string estado { get; set; }
        public int idCargo { get; set; }

    }
}