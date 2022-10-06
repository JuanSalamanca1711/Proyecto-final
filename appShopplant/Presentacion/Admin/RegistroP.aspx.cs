using appShopplant.Entidades;
using appShopplant.Logica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appShopplant.Presentacion.Admin
{
    public partial class RegistrarP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void btnImg_Click(object sender, EventArgs e)
        {
            Boolean correcto = false;
            if (fluImg.HasFile)
            {
                ViewState["extencionFoto"] = Path.GetExtension(fluImg.FileName).ToLower();
                string[] extencionesPermitidas = { ".png", ".jpg", ".jpeg" };
                for (int i = 0; i < extencionesPermitidas.Length; i++)
                {
                    if (ViewState["extencionFoto"].ToString() == extencionesPermitidas[i])
                    {
                        correcto = true;
                    }
                }
                if (correcto == true)
                {
                    ViewState["foto"] = Path.GetFileName(fluImg.FileName);
                    fluImg.SaveAs(Server.MapPath("/Presentacion/Admin/imagenes/") + ViewState["foto"]);

                    imgFoto.ImageUrl = "~/Presentacion/Admin/imagenes/" + ViewState["foto"];
                    imgFoto.DataBind();
                }
            }
        }

        protected void btnRegistrarP_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtDescripcion.Text == "" || txtCuidados.Text == "" || txtPrecio.Text == "" || txtCantidad.Text == "" ||txtNombre.Text==""|| txtEstado.Text == "")
            {
                string script = String.Format(@"<script type='text/javascript'>alert('NO SE PUDO GUARDAR EL REGISTRO, INTENTELO DE NUEVO');</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
            else
            {
                clProductosE objProductosProyecto = new clProductosE();

                objProductosProyecto.imagen = ViewState["foto"].ToString();
                objProductosProyecto.descripcion = txtDescripcion.Text;
                objProductosProyecto.cuidados = txtCuidados.Text;
                objProductosProyecto.precioVenta = int.Parse(txtPrecio.Text.ToString());
                objProductosProyecto.cantidad = int.Parse(txtCantidad.Text.ToString());
                objProductosProyecto.nombre = txtNombre.Text;
                objProductosProyecto.estado = txtEstado.Text;


                clUsuarioL objRegistrarProductos = new clUsuarioL();
                int result = objRegistrarProductos.mtdRegistrarProductos(objProductosProyecto);

                    if (result > 0)
                {
                    string script = String.Format(@"<script type='text/javascript'>alert('SE HA GUARADADO UN NUEVO REGISTRO CON EXITO');</script>", "0033");
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    Response.Redirect("../Admin/RegistroP.aspx");
                }
            }
        }

        
    }

}
