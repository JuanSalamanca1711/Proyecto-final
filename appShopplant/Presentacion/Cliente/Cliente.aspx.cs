using appShopplant.Entidades;
using appShopplant.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appShopplant.Presentacion.Cliente
{
    public partial class Cliente1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
        }
        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            string correo = txtEmail.Text;
            mtdBuscarID(correo);
        }
        public void mtdBuscarID(string correo)
        {
            clUsuarioL objCliente = new clUsuarioL();
            clQuejasReclamos objDatosCliente = new clQuejasReclamos();
            objDatosCliente = objCliente.mtdBuscarQ(correo);

            txtID.Text = objDatosCliente.idCliente.ToString();
            txtID.Enabled = false;
        }

        protected void btnEnviarQueja_Click(object sender, EventArgs e)
        {

            if (txtEspecificacion.Text == "" || txtFecha.Text == "" || txtEmail.Text=="" || txtID.Text=="")
            {
                string script = String.Format(@"<script type='text/javascript'>alert('NO SE HA PODIDO GUARDAR EL REGISTRO DE SU QUEJA O RECLAMO INTENTE DE NUEVO');</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);


            }
            else

            {
                clQuejasReclamos objDatosQueja = new clQuejasReclamos();


                string correo = txtEmail.Text;
                
                objDatosQueja.idCliente = int.Parse(txtID.Text);
                objDatosQueja.especificacion = txtEspecificacion.Text;
                objDatosQueja.fechaHora = DateTime.Parse(txtFecha.Text);


                clUsuarioL objRegistrarQuejas = new clUsuarioL();
                int result = objRegistrarQuejas.mtdRegistrarQuejas(objDatosQueja);

                if (result < 0)
                {

                    //string script = String.Format(@"<script type='text/javascript'>alert('SE HA GUARADADO UN NUEVO REGISTRO CON EXITO');</script>", "0033");
                    //ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    Response.Redirect("../Cliente/Cliente.aspx");
                }
            }

        }
    }
}