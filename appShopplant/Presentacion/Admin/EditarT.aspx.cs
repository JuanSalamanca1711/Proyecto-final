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
    public partial class EditarT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBuscar.Text);
            mtdBuscarTarea(id);
        }

        public void mtdBuscarTarea(int id)
        {
            clUsuarioL objTarea = new clUsuarioL();
            clTareasE objDatosTarea = new clTareasE();
            objDatosTarea = objTarea.mtdBuscarTarea(id);
    
            txtDescripcion.Text = objDatosTarea.descripcion;
            txtFechaHora.Text = objDatosTarea.fechaHoraInicio.ToString();
            txtIDEmpleado.Text = objDatosTarea.idEmpleado.ToString();
            txtIDAdministrador.Text = objDatosTarea.idAdministrador.ToString();
            txtEstado.Text = objDatosTarea.estado;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            clTareasE objDatosTarea = new clTareasE();

            objDatosTarea.idTarea = int.Parse(txtBuscar.Text);
            objDatosTarea.descripcion = txtDescripcion.Text;
            objDatosTarea.fechaHoraInicio = DateTime.Parse(txtFechaHora.Text);
            objDatosTarea.idEmpleado = int.Parse(txtIDEmpleado.Text);
            objDatosTarea.idAdministrador = int.Parse(txtIDAdministrador.Text);
            objDatosTarea.estado = txtEstado.Text;

            clUsuarioL objTareal = new clUsuarioL();
            int result = objTareal.mtdEditarTarea(objDatosTarea);

            if (result < 0)
            {

                Response.Redirect("../Admin/EditarT.aspx");


            }
        }
    }
}