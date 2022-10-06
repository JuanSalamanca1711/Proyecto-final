using appShopplant.Entidades;
using appShopplant.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appShopplant.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            //Loggin del administrador
            clAdminE objAdminE = new clAdminE();
            objAdminE.correoAdministrador = txtEmail.Text;
            objAdminE.contraseña = txtContraseña.Text;

            clUsuarioL objUsuarioL = new clUsuarioL();
            clAdminE objDatosAdmin = objUsuarioL.mtdValidarAdmin(objAdminE);

            //Loggin del empleado
            clEmpleadoE objEmpleadoE = new clEmpleadoE();
            objEmpleadoE.correoEmpleado = txtEmail.Text;
            objEmpleadoE.contraseña = txtContraseña.Text;

            clEmpleadoE objDatosEmpleado = objUsuarioL.mtdValidarEmpleado(objEmpleadoE);

            //login del cliente
            clClienteE objClienteE = new clClienteE();
            objClienteE.correoCliente = txtEmail.Text;
            objClienteE.contraseña = txtContraseña.Text;

            clClienteE objDatosCliente = objUsuarioL.mtdValidarCliente(objClienteE);

            if (objDatosAdmin != null)
            {
                Response.Redirect("../Admin/Administrador.aspx");
            }
            else if (objDatosEmpleado != null)
            {
                Response.Redirect("../Empleados/Empleado.aspx");
            }
            else if (objDatosCliente != null)
            {
                Response.Redirect("../Cliente/Cliente.aspx");
            }
            else
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Los datos ingresados son incorrectos, por favor intente nuevamente');</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }

            
        }
    }
}