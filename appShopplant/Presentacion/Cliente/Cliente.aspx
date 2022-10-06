<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Cliente/Cliente.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="appShopplant.Presentacion.Cliente.Cliente1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <body class="img js-fullheight" style="background-image: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(Imagenes/fondoCliente.jpg); background-repeat: no-repeat; background-attachment: fixed; background-size: cover;">
        <style>
            .traslucido {
                top: -55px;
                left: 3px;
            }
        </style>


        <div class="container ">
            <form runat="server">
                <div class="row justify-content-center">

                    <%--   PROGRAMAR DE ACA PARA ABAJO--%>



                    <div class="col-lg-10  mt-5">
                        <div class="card shadow-lg border-0 rounded-lg mt-5 traslucido b">



                            <div class="card-header">
                                <h3 class="text-center text-light my-4">QUEJAS Y RECLAMOS</h3>
                            </div>
                            <div class="card-body">

                                <div class="form-floating mb-3 ">
                                    <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="Email"></asp:TextBox>
                                    <label for="txtEmail">Email del cliente</label>
                                </div>

                                <div class="d-grid">
                                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-outline-success btn-block" OnClick="btnBuscar_Click1" />
                                </div>


                            </div>

                            <div class="card-body">
                                
                                <div class="form-floating mb-3 mt-3">
                                    <asp:TextBox ID="txtID" runat="server" class="form-control" placeholder="ID" Visible="False"></asp:TextBox>
                                    <label for="txtID"></label>
                                </div>
                            </div>

                            
                            <div class="card-body">
                                
                                 <div class="form-floating mb-3 ">
                                    <asp:TextBox ID="txtEspecificacion" runat="server" class="form-control" placeholder="Ingrese nuevamente su motivo"></asp:TextBox>
                                    <label for="txtEspecificacion">Ingrese su queja y reclamo</label>
                                </div>
                            </div>

                            <div class="card-body mt-3">
                                <div class="form-floating mb-3 ">
                                    <asp:TextBox ID="txtFecha" runat="server" class="form-control" placeholder="Ingrese la fecha"></asp:TextBox>
                                    <label for="txtCodigo">Ingrese fecha y hora en el siguiente formato AAAA/MM/DD HH:MM</label>
                                </div>

                                <div class="mt-4 mb-0">
                                    <div class="d-grid">
                                        <asp:Button ID="btnEnviarQueja" runat="server" Text="ENVIAR" class="btn btn-outline-success btn-block" OnClick="btnEnviarQueja_Click" />
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
