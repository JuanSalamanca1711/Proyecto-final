using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appShopplant.Presentacion.Admin
{
    public partial class responderReclamos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResponder_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            string correo = txtCorreo.Text;
            if (txtCorreo.Text == "" || txtMensaje.Text == "")
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Complete los campos anteriores');</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
            else
            {
                try
                {

                    using (MailMessage objMailMessage = new MailMessage())
                    {
                        //Destinatario
                        objMailMessage.To.Add(correo);

                        //asunto
                        objMailMessage.Subject = "HEMOS ATENDIDO TU PETICION";

                        //Body del correo
                        objMailMessage.Body = "<h1>RESPUESTA DE QUEJA/RECLAMO</H1>"
                            + mensaje;
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
                        string script = String.Format(@"<script type='text/javascript'>alert('Respuesta enviada con exito!!');</script>", "0033");
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                    }


                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}