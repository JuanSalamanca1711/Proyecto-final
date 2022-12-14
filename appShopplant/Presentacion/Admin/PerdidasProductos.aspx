<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/Administrador.Master" AutoEventWireup="true" CodeBehind="PerdidasProductos.aspx.cs" Inherits="appShopplant.Presentacion.Admin.PerdidasProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeadAdministrador" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBodyAdministrador" runat="server">

    <body class="img js-fullheight" style="background-image: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(imagenes/c.jpg); background-repeat: no-repeat; background-attachment: fixed; background-size: cover;">
        <style>
            .traslucido {
                background: rgba(0, 0, 0,0.5)
            }
        </style>
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5 traslucido">

                                    <div class="card-header">
                                        <h3 class="text-center text-light my-4">REGISTRAR PERDIDA DE UN PRODUCTO</h3>
                                    </div>

                                    <div class="container mt-3  ">
                                        <form runat="server">

                                            <div class="mb-3">
                                                <label for="txtProducto" class="form-label text-light">ID del Prodcuto</label>
                                                <asp:TextBox ID="txtProducto" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtEmpleado" class="form-label text-light">ID del Empleado</label>
                                                <asp:TextBox ID="txtEmpleado" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtRazon" class="form-label text-light">Razon de la Perdida</label>
                                                <asp:TextBox ID="txtRazon" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtFecha" class="form-label text-light">Fecha</label>
                                                <asp:TextBox ID="txtFecha" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div>

                                                <asp:Button ID="btnRegistrar" class="btn btn-outline-success mb-5" runat="server" Text="Registar Perdida" OnClick="btnRegistrar_Click"/>
                                            </div>

                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>

        </div>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="js/scripts.js"></script>
    </body>

</asp:Content>
