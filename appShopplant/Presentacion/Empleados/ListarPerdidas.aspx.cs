using appShopplant.Entidades;
using appShopplant.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appShopplant.Presentacion.Empleados
{
    public partial class ListarPerdidas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarP_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBuscar.Text);
            mtdBuscarPerdida(id);
        }

        public void mtdBuscarPerdida(int id)
        {
            clUsuarioL objPerdida = new clUsuarioL();
            clPerdidaE objDatosPerdida = new clPerdidaE();
            objDatosPerdida = objPerdida.mtdBuscarPerdida(id);

            txtProducto.Text = objDatosPerdida.idProducto.ToString();
            txtIDEmpleado.Text = objDatosPerdida.idEmpleado.ToString();
            txtRazon.Text = objDatosPerdida.razon;
            txtFechaHora.Text = objDatosPerdida.fecha.ToString();
            
        }
    }
}