using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace appShopplant.Datos
{
    public class clConnection
    {
        public DataTable mtdDesconectado(string sql)
        {
            //select
            clConexion objConexion = new clConexion();
            SqlConnection conex = objConexion.mtdConexion();
            conex.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conex);

            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conex.Close();
            return tblDatos;
        }

        //insert, update, delete
        public int mtdConectado(string sql)
        {

            clConexion objConexion = new clConexion();
            SqlConnection conex = objConexion.mtdConexion();
            conex.Open();

            SqlCommand cmdInsert = new SqlCommand(sql, conex);
            int canReg = cmdInsert.ExecuteNonQuery();
            conex.Close();

            return canReg;
        }
    }
}