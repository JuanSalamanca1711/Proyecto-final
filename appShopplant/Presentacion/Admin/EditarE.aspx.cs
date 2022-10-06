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
    public partial class EditarE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBuscar.Text);
            mtdBuscarEmpleado(id);
        }

        public void mtdBuscarEmpleado(int id)
        {
            clUsuarioL objEmpleado = new clUsuarioL();
            clEmpleadoE objDatosEmpleado = new clEmpleadoE();
            objDatosEmpleado = objEmpleado.mtdBuscarEmpleado(id);

            txtNombre.Text = objDatosEmpleado.nombre;
            txtApellido.Text = objDatosEmpleado.apellido;
            txtCelular.Text = objDatosEmpleado.celular;
            txtCorreo.Text = objDatosEmpleado.correoEmpleado;
            txtContraseña.Text = objDatosEmpleado.contraseña;
            txtEstado.Text = objDatosEmpleado.estado;
            txtCargo.Text = objDatosEmpleado.idCargo.ToString();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            clEmpleadoE objDatosEmpleado = new clEmpleadoE();

            objDatosEmpleado.idEmpleado = int.Parse(txtBuscar.Text);
            objDatosEmpleado.nombre = txtNombre.Text;
            objDatosEmpleado.apellido = txtApellido.Text;
            objDatosEmpleado.celular = txtCelular.Text;
            objDatosEmpleado.correoEmpleado = txtCorreo.Text;
            objDatosEmpleado.contraseña = txtContraseña.Text;
            objDatosEmpleado.estado = txtEstado.Text;
            objDatosEmpleado.idCargo = int.Parse(txtCargo.Text);

            clUsuarioL objEmpleadol = new clUsuarioL();
            int result = objEmpleadol.mtdEditarEmpleado(objDatosEmpleado);

            if (result < 0)
            {

                Response.Redirect("../Admin/EditarE.aspx");


            }
        }
    }
}