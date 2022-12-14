    <%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/Administrador.Master" AutoEventWireup="true" CodeBehind="EditarE.aspx.cs" Inherits="appShopplant.Presentacion.Admin.EditarE" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeadAdministrador" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBodyAdministrador" runat="server">

   <body class="img js-fullheight traslucido" style="background-image: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(imagenes/EDT.jpg); background-repeat: no-repeat; background-attachment: fixed; background-size: cover;">
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
                                        <h3 class="text-center text-light my-4">EDITAR EMPLEADO</h3>
                                    </div>

                                    <%--<div class="container-fluid bg-black ">
                                        <div class="container">
                                            <nav class="navbar navbar-expand-lg navbar-dark bg-black ">
                                                <a class="navbar-brand" href="#">Registro de Administradores</a>

                                            </nav>
                                        </div>
                                    </div>--%>

                                    <div class="container  mt-3">

                                        <form runat="server">

                                             <div class="form-floating mb-3 ">
                                            <asp:TextBox ID="txtBuscar" runat="server" class="form-control" placeholder="Ingrese el ID"></asp:TextBox>
                                            <label for="txtEmail">Ingrese el ID del Empleado</label>
                                        </div>

                                             <div class="d-grid">
                                                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-outline-success btn-block" OnClick="btnBuscar_Click"/>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtNombre" class="form-label text-light">Nombre</label>
                                                <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtApellido" class="form-label text-light">Apellido</label>
                                                <asp:TextBox ID="txtApellido" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtCelular" class="form-label text-light">Celular</label>
                                                <asp:TextBox ID="txtCelular" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtCorreo" class="form-label text-light">Correo</label>
                                                <asp:TextBox ID="txtCorreo" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtContraseña" class="form-label text-light">Contraseña</label>
                                                <asp:TextBox ID="txtContraseña" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtEstado" class="form-label text-light">Estado</label>
                                                <asp:TextBox ID="txtEstado" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtCargo" class="form-label text-light">Cargo</label>
                                                <asp:TextBox ID="txtCargo" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div>

                                                <asp:Button ID="btnEditar" class="btn btn-outline-success mb-5" runat="server" Text="Editar Empleado" OnClick="btnEditar_Click"/>
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
