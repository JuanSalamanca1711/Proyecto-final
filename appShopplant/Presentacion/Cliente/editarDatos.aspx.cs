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
    public partial class editarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarDatos_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            mtdBuscarCliente(correo);
        }

        public void mtdBuscarCliente(string correo)
        {
            clUsuarioL objCliente = new clUsuarioL();
            clClienteE objDatosCliente = new clClienteE();
            objDatosCliente = objCliente.mtdBuscarDatosCliente(correo);

            txtNombre.Text = objDatosCliente.nombre;
            txtApellido.Text = objDatosCliente.apellido;
            txtCelular.Text = objDatosCliente.celular;
            txtDocumento.Text = objDatosCliente.documento;
            txtContraseña.Text = objDatosCliente.contraseña;
            txtCiudad.Text = objDatosCliente.idCiudad.ToString();

        }

        protected void btnActualizarDatos_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCelular.Text == "" || txtDocumento.Text == "" || txtContraseña.Text == "" || txtCiudad.Text == "")
            {
                string script = String.Format(@"<script type='text/javascript'>alert('HAY CAMPOS VACIOS, INTENTE NUEVAMENTE');</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
            else
            {
                clClienteE objDatosCliente = new clClienteE();

                objDatosCliente.correoCliente = txtCorreo.Text;

                objDatosCliente.nombre = txtNombre.Text;
                objDatosCliente.apellido = txtApellido.Text;
                objDatosCliente.celular = txtCelular.Text;
                objDatosCliente.documento = txtDocumento.Text;
                objDatosCliente.contraseña = txtContraseña.Text;
                objDatosCliente.idCiudad = int.Parse(txtCiudad.Text);


                clUsuarioL objClienteL = new clUsuarioL();
                int result = objClienteL.mtdEditarCliente(objDatosCliente);

                if (result<0)
                {
                    string script = String.Format(@"<script type='text/javascript'>alert('SUS DATOS HAN SIDO ACTUALIZADOS');</script>", "0033");
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
            }

        }
    }
}