using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace appShopplant.Datos
{
    public class adminDatos
    {
        public SqlCommand mtdConectar(string consulta)
        {
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand(consulta, conexion);

            return cmd;


        }
        public DataTable mtdDesconectado(string consulta)
        {
            clConexion objclConexion = new clConexion();
            SqlConnection conex = objclConexion.mtdConexion();
            conex.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conex);

            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conex.Close();

            return tblDatos;

        }
    }
}