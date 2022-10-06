<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/Administrador.Master" AutoEventWireup="true" CodeBehind="responderReclamos.aspx.cs" Inherits="appShopplant.Presentacion.Admin.responderReclamos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeadAdministrador" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBodyAdministrador" runat="server">



    <body class="img js-fullheight">
        <style>
            .traslucido {
                top: -55px;
                left: 3px;
            }
        </style>


        <div class="container ">
            <form runat="server">
                <div class="row justify-content-center">
                    <div class="col-lg-10  mt-5">
                        <div class="card shadow-lg border-0 rounded-lg mt-5 traslucido b">



                            <div class="card-header">
                                <h3 class="text-center text-light my-4">RESPONDER QUEJAS Y RECLAMOS</h3>
                            </div>
                            <div class="card-body">


                                <div class="form-floating mb-3 ">
                                    <asp:TextBox ID="txtCorreo" runat="server" class="form-control" placeholder="Ingrese el correo"></asp:TextBox>
                                    <label for="txtCorreo">Correo al cual le respondera la queja/reclamo.</label>
                                </div>


                            </div>

                            <div class="card-body mt-3">
                                <div class="form-floating mb-3 ">
                                    <asp:TextBox ID="txtMensaje" runat="server" class="form-control" placeholder="Ingrese el mensaje"></asp:TextBox>
                                    <label for="txtMensaje">Mensaje a responder:</label>
                                </div>

                                <div class="mt-4 mb-0">
                                    <div class="d-grid">
                                        <asp:Button ID="btnResponder" runat="server" Text="RESPONDER" class="btn btn-outline-success btn-block" OnClick="btnResponder_Click" />
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>



                </div>
            </form>
        </div>


    </body>


</asp:Content>
