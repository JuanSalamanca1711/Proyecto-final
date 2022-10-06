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
    public partial class RegistroTareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtFechaInicio.Text == "" || txtEmpleado.Text == "" || txtAdmin.Text == "" || txtEstado.Text == "")
            {
                string script = String.Format(@"<script type='text/javascript'>alert('NO SE HA PODIDO GUARDAR EL REGISTRO DE LA TAREA INTENTE DE NUEVO');</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);


            }
            else

            {
                clTareasE objDatosTarea = new clTareasE();

                objDatosTarea.descripcion = txtDescripcion.Text;
                objDatosTarea.fechaHoraInicio = DateTime.Parse(txtFechaInicio.Text);
                objDatosTarea.idEmpleado = int.Parse(txtEmpleado.Text);
                objDatosTarea.idAdministrador = int.Parse(txtAdmin.Text);
                objDatosTarea.estado = txtEstado.Text;

                clUsuarioL objTareal = new clUsuarioL();
                int result = objTareal.mtdRegistrarTareas(objDatosTarea);

                if (result < 0)
                {

                    Response.Redirect("../Admin/RegistroTareas.aspx");


                }
            }
        }


    }
}