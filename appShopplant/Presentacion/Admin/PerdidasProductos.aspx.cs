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
    public partial class PerdidasProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text == "" || txtEmpleado.Text == "" || txtRazon.Text == "" || txtFecha.Text == "")
            {
                string script = String.Format(@"<script type='text/javascript'>alert('NO SE HA PODIDO GUARDAR EL REGISTRO DE LA PERDIDA');</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);


            }
            else

            {
                clPerdidaE objDatosPerdida = new clPerdidaE();

                objDatosPerdida.idEmpleado = int.Parse(txtEmpleado.Text);
                objDatosPerdida.idProducto = int.Parse(txtProducto.Text);
                objDatosPerdida.razon = txtRazon.Text;
                objDatosPerdida.fecha = DateTime.Parse(txtFecha.Text);


                clUsuarioL objPerdidal = new clUsuarioL();
                int result = objPerdidal.mtdRegistrarPerdida(objDatosPerdida);

                if (result < 0)
                {

                    Response.Redirect("../Admin/PerdidasProductos.aspx");


                }
            }
        }
    }
}