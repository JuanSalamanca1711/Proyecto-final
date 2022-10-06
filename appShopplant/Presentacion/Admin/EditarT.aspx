<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Admin/Administrador.Master" AutoEventWireup="true" CodeBehind="EditarT.aspx.cs" Inherits="appShopplant.Presentacion.Admin.EditarT" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeadAdministrador" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBodyAdministrador" runat="server">

    <body class="img js-fullheight traslucido" style="background-image: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(imagenes/EDTA.jpg); background-repeat: no-repeat; background-attachment: fixed; background-size: cover;">
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
                                        <h3 class="text-center text-light my-4">EDITAR TAREA</h3>
                                    </div>

                                    <div class="container  mt-3">

                                        <form runat="server">

                                            <div class="form-floating mb-3 ">
                                                <asp:TextBox ID="txtBuscar" runat="server" class="form-control" placeholder="Ingrese el ID"></asp:TextBox>
                                                <label for="txtBuscar">Ingrese el ID de la Tarea</label>
                                            </div>

                                            <div class="d-grid">
                                                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-outline-success btn-block" OnClick="btnBuscar_Click" />
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtDescripcion" class="form-label text-light">Descripcion</label>
                                                <asp:TextBox ID="txtDescripcion" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                            <label for="txtFechaHora" class="form-label text-light">Fecha y Hora de Inicio</label>
                                            <div class="form-floating mb-3">
                                                <asp:TextBox ID="txtFechaHora" runat="server" TextMode="DateTime" class="form-control" placeholder="(YYYY-MM-DD HH:MM:SS) (Formato de hora 24hrs)"></asp:TextBox>
                                                <label for="txtFechaHora">(YYYY-MM-DD HH:MM:SS) (Formato de hora 24hrs)</label>

                                            </div>

                                            <div class="mb-3">
                                                <label for="txtIDEmpleado" class="form-label text-light">ID Empleado</label>
                                                <asp:TextBox ID="txtIDEmpleado" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtIDAdministrador" class="form-label text-light">ID Administrador</label>
                                                <asp:TextBox ID="txtIDAdministrador" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div class="mb-3">
                                                <label for="txtEstado" class="form-label text-light">Estado</label>
                                                <asp:TextBox ID="txtEstado" runat="server" class="form-control"></asp:TextBox>
                                            </div>

                                            <div>

                                                <asp:Button ID="btnEditar" class="btn btn-outline-success mb-5" runat="server" Text="Editar Tarea" OnClick="btnEditar_Click" />
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
