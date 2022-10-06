<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Cliente/Cliente.Master" AutoEventWireup="true" CodeBehind="codigoAcceso.aspx.cs" Inherits="appShopplant.Presentacion.Cliente.datosUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <body class="img js-fullheight traslucido" style="background-image: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(Imagenes/fondoCodigoAcceso.jpg); background-repeat: no-repeat; background-attachment: fixed; background-size: cover;">
        <style>
            .traslucido {
                background: rgba(0, 0, 0,0.5)
            }
        </style>



        <div class="container ">
            <div class="row justify-content-center">
                <div class="col-lg-5 ">
                    <div class="card shadow-lg border-0 rounded-lg mt-5 traslucido b">

                        <form runat="server">

                            <div class="card-header">
                                <h3 class="text-center text-light my-4">PERMITIR ACCESO</h3>
                            </div>
                            <div class="card-body">


                                <div class="form-floating mb-3 ">
                                    <asp:TextBox ID="txtCorreoAcceso" runat="server" class="form-control" placeholder="Ingrese nuevamente su correo electrónico" TextMode="Email"></asp:TextBox>
                                    <label for="txtCorreoAcceso">Ingrese su correo electrónico</label>
                                </div>

                                <div class="mt-4 mb-0">
                                    <div class="d-grid">
                                        <asp:Button ID="btnEnviarCorreo" runat="server" Text="ENVIAR CORREO ELECTRONICO" class="btn btn-outline-success btn-block" OnClick="btnEnviarCorreo_Click" />
                                    </div>
                                </div>

                            </div>

                            <div class="card-body mt-3">
                                <div class="form-floating mb-3 ">
                                    <asp:TextBox ID="txtCodigo" runat="server" class="form-control" placeholder="Ingrese el código de verificación que se ha enviado a su correo" TextMode="Number"></asp:TextBox>
                                    <label for="txtCodigo">Codigo de acceso</label>
                                </div>

                                <div class="mt-4 mb-0">
                                    <div class="d-grid">
                                        <asp:Button ID="btnEnviarCodigo" runat="server" Text="ENVIAR" class="btn btn-outline-success btn-block" OnClick="btnEnviarCodigo_Click" />
                                    </div>
                                </div>
                            </div>



                        </form>

                    </div>
                </div>
            </div>
        </div>
    </body>
</asp:Content>
