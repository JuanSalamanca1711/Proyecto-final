using appShopplant.Entidades;
using appShopplant.Logica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appShopplant.Presentacion
{
    public partial class EditarP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            int id = int.Parse(txtBuscar.Text);
            mtdBuscarProducto(id);
        }
        public void mtdBuscarProducto(int id)
        {
            clUsuarioL objProducto = new clUsuarioL();
            clProductosE objDatosProducto = new clProductosE();
            objDatosProducto = objProducto.mtdBuscarProducto(id);


            txtImagenF.Text = objDatosProducto.imagen;
            ViewState["foto"] = objDatosProducto.imagen;
            imgFoto.ImageUrl = "~/Presentacion/Admin/imagenes/" + ViewState["foto"];
            imgFoto.DataBind();
            txtDescripcion.Text = objDatosProducto.descripcion;
            txtCuidados.Text = objDatosProducto.cuidados;
            txtPrecio.Text = objDatosProducto.precioVenta.ToString();
            txtCantidad.Text = objDatosProducto.cantidad.ToString();
            txtNombre.Text = objDatosProducto.nombre;
            txtEstado.Text = objDatosProducto.estado;


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

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            clProductosE objDatosPrdoducto = new clProductosE();

            objDatosPrdoducto.idProducto = int.Parse(txtBuscar.Text);   
            objDatosPrdoducto.imagen = ViewState["foto"].ToString();
            objDatosPrdoducto.descripcion = txtDescripcion.Text;
            objDatosPrdoducto.cuidados = txtCuidados.Text;
            objDatosPrdoducto.precioVenta = int.Parse(txtPrecio.Text.ToString());
            objDatosPrdoducto.cantidad = int.Parse(txtCantidad.Text.ToString());
            objDatosPrdoducto.nombre = txtNombre.Text;
            objDatosPrdoducto.estado = txtEstado.Text;

            clUsuarioL objProductol = new clUsuarioL();
            int result = objProductol.mtdEditarProducto(objDatosPrdoducto);

            if (result < 0)
            {

                Response.Redirect("../Admin/EditarP.aspx");


            }
        }

    }
}