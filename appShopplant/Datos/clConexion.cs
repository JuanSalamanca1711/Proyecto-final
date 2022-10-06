using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace appShopplant.Datos
{
    public class clConexion
    {

        SqlConnection conexion = null;
        public SqlConnection mtdConexion()
        {
            conexion = new SqlConnection("Data Source=.;Initial Catalog=Matas;Integrated Security=True");
            return conexion;
        }
    }
}