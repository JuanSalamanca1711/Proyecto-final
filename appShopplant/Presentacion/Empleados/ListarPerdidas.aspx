<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Empleados/Empleado.Master" AutoEventWireup="true" CodeBehind="ListarPerdidas.aspx.cs" Inherits="appShopplant.Presentacion.Empleados.ListarPerdidas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <body class="img js-fullheight" style="background-image: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(imagenes/a.jpg); background-repeat: no-repeat; background-attachment: fixed; background-size: cover;">
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
                                        <h3 class="text-center text-light my-4">BUSCAR PERDIDAS DE LOS PRODUCTOS</h3>
                                    </div>

                                    <div class="container  mt-3">

                                        <form runat="server">

                                            <div class="form-floating mb-3 ">
                                                <asp:TextBox ID="txtBuscar" runat="server" class="form-control" placeholder="Ingrese el ID de la Perdida"></asp:TextBox>
                                                <label for="txtBuscar">Ingrese el ID de la Perdida</label>
                                            </div>

                                            <div class="d-grid">
                                                <asp:Button ID="btnBuscarP" runat="server" Text="Buscar" class="btn btn-outline-success btn-block" OnClick="btnBuscarP_Click" />
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtProducto" class="form-label text-light">ID del Producto</label>
                                                <asp:TextBox ID="txtProducto" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                            

                                            <div class="mb-3">
                                                <label for="txtIDEmpleado" class="form-label text-light">ID Empleado</label>
                                                <asp:TextBox ID="txtIDEmpleado" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtRazon" class="form-label text-light">Razon de la Perdida</label>
                                                <asp:TextBox ID="txtRazon" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <label for="txtFechaHora" class="form-label text-light">Fecha y Hora del Registro</label>
                                            <div class="form-floating mb-3">
                                                <asp:TextBox ID="txtFechaHora" runat="server" TextMode="DateTime" class="form-control" placeholder="(YYYY-MM-DD HH:MM:SS) (Formato de hora 24hrs)"></asp:TextBox>
                                                <label for="txtFechaHora">(YYYY-MM-DD HH:MM:SS) (Formato de hora 24hrs)</label>

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
