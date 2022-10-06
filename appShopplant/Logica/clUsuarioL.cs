using appShopplant.Datos;
using appShopplant.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appShopplant.Logica
{
    public class clUsuarioL
    {

        public clAdminE mtdValidarAdmin(clAdminE objDatosAdmin)
        {
            clUsuarioD objAdmin = new clUsuarioD();
            clAdminE objDatosRegistrados = objAdmin.mtdLoginAdmin(objDatosAdmin);

            return objDatosRegistrados;
        }


        public clEmpleadoE mtdValidarEmpleado(clEmpleadoE objDatosEmpleado)
        {
            clUsuarioD objEmpleado = new clUsuarioD();
            clEmpleadoE objDatosRegistrados = objEmpleado.mtdLoginEmpleado(objDatosEmpleado);

            return objDatosRegistrados;
        }

        public clClienteE mtdValidarCliente(clClienteE objDatosCliente)
        {
            clUsuarioD objCliente = new clUsuarioD();
            clClienteE objDatosRegistrados = objCliente.mtdLoginCliente(objDatosCliente);

            return objDatosRegistrados;
        }


        public int mtdRegistrarEmpleado(clEmpleadoE objDatos)
        {
            clUsuarioD objRegistrarEmpleados = new clUsuarioD();
            int resultado = objRegistrarEmpleados.mtdRegistraEmpleados(objDatos);

            return resultado;
        }

        public int mtdRegistrarAdministrador(clAdminE objDatos)
        {
            clUsuarioD objRegistrarAdministrador = new clUsuarioD();
            int resultado = objRegistrarAdministrador.mtdRegistroAdmin(objDatos);

            return resultado;
        }
        public int mtdRegistrarCliente(clClienteE objDatosCLiente)
        {
            clUsuarioD objRegistrarCLiente = new clUsuarioD();
            int resultado = objRegistrarCLiente.mtdRegistrarClientes(objDatosCLiente);

            return resultado;
        }

        //verificar que no se realicen registros con el mismo correo y documento

        public clClienteE mtdVerificar(clClienteE objVerificar)
        {
            clUsuarioD objClienteV = new clUsuarioD();
            clClienteE objDatosVerificazdos = objClienteV.mtdVerificarExistencia(objVerificar);

            return objDatosVerificazdos;
        }


        public int mtdRegistrarTareas(clTareasE objDatos)
        {
            clUsuarioD objRegistrarTarea = new clUsuarioD();
            int resultado = objRegistrarTarea.mtdRegistroTareas(objDatos);

            return resultado;
        }


        //Listar datos olvidados del cliente
        public clClienteE mtdBuscarClave(string objDatosOlvidadosCliente)
        {
            clUsuarioD objDatosOlvidados = new clUsuarioD();
            clClienteE datosOlvidados = objDatosOlvidados.mtdBuscarClave(objDatosOlvidadosCliente);
            return datosOlvidados;
        }

        //Listar Datos del cliente para actualizarlos
        public clClienteE mtdBuscarDatosCliente(string objDatosCliente)
        {
            clUsuarioD objDatosC = new clUsuarioD();
            clClienteE datosCliente = objDatosC.mtdBuscarCliente(objDatosCliente);

            return datosCliente;

        }

        //Editar datos del cliente para actualizarlos

        public int mtdEditarCliente (clClienteE objDatosCliente)
        {
            clUsuarioD objCliente = new clUsuarioD();
            int result = objCliente.mtdEditarCliente(objDatosCliente);
            return result;


        }
        public clAdminE mtdBuscarAdmin(int objDatosAdmin)
        {
            clUsuarioD objAdmin = new clUsuarioD();
            clAdminE Busqueda = objAdmin.mtdBuscarAdmin(objDatosAdmin);
            return Busqueda;

        }

        public int mtdEditarAdmin(clAdminE objDatosAdmin)
        {
            clUsuarioD objAdmin = new clUsuarioD();
            int result = objAdmin.mtdEditarAdmin(objDatosAdmin);
            return result;
        }

        public clEmpleadoE mtdBuscarEmpleado(int objDatosEmpleado)
        {
            clUsuarioD objEmpleado = new clUsuarioD();
            clEmpleadoE Busqueda = objEmpleado.mtdBuscarEmpleado(objDatosEmpleado);
            return Busqueda;

        }
        public int mtdEditarEmpleado(clEmpleadoE objDatosEmpledo)
        {
            clUsuarioD objEmpleado = new clUsuarioD();
            int result = objEmpleado.mtdEditarEmpleado(objDatosEmpledo);
            return result;
        }
        public clTareasE mtdBuscarTarea(int objDatosTarea)
        {
            clUsuarioD objTarea = new clUsuarioD();
            clTareasE Busqueda = objTarea.mtdBuscarTArea(objDatosTarea);
            return Busqueda;

        }
        public int mtdEditarTarea(clTareasE objDatosTarea)
        {
            clUsuarioD objTarea = new clUsuarioD();
            int result = objTarea.mtdEditarTarea(objDatosTarea);
            return result;
        }
        public int mtdRegistrarPerdida(clPerdidaE objPerdida)
        {
            clUsuarioD objRegistrarPerdida = new clUsuarioD();
            int resultado = objRegistrarPerdida.mtdRegistraPerdidas(objPerdida);
            return resultado;
        }
        public clPerdidaE mtdBuscarPerdida(int objDatosPerdida)
        {
            clUsuarioD objPerdida = new clUsuarioD();
            clPerdidaE Busqueda = objPerdida.mtdBuscarPerdida(objDatosPerdida);
            return Busqueda;

        }

        public int mtdRegistrarProductos(clProductosE objDatos)
        {
            clUsuarioD objRegistrarProductos = new clUsuarioD();
            int resultado = objRegistrarProductos.mtdRegistroProductos(objDatos);

            return resultado;
        }

        public clProductosE mtdBuscarProducto(int objDatosProducto)
        {
            clUsuarioD objProducto = new clUsuarioD();
            clProductosE Busqueda = objProducto.mtdBuscarProducto(objDatosProducto);
            return Busqueda;

        }

        public int mtdEditarProducto(clProductosE objDatosProducto)
        {
            clUsuarioD objProducto = new clUsuarioD();
            int result = objProducto.mtdEditarProductos(objDatosProducto);
            return result;
        }

        public int mtdRegistrarQuejas(clQuejasReclamos objDatos)
        {
            clUsuarioD objRegistrarQUejas = new clUsuarioD();
            int resultado = objRegistrarQUejas.mtdRegistroQuejas(objDatos);

            return resultado;
        }

        public clQuejasReclamos mtdBuscarQ(string objDatosQ)
        {
            clUsuarioD objQ = new clUsuarioD();
            clQuejasReclamos Busqueda = objQ.mtdBID(objDatosQ);
            return Busqueda;

        }
        //public clEnvioCorreoE mtdEnviarCorreoo(clEnvioCorreoE objDatosCorreo)
        //{
        //    clEnvioCorreoD objCorreo = new clEnvioCorreoD();
        //    clEnvioCorreoE objDatosCorreoR = objCorreo.mtdEnviarCorreo(objDatosCorreo);

        //    return objDatosCorreoR;
        //}
    }
}