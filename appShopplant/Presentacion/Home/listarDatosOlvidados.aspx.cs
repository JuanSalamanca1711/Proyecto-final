using appShopplant.Entidades;
using appShopplant.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appShopplant.Presentacion.Home
{
    public partial class listarDatosOlvidados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void mtdBuscarClave(string correoCliente)
        {
            clUsuarioL objCorreoCliente = new clUsuarioL();
            clClienteE objDatosOlvidadosCliente = new clClienteE();
            objDatosOlvidadosCliente = objCorreoCliente.mtdBuscarClave(correoCliente);

            txtContraseña.Text = objDatosOlvidadosCliente.contraseña;

        }
        protected void btnBuscarClave_Click(object sender, EventArgs e)
        {
            string correoCliente = txtEmail.Text;
            mtdBuscarClave(correoCliente);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}