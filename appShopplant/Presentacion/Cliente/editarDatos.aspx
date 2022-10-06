<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Cliente/Cliente.Master" AutoEventWireup="true" CodeBehind="editarDatos.aspx.cs" Inherits="appShopplant.Presentacion.Cliente.editarDatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <body class="img js-fullheight traslucido" style="background-image: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(Imagenes/fondoMostrarDatos.jpg); background-repeat: no-repeat; background-attachment: fixed; background-size: cover;"
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
                                <h3 class="text-center text-light my-4">CAMBIAR DATOS</h3>
                            </div>

                            <div class="card-body">
                                <div class="form-floating mb-3 ">
                                    <label for="txtCorreo" class="form-label text-light">Nombre</label>
                                    <asp:TextBox ID="txtCorreo" runat="server" class="form-control" placeholder="Ingrese su correo electrónico para buscar sus datos"></asp:TextBox>
                                    <label for="txtCorreo">Ingrese su correo electrónico para buscar sus datos</label>
                                </div>
                                <div class="mt-0 mb-0">
                                    <div class="d-grid">
                                        <asp:Button ID="btnBuscarDatos" runat="server" Text="BUSCAR DATOS" class="btn btn-outline-success btn-block" OnClick="btnBuscarDatos_Click" />
                                    </div>
                                </div>

                            </div>

                            <div class="card-body">
                                <div class="form-floating mb-3 ">
                                    <label for="txtNombre" class="form-label text-light">Nombre</label>
                                    <asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="Ingrese su nuevo nombre"></asp:TextBox>
                                    <label for="txtNombre">Ingrese su nuevo nombre</label>
                                </div>

                                <div class="form-floating mb-3 ">
                                    <label for="txtApellido" class="form-label text-light">Apellido</label>
                                    <asp:TextBox ID="txtApellido" runat="server" class="form-control" placeholder="Ingrese su nuevo apellido"></asp:TextBox>
                                    <label for="txtApellido">Ingrese su nuevo apellido</label>
                                </div>

                                <div class="form-floating mb-3 ">
                                    <label for="txtCelular" class="form-label text-light">Celular</label>
                                    <asp:TextBox ID="txtCelular" runat="server" class="form-control" placeholder="Ingrese su nuevo nro de celular"></asp:TextBox>
                                    <label for="txtCelular">Ingrese su nuevo nro de celular</label>
                                </div>

                                <div class="form-floating mb-3 ">
                                    <label for="txtDocumento" class="form-label text-light">Documento</label>
                                    <asp:TextBox ID="txtDocumento" runat="server" class="form-control" placeholder="Ingrese su nuevo nro de documento"></asp:TextBox>
                                    <label for="txtDocumento">Ingrese su nuevo nro de documento</label>
                                </div>

                                <div class="form-floating mb-3 ">
                                    <label for="txtContraseña" class="form-label text-light">Contraseña</label>
                                    <asp:TextBox ID="txtContraseña" runat="server" class="form-control" placeholder="Ingrese su nueva contraseña"></asp:TextBox>
                                    <label for="txtContraseña">Ingrese su nueva contraseña</label>
                                </div>

                                <div class="form-floating mb-3 ">
                                    <label for="txtCiudad" class="form-label text-light">Ciudad</label>
                                    <asp:TextBox ID="txtCiudad" runat="server" class="form-control" placeholder="Ingrese su nueva ciudad"></asp:TextBox>
                                    <label for="txtCiudad">Ingrese su nueva ciudad</label>
                                </div>
                            </div>

                            <div class="card-body mt-0">
                                <div class="mt-0 mb-0">
                                    <div class="d-grid">
                                        <asp:Button ID="btnActualizarDatos" runat="server" Text="ACTUALIZAR" class="btn btn-outline-success btn-block" OnClick="btnActualizarDatos_Click" />
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
