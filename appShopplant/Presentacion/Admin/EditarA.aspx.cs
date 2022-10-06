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
    public partial class EditarA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            int  id = int.Parse(txtBuscar.Text);
            mtdBuscarAdmin(id);
        }
        public void mtdBuscarAdmin(int id)
        {
            clUsuarioL objAdmin = new clUsuarioL();
            clAdminE objDatosAdmin = new clAdminE();
            objDatosAdmin = objAdmin.mtdBuscarAdmin(id);
 
            txtNombre.Text = objDatosAdmin.nombre;
            txtApellido.Text = objDatosAdmin.apellido;
            txtCelular.Text = objDatosAdmin.celular;
            txtCorreo.Text = objDatosAdmin.correoAdministrador;
            txtContraseña.Text = objDatosAdmin.contraseña;
            txtEstado.Text = objDatosAdmin.estado;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            clAdminE objDatosAdmin = new clAdminE();

            objDatosAdmin.idAdministrador = int.Parse(txtBuscar.Text);
            objDatosAdmin.nombre = txtNombre.Text;
            objDatosAdmin.apellido = txtApellido.Text;
            objDatosAdmin.celular = txtCelular.Text;
            objDatosAdmin.correoAdministrador = txtCorreo.Text;
            objDatosAdmin.contraseña = txtContraseña.Text;
            objDatosAdmin.estado = txtEstado.Text;

            clUsuarioL objAdminl = new clUsuarioL();
            int result = objAdminl.mtdEditarAdmin(objDatosAdmin);

            if (result < 0)
            {
                
                Response.Redirect("../Admin/EditarA.aspx");
                

            }
        }
    }
}