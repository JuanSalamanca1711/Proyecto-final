using appShopplant.Entidades;
using appShopplant.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appShopplant.Presentacion
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            //Evitar el registro en caso de que el documento o correo electronico ya exista
            clClienteE objVerificarCliente = new clClienteE();

            objVerificarCliente.correoCliente = txtEmail.Text;
            objVerificarCliente.documento = txtDocumento.Text;

            clUsuarioL objVerificar = new clUsuarioL();
            clClienteE objVerificarC = objVerificar.mtdVerificar(objVerificarCliente);

            if (objVerificarC != null)
            {
                //mensaje en caso de que los datos ya existan
                string script = String.Format(@"<script type='text/javascript'>alert('El correo ingresado o el Nro de documento ya se encuentra en uso');</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
            else if (txtNombre.Text == "" || txtApellido.Text == "" || txtNroTelefono.Text == "" || txtDocumento.Text == "" || txtEmail.Text == "" || txtClave.Text == "" || txtCiudad.Text == "")
            {
                //mensaje en caso de que esten incompletos los campos de los datos
                string script = String.Format(@"<script type='text/javascript'>alert('HAY CAMPOS VACIOS, INTENTE NUEVAMENTE');</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);


            }
            else

            {

                //registro del cliente
                clClienteE objDatosCliente = new clClienteE();
                objDatosCliente.nombre = txtNombre.Text;
                objDatosCliente.apellido = txtApellido.Text;
                objDatosCliente.celular = txtNroTelefono.Text;
                objDatosCliente.documento = txtDocumento.Text;
                objDatosCliente.correoCliente = txtEmail.Text;
                objDatosCliente.contraseña = txtClave.Text;
                objDatosCliente.idCiudad = int.Parse(txtCiudad.Text);


                clUsuarioL objRegistrarClientes = new clUsuarioL();
                int result = objRegistrarClientes.mtdRegistrarCliente(objDatosCliente);

                if (result > 0)
                {
                    string script = String.Format(@"<script type='text/javascript'>alert('SE HA LOGRADO REGISTRAR CON EXITO');</script>", "0033");
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                    //Envio de correo para registro exitoso

                    Session["correo"] = objDatosCliente.correoCliente;
                    Session["nombreCliente"] = objDatosCliente.nombre + " " + objDatosCliente.apellido;

                    try
                    {

                        using (MailMessage objMailMessage = new MailMessage())
                        {
                            //Destinatario
                            objMailMessage.To.Add(Session["correo"].ToString());

                            //asunto
                            objMailMessage.Subject = "BIENVENIDO!!";

                            //Body del correo
                            objMailMessage.Body = "<h1>GRACIAS POR UNIRTE A NUESTRA FAMILIA SHOPPLANT</H1>"
                                + Session["nombreCliente"]
                                + " estamos agradecidos de tenerte con nosotros";
                            objMailMessage.IsBodyHtml = true;

                            //remitente
                            objMailMessage.From = new MailAddress("shopplant2022@gmail.com", "ALERTA");

                            using (SmtpClient cliente = new SmtpClient())
                            {

                                //contraseñas
                                cliente.UseDefaultCredentials = false;
                                cliente.Credentials = new NetworkCredential("shopplant2022@gmail.com", "cpochuggdmpivlmy");
                                cliente.Port = 587;
                                cliente.EnableSsl = true;

                                //host  
                                cliente.Host = "smtp.gmail.com";
                                cliente.Send(objMailMessage);
                            }


                        }


                    }
                    catch (Exception)
                    {

                        throw;
                    }


                    Response.Redirect("../Home/Login.aspx");
                }
            }

        }
    }
}