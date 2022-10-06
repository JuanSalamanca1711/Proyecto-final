using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using appShopplant.Entidades;
using appShopplant.Datos;
using System.Data.SqlClient;

namespace appShopplant.Datos
{
    public class clUsuarioD
    {
        //Metodo para logear administradores

        public clAdminE mtdLoginAdmin(clAdminE objDatosAdmin)
        {
            string sql = "select * from Administrador " +
                "where correoAdministrador='" + objDatosAdmin.correoAdministrador + "' " +
                "and contraseña='" + objDatosAdmin.contraseña + "' and estado='Activo'";



            clConnection objConnection = new clConnection();
            DataTable tblDatosAdmin = objConnection.mtdDesconectado(sql);

            clAdminE objDatosA = null;
            if (tblDatosAdmin.Rows.Count > 0)
            {
                objDatosA = new clAdminE();
                objDatosA.idAdministrador = int.Parse(tblDatosAdmin.Rows[0]["idAdministrador"].ToString());
                objDatosA.nombre = tblDatosAdmin.Rows[0]["nombre"].ToString();
                objDatosA.apellido = tblDatosAdmin.Rows[0]["apellido"].ToString();
                objDatosA.celular = tblDatosAdmin.Rows[0]["celular"].ToString();
                objDatosA.correoAdministrador = tblDatosAdmin.Rows[0]["correoAdministrador"].ToString();
                objDatosA.contraseña = tblDatosAdmin.Rows[0]["contraseña"].ToString();

            }
            return objDatosA;
        }

        //Metodo para logear empleados

        public clEmpleadoE mtdLoginEmpleado(clEmpleadoE objDatosEmpleado)
        {
            string sql = "select * from Empleado " +
                "where correoEmpleado='" + objDatosEmpleado.correoEmpleado + "' " +
                "and contraseña='" + objDatosEmpleado.contraseña + "' and estado='Activo'";

            clConnection objConnection = new clConnection();
            DataTable tblDatosEmpleado = objConnection.mtdDesconectado(sql);

            clEmpleadoE objDatosE = null;
            if (tblDatosEmpleado.Rows.Count > 0)
            {
                objDatosE = new clEmpleadoE();
                objDatosE.idEmpleado = int.Parse(tblDatosEmpleado.Rows[0]["idEmpleado"].ToString());
                objDatosE.nombre = tblDatosEmpleado.Rows[0]["nombre"].ToString();
                objDatosE.apellido = tblDatosEmpleado.Rows[0]["apellido"].ToString();
                objDatosE.celular = tblDatosEmpleado.Rows[0]["celular"].ToString();
                objDatosE.correoEmpleado = tblDatosEmpleado.Rows[0]["correoEmpleado"].ToString();
                objDatosE.contraseña = tblDatosEmpleado.Rows[0]["contraseña"].ToString();
                objDatosE.estado = tblDatosEmpleado.Rows[0]["estado"].ToString();
                objDatosE.idCargo = int.Parse(tblDatosEmpleado.Rows[0]["idCargo"].ToString());
            }
            return objDatosE;
        }

        //Metodo para editar los datos de los clientes
        public void mtdEditarDatosCliente(clClienteE objDatosCliente)
        {

        }

        //Metodo para mostrar datos olvidados del cliente
        public clClienteE mtdBuscarClave(string correoCliente)
        {
            string consulta = "sp_recordarDatosUsuario";

            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();

            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@correo", correoCliente);

            DataTable tblDatos = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tblDatos);

            clClienteE objDatosCliente = null;

            if (tblDatos.Rows.Count > 0)
            {
                objDatosCliente = new clClienteE();
                objDatosCliente.contraseña = tblDatos.Rows[0]["contraseña"].ToString();
            }

            return objDatosCliente;
        }


        //Metodo para logear clientes

        public clClienteE mtdLoginCliente(clClienteE objDatosCliente)
        {
            string sql = "select * from Cliente " +
                "where correoCliente='" + objDatosCliente.correoCliente + "' " +
                "and contraseña='" + objDatosCliente.contraseña + "'";

            clConnection objConnection = new clConnection();
            DataTable tblDatosCliente = objConnection.mtdDesconectado(sql);

            clClienteE objDatosC = null;
            if (tblDatosCliente.Rows.Count > 0)
            {
                objDatosC = new clClienteE();
                objDatosC.idCliente = int.Parse(tblDatosCliente.Rows[0]["idCliente"].ToString());
                objDatosC.nombre = tblDatosCliente.Rows[0]["nombre"].ToString();
                objDatosC.apellido = tblDatosCliente.Rows[0]["apellido"].ToString();
                objDatosC.celular = tblDatosCliente.Rows[0]["celular"].ToString();
                objDatosC.documento = tblDatosCliente.Rows[0]["documento"].ToString();
                objDatosC.correoCliente = tblDatosCliente.Rows[0]["correoCliente"].ToString();
                objDatosC.contraseña = tblDatosCliente.Rows[0]["contraseña"].ToString();
                objDatosC.idCiudad = int.Parse(tblDatosCliente.Rows[0]["idCiudad"].ToString());
            }
            return objDatosC;
        }


        //Registro de Empleados
        public int mtdRegistraEmpleados(clEmpleadoE objDatosProyec)
        {
            string sql = "insert into Empleado(nombre, apellido, celular, correoEmpleado, contraseña, estado, idCargo) " +
                "values('" + objDatosProyec.nombre + "','" + objDatosProyec.apellido + "','" + objDatosProyec.celular + "','" + objDatosProyec.correoEmpleado + "','" + objDatosProyec.contraseña + "','" + objDatosProyec.estado + "','" + objDatosProyec.idCargo + "')";

            clConexion objConnection = new clConexion();
            SqlConnection conex = objConnection.mtdConexion();
            conex.Open();

            SqlCommand cmdInsert = new SqlCommand(sql, conex);//Sqlcomman es un objeto que trabaj de forma conectada y necesita una consulta y una conexion            
            int canReg = cmdInsert.ExecuteNonQuery(); //Ejecuta y retorna

            conex.Close();//Cierra la conexion

            return canReg;
        }

        //Registro Clientes
        public int mtdRegistrarClientes(clClienteE objDatosCLiente)
        {
            string sql = "insert into Cliente(nombre, apellido, celular, documento, correoCliente, contraseña, idCiudad) " +
                "values('" + objDatosCLiente.nombre + "','" + objDatosCLiente.apellido + "','" + objDatosCLiente.celular
                + "', '" + objDatosCLiente.documento + "' ,  '" + objDatosCLiente.correoCliente + "', '" + objDatosCLiente.contraseña + "',  '" + objDatosCLiente.idCiudad
                + "')";

            clConexion objConnection = new clConexion();
            SqlConnection conex = objConnection.mtdConexion();
            conex.Open();

            SqlCommand cmdInsert = new SqlCommand(sql, conex);//Sqlcomman es un objeto que trabaj de forma conectada y necesita una consulta y una conexion            
            int canReg = cmdInsert.ExecuteNonQuery(); //Ejecuta y retorna

            conex.Close();//Cierra la conexion

            return canReg;
        }

        // Verificacion existencia en registrar clientes
        public clClienteE mtdVerificarExistencia(clClienteE objVerificacion)
        {

            string sql = "select * from Cliente " +
                "where correoCliente='" + objVerificacion.correoCliente + "' " +
                "and documento='" + objVerificacion.documento + "'";

            clConnection objConnection = new clConnection();
            DataTable tblDatosCliente = objConnection.mtdDesconectado(sql);

            clClienteE objDatosC = null;
            if (tblDatosCliente.Rows.Count > 0)
            {
                objDatosC = new clClienteE();
                objDatosC.idCliente = int.Parse(tblDatosCliente.Rows[0]["idCliente"].ToString());
                objDatosC.nombre = tblDatosCliente.Rows[0]["nombre"].ToString();
                objDatosC.apellido = tblDatosCliente.Rows[0]["apellido"].ToString();
                objDatosC.celular = tblDatosCliente.Rows[0]["celular"].ToString();
                objDatosC.documento = tblDatosCliente.Rows[0]["documento"].ToString();
                objDatosC.correoCliente = tblDatosCliente.Rows[0]["correoCliente"].ToString();
                objDatosC.contraseña = tblDatosCliente.Rows[0]["contraseña"].ToString();
                objDatosC.idCiudad = int.Parse(tblDatosCliente.Rows[0]["idCiudad"].ToString());
            }
            return objDatosC;

        }



        //Registro de Administradores
        public int mtdRegistroAdmin(clAdminE objDatosProyec)
        {
            string sql = "insert into Administrador(nombre, apellido, celular, correoAdministrador, contraseña) " +
                "values('" + objDatosProyec.nombre + "','" + objDatosProyec.apellido + "','" + objDatosProyec.celular + "','" + objDatosProyec.correoAdministrador + "','" + objDatosProyec.contraseña + "')";

            clConexion objConnection = new clConexion();
            SqlConnection conex = objConnection.mtdConexion();
            conex.Open();

            SqlCommand cmdInsert = new SqlCommand(sql, conex);//Sqlcomman es un objeto que trabaj de forma conectada y necesita una consulta y una conexion            
            int canReg = cmdInsert.ExecuteNonQuery(); //Ejecuta y retorna

            conex.Close();//Cierra la conexion

            return canReg;
        }

        //Registro de Tareas
        public int mtdRegistroTareas(clTareasE objDatosProyec)
        {
            string consulta = "sp_RegistroT";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@descripcion", objDatosProyec.descripcion);
            cmd.Parameters.AddWithValue("@fechaHoraInicio", objDatosProyec.fechaHoraInicio);
            cmd.Parameters.AddWithValue("@idEmpeado", objDatosProyec.idEmpleado);
            cmd.Parameters.AddWithValue("@idAdministrador", objDatosProyec.idAdministrador);
            cmd.Parameters.AddWithValue("@estado", objDatosProyec.estado);
            int CantReg = 0;
            try
            {
                CantReg = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return CantReg;
        }

        //Metodo para buscar los datos del cliente y actualizarlos

        public clClienteE mtdBuscarCliente(string correo)
        {

            string consulta = "sp_BuscarDatosCl";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@correo", correo);
            DataTable tblDatos = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tblDatos);

            clClienteE objDatosCliente = null;

            if (tblDatos.Rows.Count > 0)
            {
                objDatosCliente = new clClienteE();
                objDatosCliente.nombre = tblDatos.Rows[0]["nombre"].ToString();
                objDatosCliente.apellido = tblDatos.Rows[0]["apellido"].ToString();
                objDatosCliente.celular = tblDatos.Rows[0]["celular"].ToString();
                objDatosCliente.documento = tblDatos.Rows[0]["documento"].ToString();
                objDatosCliente.contraseña = tblDatos.Rows[0]["contraseña"].ToString();
                objDatosCliente.idCiudad = int.Parse(tblDatos.Rows[0]["idCiudad"].ToString());
            }

            return objDatosCliente;
        }

        //Metodo para editar los datos del cliente
        public int mtdEditarCliente(clClienteE objDatosCliente)
        {
            string consulta = "sp_EditarDatosCl";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@correo", objDatosCliente.correoCliente);
            cmd.Parameters.AddWithValue("@nombre", objDatosCliente.nombre);
            cmd.Parameters.AddWithValue("@apellido", objDatosCliente.apellido);
            cmd.Parameters.AddWithValue("@celular", objDatosCliente.celular);
            cmd.Parameters.AddWithValue("@documento", objDatosCliente.documento);
            cmd.Parameters.AddWithValue("@contraseña", objDatosCliente.contraseña);
            cmd.Parameters.AddWithValue("@ciudad", objDatosCliente.idCiudad);
            int CantReg = 0;
            try
            {
                CantReg = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return CantReg;

        }


        //Metodo Buscar Admin
        public clAdminE mtdBuscarAdmin(int id)
        {
            string consulta = "sp_Buscar";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            DataTable tblDatos = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tblDatos);

            clAdminE objDatosAdmin = null;

            if (tblDatos.Rows.Count > 0)
            {
                objDatosAdmin = new clAdminE();
                objDatosAdmin.nombre = tblDatos.Rows[0]["Nombre"].ToString();
                objDatosAdmin.apellido = tblDatos.Rows[0]["Apellido"].ToString();
                objDatosAdmin.celular = tblDatos.Rows[0]["Celular"].ToString();
                objDatosAdmin.correoAdministrador = tblDatos.Rows[0]["CorreoAdministrador"].ToString();
                objDatosAdmin.contraseña = tblDatos.Rows[0]["Contraseña"].ToString();
                objDatosAdmin.estado = tblDatos.Rows[0]["Estado"].ToString();
            }

            return objDatosAdmin;

        }

        //Metodo Editar Admin
        public int mtdEditarAdmin(clAdminE objDatosAdmin)
        {
            string consulta = "sp_Editar";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objDatosAdmin.idAdministrador);
            cmd.Parameters.AddWithValue("@Nombre", objDatosAdmin.nombre);
            cmd.Parameters.AddWithValue("@Apellido", objDatosAdmin.apellido);
            cmd.Parameters.AddWithValue("@Celular", objDatosAdmin.celular);
            cmd.Parameters.AddWithValue("@Correo", objDatosAdmin.correoAdministrador);
            cmd.Parameters.AddWithValue("@Contraseña", objDatosAdmin.contraseña);
            cmd.Parameters.AddWithValue("@Estado", objDatosAdmin.estado);
            int CantReg = 0;
            try
            {
                CantReg = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return CantReg;

        }

        //Metodo buscar Empleado
        public clEmpleadoE mtdBuscarEmpleado(int id)
        {
            string consulta = "sp_BuscarE";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable tblDatos = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tblDatos);

            clEmpleadoE objDatosEmpleado = null;

            if (tblDatos.Rows.Count > 0)
            {
                objDatosEmpleado = new clEmpleadoE();
                objDatosEmpleado.nombre = tblDatos.Rows[0]["Nombre"].ToString();
                objDatosEmpleado.apellido = tblDatos.Rows[0]["Apellido"].ToString();
                objDatosEmpleado.celular = tblDatos.Rows[0]["Celular"].ToString();
                objDatosEmpleado.correoEmpleado = tblDatos.Rows[0]["CorreoEmpleado"].ToString();
                objDatosEmpleado.contraseña = tblDatos.Rows[0]["Contraseña"].ToString();
                objDatosEmpleado.estado = tblDatos.Rows[0]["Estado"].ToString();
                objDatosEmpleado.idCargo = int.Parse(tblDatos.Rows[0]["IdCargo"].ToString());
            }

            return objDatosEmpleado;
        }

        //Metodo Editar Empleado
        public int mtdEditarEmpleado(clEmpleadoE objDatosEmpleado)
        {
            string consulta = "sp_EditarE";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objDatosEmpleado.idEmpleado);
            cmd.Parameters.AddWithValue("@Nombre", objDatosEmpleado.nombre);
            cmd.Parameters.AddWithValue("@Apellido", objDatosEmpleado.apellido);
            cmd.Parameters.AddWithValue("@Celular", objDatosEmpleado.celular);
            cmd.Parameters.AddWithValue("@Correo", objDatosEmpleado.correoEmpleado);
            cmd.Parameters.AddWithValue("@Contraseña", objDatosEmpleado.contraseña);
            cmd.Parameters.AddWithValue("@Estado", objDatosEmpleado.estado);
            cmd.Parameters.AddWithValue("@idCargo", objDatosEmpleado.idCargo);
            int CantReg = 0;
            try
            {
                CantReg = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return CantReg;

        }

        //Metodo buscar Tareas
        public clTareasE mtdBuscarTArea(int id)
        {
            string consulta = "sp_BuscarT";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable tblDatos = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tblDatos);

            clTareasE objDatosTarea = null;

            if (tblDatos.Rows.Count > 0)
            {
                objDatosTarea = new clTareasE();
                objDatosTarea.descripcion = tblDatos.Rows[0]["descripcion"].ToString();
                objDatosTarea.fechaHoraInicio = DateTime.Parse(tblDatos.Rows[0]["fechaHoraInicio"].ToString());
                objDatosTarea.idEmpleado = int.Parse(tblDatos.Rows[0]["idEmpleado"].ToString());
                objDatosTarea.idAdministrador = int.Parse(tblDatos.Rows[0]["idAdministrador"].ToString());
                objDatosTarea.estado = tblDatos.Rows[0]["estado"].ToString();
            }

            return objDatosTarea;
        }

        //Metodo Editar Tarea
        public int mtdEditarTarea(clTareasE objDatosTarea)
        {
            string consulta = "sp_EditarT";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objDatosTarea.idTarea);
            cmd.Parameters.AddWithValue("@descripcion", objDatosTarea.descripcion);
            cmd.Parameters.AddWithValue("@fechaHoraInicio", objDatosTarea.fechaHoraInicio);
            cmd.Parameters.AddWithValue("@idEmpleado", objDatosTarea.idEmpleado);
            cmd.Parameters.AddWithValue("@idAdministrador", objDatosTarea.idAdministrador);
            cmd.Parameters.AddWithValue("@estado", objDatosTarea.estado);
            int CantReg = 0;
            try
            {
                CantReg = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return CantReg;

        }

        //Registro de Perdidas
        public int mtdRegistraPerdidas(clPerdidaE objDatosPerdida)
        {
            string consulta = "sp_RegistrarPer";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idEmpleado", objDatosPerdida.idEmpleado);
            cmd.Parameters.AddWithValue("@idProducto", objDatosPerdida.idProducto);
            cmd.Parameters.AddWithValue("@razon", objDatosPerdida.razon);
            cmd.Parameters.AddWithValue("@fechaHora", objDatosPerdida.fecha);
            int CantReg = 0;
            try
            {
                CantReg = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return CantReg;
        }

        //Buscar Perdidas
        public clPerdidaE mtdBuscarPerdida(int id)
        {
            string consulta = "sp_BuscarPer";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable tblDatos = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tblDatos);

            clPerdidaE objDatosPerdida = null;

            if (tblDatos.Rows.Count > 0)
            {
                objDatosPerdida = new clPerdidaE();
                objDatosPerdida.idProducto = int.Parse(tblDatos.Rows[0]["idProducto"].ToString());
                objDatosPerdida.idEmpleado = int.Parse(tblDatos.Rows[0]["idEmpleado"].ToString());
                objDatosPerdida.razon = tblDatos.Rows[0]["razon"].ToString();
                objDatosPerdida.fecha = DateTime.Parse(tblDatos.Rows[0]["fecha"].ToString());
            }

            return objDatosPerdida;
        }

        //RegistroProductos

        public int mtdRegistroProductos(clProductosE objProductosProyecto)
        {
            string consulta = "sp_RegistrarProd";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@imagen", objProductosProyecto.imagen);
            cmd.Parameters.AddWithValue("@descripcion", objProductosProyecto.descripcion);
            cmd.Parameters.AddWithValue("@cuidados", objProductosProyecto.cuidados);
            cmd.Parameters.AddWithValue("@precioVenta", objProductosProyecto.precioVenta);
            cmd.Parameters.AddWithValue("@cantidad", objProductosProyecto.cantidad);
            cmd.Parameters.AddWithValue("@nombre", objProductosProyecto.nombre);
            cmd.Parameters.AddWithValue("@estado", objProductosProyecto.estado);

            int CantReg = 0;
            try
            {
                CantReg = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return CantReg;
        }

        //Mtd Buscar Productos
        public clProductosE mtdBuscarProducto(int id)
        {
            string consulta = "sp_BuscarProducto";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable tblDatos = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tblDatos);

            clProductosE objDatosProductos = null;

            if (tblDatos.Rows.Count > 0)
            {
                objDatosProductos = new clProductosE();
                objDatosProductos.idProducto = int.Parse(tblDatos.Rows[0]["idProducto"].ToString());
                objDatosProductos.imagen = (tblDatos.Rows[0]["imagen"].ToString());
                objDatosProductos.descripcion = tblDatos.Rows[0]["descripcion"].ToString();
                objDatosProductos.cuidados = tblDatos.Rows[0]["cuidados"].ToString();
                objDatosProductos.precioVenta = int.Parse(tblDatos.Rows[0]["precioVenta"].ToString());
                objDatosProductos.cantidad = int.Parse(tblDatos.Rows[0]["cantidad"].ToString());
                objDatosProductos.nombre = tblDatos.Rows[0]["nombre"].ToString();
                objDatosProductos.estado = tblDatos.Rows[0]["estado"].ToString();
            }

            return objDatosProductos;
        }

        //Mtd Editar informacion de los productos
        public int mtdEditarProductos(clProductosE objDatosProducto)
        {
            string consulta = "sp_EditarP";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", objDatosProducto.idProducto);
            cmd.Parameters.AddWithValue("@imagen", objDatosProducto.imagen);
            cmd.Parameters.AddWithValue("@descripcion", objDatosProducto.descripcion);
            cmd.Parameters.AddWithValue("@cuidados", objDatosProducto.cuidados);
            cmd.Parameters.AddWithValue("@precio", objDatosProducto.precioVenta);
            cmd.Parameters.AddWithValue("@cantidad", objDatosProducto.cantidad);
            cmd.Parameters.AddWithValue("@nombre", objDatosProducto.nombre);
            cmd.Parameters.AddWithValue("@estado", objDatosProducto.estado);
            int CantReg = 0;
            try
            {
                CantReg = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return CantReg;

        }

        //Metodo para registrar una queja o reclamo
        public int mtdRegistroQuejas(clQuejasReclamos objQuejas)
        {
            string consulta = "sp_RegistrarQuejas";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@idCliente", objQuejas.idCliente);
            cmd.Parameters.AddWithValue("@especificacion", objQuejas.especificacion);
            cmd.Parameters.AddWithValue("@fechaHora", objQuejas.fechaHora);

            int CantReg = 0;
            try
            {
                CantReg = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return CantReg;
        }

        //Metodo para buscar id del cliente
        public clQuejasReclamos mtdBID(string correo)
        {
            string consulta = "sp_BID";
            clConexion objConexion = new clConexion();
            SqlConnection conexion = objConexion.mtdConexion();
            adminDatos objDatos = new adminDatos();
            SqlCommand cmd = objDatos.mtdConectar(consulta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@correo", correo);
            DataTable tblDatos = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tblDatos);

            clQuejasReclamos objDatosQ = null;

            if (tblDatos.Rows.Count > 0)
            {
                objDatosQ = new clQuejasReclamos();

                objDatosQ.idCliente = int.Parse(tblDatos.Rows[0]["idCLiente"].ToString());

            }

            return objDatosQ;
        }

    }
}