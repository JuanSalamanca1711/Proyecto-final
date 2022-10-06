using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appShopplant.Presentacion.Home
{
    public partial class accesoContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            //correo al que se va a enviar el codigo
            string accesoCorreo = txtEmail.Text;

            //numero aleatorio que sera enviado para validar el acceso
            Random objNumeroVerificacion = new Random();
            int numeroVerificacion = objNumeroVerificacion.Next(1, 9999 + 1);

            try
            {

                using (MailMessage objMailMessage = new MailMessage())
                {
                    //Destinatario
                    objMailMessage.To.Add(accesoCorreo);

                    //asunto
                    objMailMessage.Subject = "CODIGO DE ACCESO";

                    //Body del correo
                    objMailMessage.Body = "<h1>SOLICITUD PARA RECORDAR SUS DATOS</H1>"
                        + "¿Ha olvidado sus datos? Por favor, ingresa este número en el campo que se te solicita"
                       + "<h2>" + numeroVerificacion + "</h2>";
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
                    string script = String.Format(@"<script type='text/javascript'>alert('Hemos enviado un codigo de acceso a su correo electrónico, por favor verifique e ingreselo en el campo que lo solicita.');</script>", "0033");
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                }


            }
            catch (Exception)
            {

                throw;
            }

            //variable de cesión que esta guardando el codigo de acceso
            Session["codigoAcceso"] = numeroVerificacion;
        }

        protected void btnCodigo_Click(object sender, EventArgs e)
        {
            //validar que el codigo de acceso sea el que se envió al correo electronico
            if (txtCodigo.Text == Session["codigoAcceso"].ToString())
            {
                Response.Redirect("listarDatosOlvidados.aspx");
            }
            else
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Número de acceso incorrecto');</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }
    }
}