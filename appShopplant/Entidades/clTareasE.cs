using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appShopplant.Entidades
{
    public class clTareasE
    {

        public int idTarea { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public DateTime fechaHoraFin { get; set; }
        public int idEmpleado { get; set; }
        public int idAdministrador { get; set; }
        public string estado { get; set; }

    }
}