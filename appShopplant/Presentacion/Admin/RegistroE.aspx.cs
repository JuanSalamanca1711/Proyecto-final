using appShopplant.Entidades;
using appShopplant.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appShopplant.Presentacion.Admin
{
    public partial class RegistroU : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCelular.Text == "" || txtCorreo.Text == "" || txtContraseña.Text == "" || txtEstado.Text == "" || txtCargo.Text == "")
            {
                string script = String.Format(@"<script type='text/javascript'>alert('NO SE HA PODIDO GUARDAR EL REGISTRO DEL EMPLEADO INTENTE DE NUEVO');</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);


            }
            else 

            {
                clEmpleadoE objDatosProyecto = new clEmpleadoE();
                objDatosProyecto.nombre = txtNombre.Text;
                objDatosProyecto.apellido = txtApellido.Text;
                objDatosProyecto.celular = txtCelular.Text;
                objDatosProyecto.correoEmpleado = txtCorreo.Text;
                objDatosProyecto.contraseña = txtContraseña.Text;
                objDatosProyecto.estado = txtEstado.Text;
                objDatosProyecto.idCargo = int.Parse(txtCargo.Text.ToString());


                clUsuarioL objRegistrarEmpleados = new clUsuarioL();
                int result = objRegistrarEmpleados.mtdRegistrarEmpleado(objDatosProyecto);

                if (result > 0)
                {
                    string script = String.Format(@"<script type='text/javascript'>alert('SE HA GUARADADO UN NUEVO REGISTRO CON EXITO');</script>", "0033");
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    Response.Redirect("../Admin/RegistroE.aspx");
                }
            }
        }
    }
}